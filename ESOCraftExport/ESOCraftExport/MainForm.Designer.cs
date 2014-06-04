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
            this.StylesBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AccountBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CharacterBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            // StylesBox
            // 
            this.StylesBox.Location = new System.Drawing.Point(486, 38);
            this.StylesBox.Name = "StylesBox";
            this.StylesBox.Size = new System.Drawing.Size(120, 212);
            this.StylesBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 22);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StylesBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ServerListBox;
        private System.Windows.Forms.ListBox StylesBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox AccountBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox CharacterBox;
    }
}

