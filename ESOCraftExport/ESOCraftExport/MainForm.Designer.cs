namespace ESOCraftExport
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ServerListBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AccountBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CharacterBox = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.FilterWeapons = new System.Windows.Forms.RadioButton();
            this.FilterArmors = new System.Windows.Forms.RadioButton();
            this.FilterClothingMedium = new System.Windows.Forms.CheckBox();
            this.FilterClothingLight = new System.Windows.Forms.CheckBox();
            this.FilterWoodworking = new System.Windows.Forms.CheckBox();
            this.FilterBlacksmithing = new System.Windows.Forms.CheckBox();
            this.StylesBox = new ESOCraftExport.CustomListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ServerListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 46);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // ServerListBox
            // 
            this.ServerListBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerListBox.FormattingEnabled = true;
            this.ServerListBox.Location = new System.Drawing.Point(6, 19);
            this.ServerListBox.Name = "ServerListBox";
            this.ServerListBox.Size = new System.Drawing.Size(123, 21);
            this.ServerListBox.TabIndex = 0;
            this.ServerListBox.SelectedIndexChanged += new System.EventHandler(this.ServerListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1023, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Styles:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AccountBox);
            this.groupBox2.Location = new System.Drawing.Point(153, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 46);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account";
            // 
            // AccountBox
            // 
            this.AccountBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountBox.FormattingEnabled = true;
            this.AccountBox.Location = new System.Drawing.Point(6, 19);
            this.AccountBox.Name = "AccountBox";
            this.AccountBox.Size = new System.Drawing.Size(123, 21);
            this.AccountBox.TabIndex = 0;
            this.AccountBox.SelectedIndexChanged += new System.EventHandler(this.AccountBox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CharacterBox);
            this.groupBox3.Location = new System.Drawing.Point(294, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 46);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Character";
            // 
            // CharacterBox
            // 
            this.CharacterBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CharacterBox.FormattingEnabled = true;
            this.CharacterBox.Location = new System.Drawing.Point(6, 19);
            this.CharacterBox.Name = "CharacterBox";
            this.CharacterBox.Size = new System.Drawing.Size(174, 21);
            this.CharacterBox.TabIndex = 0;
            this.CharacterBox.SelectedIndexChanged += new System.EventHandler(this.CharacterBox_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader16,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(12, 115);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1008, 168);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Type";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Charged";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Defending";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 69;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Divines";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Exploration";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Impenetrable";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Infused";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Powered";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Precise";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Reinforced";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Sharpened";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Sturdy";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Training";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Weighted";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "WellFitted";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Rescan Servers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.FilterWeapons);
            this.groupBox4.Controls.Add(this.FilterArmors);
            this.groupBox4.Controls.Add(this.FilterClothingMedium);
            this.groupBox4.Controls.Add(this.FilterClothingLight);
            this.groupBox4.Controls.Add(this.FilterWoodworking);
            this.groupBox4.Controls.Add(this.FilterBlacksmithing);
            this.groupBox4.Location = new System.Drawing.Point(12, 64);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(639, 42);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Filter";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(597, 18);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(36, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "All";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // FilterWeapons
            // 
            this.FilterWeapons.AutoSize = true;
            this.FilterWeapons.Location = new System.Drawing.Point(495, 19);
            this.FilterWeapons.Name = "FilterWeapons";
            this.FilterWeapons.Size = new System.Drawing.Size(95, 17);
            this.FilterWeapons.TabIndex = 1;
            this.FilterWeapons.Text = "Only Weapons";
            this.FilterWeapons.UseVisualStyleBackColor = true;
            this.FilterWeapons.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // FilterArmors
            // 
            this.FilterArmors.AutoSize = true;
            this.FilterArmors.Location = new System.Drawing.Point(407, 19);
            this.FilterArmors.Name = "FilterArmors";
            this.FilterArmors.Size = new System.Drawing.Size(81, 17);
            this.FilterArmors.TabIndex = 1;
            this.FilterArmors.Text = "Only Armors";
            this.FilterArmors.UseVisualStyleBackColor = true;
            this.FilterArmors.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // FilterClothingMedium
            // 
            this.FilterClothingMedium.AutoSize = true;
            this.FilterClothingMedium.Checked = true;
            this.FilterClothingMedium.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FilterClothingMedium.Location = new System.Drawing.Point(297, 19);
            this.FilterClothingMedium.Name = "FilterClothingMedium";
            this.FilterClothingMedium.Size = new System.Drawing.Size(104, 17);
            this.FilterClothingMedium.TabIndex = 0;
            this.FilterClothingMedium.Text = "Clothing Medium";
            this.FilterClothingMedium.UseVisualStyleBackColor = true;
            this.FilterClothingMedium.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // FilterClothingLight
            // 
            this.FilterClothingLight.AutoSize = true;
            this.FilterClothingLight.Checked = true;
            this.FilterClothingLight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FilterClothingLight.Location = new System.Drawing.Point(201, 19);
            this.FilterClothingLight.Name = "FilterClothingLight";
            this.FilterClothingLight.Size = new System.Drawing.Size(90, 17);
            this.FilterClothingLight.TabIndex = 0;
            this.FilterClothingLight.Text = "Clothing Light";
            this.FilterClothingLight.UseVisualStyleBackColor = true;
            this.FilterClothingLight.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // FilterWoodworking
            // 
            this.FilterWoodworking.AutoSize = true;
            this.FilterWoodworking.Checked = true;
            this.FilterWoodworking.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FilterWoodworking.Location = new System.Drawing.Point(103, 19);
            this.FilterWoodworking.Name = "FilterWoodworking";
            this.FilterWoodworking.Size = new System.Drawing.Size(92, 17);
            this.FilterWoodworking.TabIndex = 0;
            this.FilterWoodworking.Text = "Woodworking";
            this.FilterWoodworking.UseVisualStyleBackColor = true;
            this.FilterWoodworking.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // FilterBlacksmithing
            // 
            this.FilterBlacksmithing.AutoSize = true;
            this.FilterBlacksmithing.Checked = true;
            this.FilterBlacksmithing.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FilterBlacksmithing.Location = new System.Drawing.Point(6, 19);
            this.FilterBlacksmithing.Name = "FilterBlacksmithing";
            this.FilterBlacksmithing.Size = new System.Drawing.Size(91, 17);
            this.FilterBlacksmithing.TabIndex = 0;
            this.FilterBlacksmithing.Text = "Blacksmithing";
            this.FilterBlacksmithing.UseVisualStyleBackColor = true;
            this.FilterBlacksmithing.CheckedChanged += new System.EventHandler(this.Filter_CheckedChanged);
            // 
            // StylesBox
            // 
            this.StylesBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StylesBox.ItemHeight = 16;
            this.StylesBox.Location = new System.Drawing.Point(1026, 39);
            this.StylesBox.Name = "StylesBox";
            this.StylesBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.StylesBox.Size = new System.Drawing.Size(120, 244);
            this.StylesBox.Sorted = true;
            this.StylesBox.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 295);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.StylesBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(1174, 333);
            this.Name = "MainForm";
            this.Text = "ESOCraftExport";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ServerListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox AccountBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CharacterBox;
        private CustomListBox StylesBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox FilterBlacksmithing;
        private System.Windows.Forms.CheckBox FilterWoodworking;
        private System.Windows.Forms.CheckBox FilterClothingLight;
        private System.Windows.Forms.CheckBox FilterClothingMedium;
        private System.Windows.Forms.RadioButton FilterArmors;
        private System.Windows.Forms.RadioButton FilterWeapons;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

