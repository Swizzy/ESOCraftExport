namespace ESOCraftExport {
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;

    public partial class MainForm: Form {
        public MainForm() {
            InitializeComponent();
            foreach(var s in Directory.GetDirectories(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Elder Scrolls Online")))
                ServerListBox.Items.Add(new Server(s));
            ServerListBox.SelectedIndex = 0;
        }

        private void ServerListBox_SelectedIndexChanged(object sender, EventArgs e) { AccountBox.DataSource = ((Server)ServerListBox.SelectedItem).Accounts; }

        private void AccountBox_SelectedIndexChanged(object sender, EventArgs e) { CharacterBox.DataSource = ((Server.Account)AccountBox.SelectedItem).Characters; }

        private void CharacterBox_SelectedIndexChanged(object sender, EventArgs e) {
            StylesBox.Items.Clear();
            foreach(var style in ((Server.Account.Character)CharacterBox.SelectedItem).Styles)
                StylesBox.Items.Add(style.Key);
        }

        private class Server {
            internal readonly List<Account> Accounts = new List<Account>();
            private readonly string _name;

            public Server(string dir) {
                _name = Path.GetFileName(dir);
                var tmp = Path.Combine(Path.Combine(dir, "SavedVariables"), "CraftExport.lua");
                if(File.Exists(tmp))
                    ParseTable(tmp);
            }

            private static bool IsRubbish(string line) {
                return line.Trim().Equals("{") || line.Trim().Equals("}") || (line.Trim().StartsWith("CraftExport =") || line.Trim().Equals("[\"version\"] = 1,", StringComparison.CurrentCultureIgnoreCase));
            }

            private static bool IsAccount(string line) { return line.Trim().StartsWith("[\"@") && line.Trim().EndsWith("\"] ="); }

            private static string GetSectionName(string line) {
                line = line.Trim();
                line = line.Substring(2);
                return line.Substring(0, line.Length - 4);
            }

            private void ParseTable(string file) {
                Account acc = null;
                Account.Character Char = null;
                var endMarkerReached = false;
                var sectionEndMarkerReached = false;
                var currentSection = "";
                //var subSection = "";
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
                        if (sectionEndMarkerReached)
                            endMarkerReached = true;
                        else if(!endMarkerReached)
                            sectionEndMarkerReached = true;
                        if(Char != null && Char.IsComplete) {
                            acc.Characters.Add(Char);
                            Char = null;
                            endMarkerReached = true;
                            sectionEndMarkerReached = false;
                        }
                        if (sectionEndMarkerReached)
                            currentSection = "";
                        continue;
                    }
                    if(Char == null) {
                        Char = new Account.Character(GetSectionName(line));
                        continue;
                    }
                    if(string.IsNullOrEmpty(currentSection)) {
                        currentSection = GetSectionName(line);
                        continue;
                    }
                    //if(string.IsNullOrEmpty(subSection))
                        Char.AddSection(currentSection, line);
                    //else
                        //Char.AddSection(currentSection, subSection, line);
                }
                if(acc != null) {
                    if(Char != null)
                        acc.Characters.Add(Char);
                    Accounts.Add(acc);
                }
            }

            private bool IsEndMarker(string line) { return line.Trim().Equals("},"); }

            public override string ToString() { return _name; }

            internal class Account {
                private readonly string _name;
                internal readonly List<Character> Characters = new List<Character>();

                public Account(string name) { _name = name; }

                public override string ToString() { return _name; }

                internal class Character {
                    internal readonly Dictionary<string, bool> Styles = new Dictionary<string, bool>();

                    private readonly string _name;

                    public Character(string name) { _name = name; }

                    public bool IsComplete { get { return Styles.Count == 14; } }

                    public override string ToString() { return _name; }

                    public void AddSection(string currentSection, string line) {
                        if(currentSection.Equals("Styles", StringComparison.CurrentCultureIgnoreCase)) {
                            var style = line.Trim().Substring(2);
                            style = style.Substring(0, style.Length - 7);
                            if (!Styles.ContainsKey(style))
                                Styles.Add(style, line.EndsWith("1,"));
                        }
                    }

                    public void AddSection(string currentSection, string subSection, string line) {
                        if(currentSection.Equals("Woodworking", StringComparison.CurrentCultureIgnoreCase)) {}
                        else if(currentSection.Equals("Blacksmithing", StringComparison.CurrentCultureIgnoreCase)) {}
                        else if(currentSection.Equals("Clothing_Light", StringComparison.CurrentCultureIgnoreCase)) {}
                        else if(currentSection.Equals("Clothing_Medium", StringComparison.CurrentCultureIgnoreCase)) {}
                    }
                }
            }
        }
    }
}