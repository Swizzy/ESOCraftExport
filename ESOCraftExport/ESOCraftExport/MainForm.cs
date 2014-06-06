namespace ESOCraftExport {
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    public partial class MainForm: Form {
        private readonly List<Server> _servers = new List<Server>();

        public MainForm() {
            InitializeComponent();
            ReloadServerList();
        }

        private void ReloadServerList() {
            ServerListBox.DataSource = null;
            _servers.Clear();
            var tmp = new List<Server>();
            foreach(var s in Directory.GetDirectories(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Elder Scrolls Online")))
                tmp.Add(new Server(s));
            foreach(var server in tmp) {
                if(server.Exists)
                    _servers.Add(server);
            }
            ServerListBox.DataSource = _servers;
        }

        private void ServerListBox_SelectedIndexChanged(object sender, EventArgs e) { AccountBox.DataSource = ((Server)ServerListBox.SelectedItem).Accounts; }

        private void AccountBox_SelectedIndexChanged(object sender, EventArgs e) { CharacterBox.DataSource = ((Server.Account)AccountBox.SelectedItem).Characters; }

        private ListViewItem.ListViewSubItem GetSubItemFormatted(ref ListViewItem owner, Server.Account.Character.WeaponArmorItem.TraitStatus status) {
            var ret = new ListViewItem.ListViewSubItem(owner, status.ToString());
            switch(status) {
                case Server.Account.Character.WeaponArmorItem.TraitStatus.Learned:
                    ret.BackColor = Color.Green;
                    break;
                case Server.Account.Character.WeaponArmorItem.TraitStatus.InTraining:
                    ret.BackColor = Color.Yellow;
                    break;
                case Server.Account.Character.WeaponArmorItem.TraitStatus.Stored:
                    ret.BackColor = Color.BurlyWood;
                    break;
                case Server.Account.Character.WeaponArmorItem.TraitStatus.Missing:
                    ret.BackColor = Color.Red;
                    break;
                case Server.Account.Character.WeaponArmorItem.TraitStatus.NotAvailable:
                    ret.Text = @"N/A";
                    break;
            }
            return ret;
        }

        private void AddListViewItem(string type, KeyValuePair<string, Server.Account.Character.WeaponArmorItem> tmp) {
            var itm = new ListViewItem(tmp.Key) {
                                                    UseItemStyleForSubItems = false
                                                };
            itm.SubItems.Add(type);
            itm.SubItems.Add(GetSubItemFormatted(ref itm, tmp.Value.Charged));
            itm.SubItems.Add(GetSubItemFormatted(ref itm, tmp.Value.Defending));
            itm.SubItems.Add(GetSubItemFormatted(ref itm, tmp.Value.Divines));
            itm.SubItems.Add(GetSubItemFormatted(ref itm, tmp.Value.Exploration));
            itm.SubItems.Add(GetSubItemFormatted(ref itm, tmp.Value.Impenetrable));
            itm.SubItems.Add(GetSubItemFormatted(ref itm, tmp.Value.Infused));
            itm.SubItems.Add(GetSubItemFormatted(ref itm, tmp.Value.Powered));
            itm.SubItems.Add(GetSubItemFormatted(ref itm, tmp.Value.Precise));
            itm.SubItems.Add(GetSubItemFormatted(ref itm, tmp.Value.Reinforced));
            itm.SubItems.Add(GetSubItemFormatted(ref itm, tmp.Value.Sharpened));
            itm.SubItems.Add(GetSubItemFormatted(ref itm, tmp.Value.Sturdy));
            itm.SubItems.Add(GetSubItemFormatted(ref itm, tmp.Value.Training));
            itm.SubItems.Add(GetSubItemFormatted(ref itm, tmp.Value.Weighted));
            itm.SubItems.Add(GetSubItemFormatted(ref itm, tmp.Value.WellFitted));
            listView1.Items.Add(itm);
        }

        private void CharacterBox_SelectedIndexChanged(object sender, EventArgs e) {
            StylesBox.Items.Clear();
            listView1.Items.Clear();
            if(CharacterBox.SelectedItem == null)
                return;
            foreach(var style in ((Server.Account.Character)CharacterBox.SelectedItem).Styles)
                StylesBox.Items.Add(new CustomListBox.CustomListBoxItem(style.Key, style.Value));
            if(FilterBlacksmithing.Checked) {
                foreach(var tmp in ((Server.Account.Character)CharacterBox.SelectedItem).Blacksmithing) {
                    if(FilterWeapons.Checked && tmp.Value.Armor)
                        continue;
                    if(FilterArmors.Checked && !tmp.Value.Armor)
                        continue;
                    AddListViewItem(!tmp.Value.Armor ? "Blacksmithing" : "Heavy Armor", tmp);
                }
            }
            if(FilterWoodworking.Checked) {
                foreach(var tmp in ((Server.Account.Character)CharacterBox.SelectedItem).Woodworking) {
                    if(FilterWeapons.Checked && tmp.Value.Armor)
                        continue;
                    if(FilterArmors.Checked && !tmp.Value.Armor)
                        continue;
                    AddListViewItem("Woodworking", tmp);
                }
            }
            if(FilterClothingLight.Checked && !FilterWeapons.Checked) {
                foreach(var tmp in ((Server.Account.Character)CharacterBox.SelectedItem).ClothingLight)
                    AddListViewItem("Light Armor", tmp);
            }
            if(FilterClothingMedium.Checked && !FilterWeapons.Checked) {
                foreach(var tmp in ((Server.Account.Character)CharacterBox.SelectedItem).ClothingMedium)
                    AddListViewItem("Medium Armor", tmp);
            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            if(listView1.Items.Count > 0) {
                listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
                listView1.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
            }
        }

        private void button1_Click(object sender, EventArgs e) { ReloadServerList(); }

        private void Filter_CheckedChanged(object sender, EventArgs e) {
            CharacterBox_SelectedIndexChanged(null, null);
        }

        private class Server {
            internal readonly List<Account> Accounts = new List<Account>();
            internal readonly bool Exists;
            private readonly string _name;

            public Server(string dir) {
                _name = Path.GetFileName(dir);
                var tmp = Path.Combine(Path.Combine(dir, "SavedVariables"), "CraftExport.lua");
                if(File.Exists(tmp))
                    ParseTable(tmp);
                Exists = File.Exists(tmp);
            }

            private static bool IsRubbish(string line) {
                return line.Trim().Equals("{") || line.Trim().Equals("}") ||
                       (line.Trim().StartsWith("CraftExport =") || line.Trim().Equals("[\"version\"] = 1,", StringComparison.CurrentCultureIgnoreCase));
            }

            private static bool IsAccount(string line) { return line.Trim().StartsWith("[\"@") && line.Trim().EndsWith("\"] ="); }

            private static string GetSectionName(string line) {
                var start = line.IndexOf("[\"", StringComparison.Ordinal);
                var end = line.LastIndexOf("\"]", StringComparison.Ordinal);
                if(start >= 0 && end > 0)
                    return line.Substring(start + 2, end - (start + 2));
                return line;
            }

            private void ParseTable(string file) {
                Account acc = null;
                Account.Character Char = null;
                var currentSection = "";
                var subSection = "";
                foreach(var line in File.ReadAllLines(file)) {
                    if(IsRubbish(line))
                        continue;
                    if(IsAccount(line)) {
                        if(acc != null)
                            Accounts.Add(acc);
                        acc = new Account(GetSectionName(line));
                        continue;
                    }
                    if(acc == null)
                        continue;
                    if(IsEndMarker(line)) {
                        if(Char != null && currentSection == "" && subSection == "") {
                            acc.Characters.Add(Char);
                            Char = null;
                        }
                        if(subSection == "")
                            currentSection = "";
                        else
                            subSection = "";
                        continue;
                    }
                    if(Char == null) {
                        Char = new Account.Character(GetSectionName(line));
                        continue;
                    }
                    if(currentSection == "") {
                        currentSection = GetSectionName(line);
                        continue;
                    }
                    if(subSection == "" && !currentSection.Equals("styles", StringComparison.CurrentCultureIgnoreCase)) {
                        subSection = GetSectionName(line);
                        continue;
                    }
                    if(subSection == "")
                        Char.AddSection(currentSection, line);
                    else
                        Char.AddSection(currentSection, subSection, line);
                }
                if(acc != null)
                    Accounts.Add(acc);
            }

            private static bool IsEndMarker(string line) { return line.Trim().Equals("},"); }

            public override string ToString() { return _name; }

            internal class Account {
                internal readonly List<Character> Characters = new List<Character>();
                private readonly string _name;

                public Account(string name) { _name = name; }

                public override string ToString() { return _name; }

                internal class Character {
                    internal readonly Dictionary<string, bool> Styles = new Dictionary<string, bool>();
                    private readonly string _name;
                    internal Dictionary<string, WeaponArmorItem> Blacksmithing = new Dictionary<string, WeaponArmorItem>();
                    internal Dictionary<string, WeaponArmorItem> ClothingLight = new Dictionary<string, WeaponArmorItem>();
                    internal Dictionary<string, WeaponArmorItem> ClothingMedium = new Dictionary<string, WeaponArmorItem>();
                    internal Dictionary<string, WeaponArmorItem> Woodworking = new Dictionary<string, WeaponArmorItem>();

                    public Character(string name) { _name = name; }

                    public override string ToString() { return _name; }

                    public void AddSection(string currentSection, string line) {
                        if(!currentSection.Equals("Styles", StringComparison.CurrentCultureIgnoreCase))
                            return;
                        var style = GetSectionName(line);
                        if(!Styles.ContainsKey(style))
                            Styles.Add(style, line.EndsWith("1,"));
                    }

                    private static void UpdateTrait(ref Dictionary<string, WeaponArmorItem> list, string line, string subSection) {
                        if(!list.ContainsKey(subSection))
                            list.Add(subSection, new WeaponArmorItem());
                        var trait = GetSectionName(line);
                        if(trait.Equals("Armor", StringComparison.CurrentCultureIgnoreCase)) {
                            list[subSection].Armor = line.Trim().EndsWith("= true,");
                            return;
                        }
                        line = line.Trim();
                        var traitStatus = byte.Parse(line.Substring(line.Length - 2, 1));
                        switch(trait) {
                            case "Divines":
                                list[subSection].Divines = (WeaponArmorItem.TraitStatus)traitStatus;
                                break;
                            case "WellFitted":
                                list[subSection].WellFitted = (WeaponArmorItem.TraitStatus)traitStatus;
                                break;
                            case "Training":
                                list[subSection].Training = (WeaponArmorItem.TraitStatus)traitStatus;
                                break;
                            case "Infused":
                                list[subSection].Infused = (WeaponArmorItem.TraitStatus)traitStatus;
                                break;
                            case "Impenetrable":
                                list[subSection].Impenetrable = (WeaponArmorItem.TraitStatus)traitStatus;
                                break;
                            case "Sturdy":
                                list[subSection].Sturdy = (WeaponArmorItem.TraitStatus)traitStatus;
                                break;
                            case "Exploration":
                                list[subSection].Exploration = (WeaponArmorItem.TraitStatus)traitStatus;
                                break;
                            case "Reinforced":
                                list[subSection].Reinforced = (WeaponArmorItem.TraitStatus)traitStatus;
                                break;
                            case "Defending":
                                list[subSection].Defending = (WeaponArmorItem.TraitStatus)traitStatus;
                                break;
                            case "Charged":
                                list[subSection].Charged = (WeaponArmorItem.TraitStatus)traitStatus;
                                break;
                            case "Weighted":
                                list[subSection].Weighted = (WeaponArmorItem.TraitStatus)traitStatus;
                                break;
                            case "Sharpened":
                                list[subSection].Sharpened = (WeaponArmorItem.TraitStatus)traitStatus;
                                break;
                            case "Precise":
                                list[subSection].Precise = (WeaponArmorItem.TraitStatus)traitStatus;
                                break;
                            case "Powered":
                                list[subSection].Powered = (WeaponArmorItem.TraitStatus)traitStatus;
                                break;
                        }
                    }

                    public void AddSection(string currentSection, string subSection, string line) {
                        if(currentSection.Equals("Woodworking", StringComparison.CurrentCultureIgnoreCase))
                            UpdateTrait(ref Woodworking, line, subSection);
                        else if(currentSection.Equals("Blacksmithing", StringComparison.CurrentCultureIgnoreCase))
                            UpdateTrait(ref Blacksmithing, line, subSection);
                        else if(currentSection.Equals("Clothing_Light", StringComparison.CurrentCultureIgnoreCase))
                            UpdateTrait(ref ClothingLight, line, subSection);
                        else if(currentSection.Equals("Clothing_Medium", StringComparison.CurrentCultureIgnoreCase))
                            UpdateTrait(ref ClothingMedium, line, subSection);
                    }

                    internal class WeaponArmorItem {
                        internal bool Armor;

                        #region Weapon Traits

                        internal TraitStatus Charged = TraitStatus.NotAvailable;
                        internal TraitStatus Defending = TraitStatus.NotAvailable;
                        internal TraitStatus Powered = TraitStatus.NotAvailable;
                        internal TraitStatus Precise = TraitStatus.NotAvailable;
                        internal TraitStatus Sharpened = TraitStatus.NotAvailable;
                        internal TraitStatus Weighted = TraitStatus.NotAvailable;

                        #endregion

                        #region Common Traits

                        internal TraitStatus Infused = TraitStatus.NotAvailable;
                        internal TraitStatus Training = TraitStatus.NotAvailable;

                        #endregion

                        #region Armor Traits

                        internal TraitStatus Divines = TraitStatus.NotAvailable;
                        internal TraitStatus Exploration = TraitStatus.NotAvailable;
                        internal TraitStatus Impenetrable = TraitStatus.NotAvailable;
                        internal TraitStatus Reinforced = TraitStatus.NotAvailable;
                        internal TraitStatus Sturdy = TraitStatus.NotAvailable;
                        internal TraitStatus WellFitted = TraitStatus.NotAvailable;

                        #endregion

                        internal enum TraitStatus: byte {
                            Missing = 0,
                            Learned = 1,
                            InTraining = 2,
                            Stored = 3,
                            NotAvailable = byte.MaxValue
                        }
                    }
                }
            }
        }
    }
}