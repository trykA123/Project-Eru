namespace Project_Eru
{
    partial class Eru
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
            System.Windows.Forms.Label label1;
            this.BrowserList = new System.Windows.Forms.CheckedListBox();
            this.GamingList = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductivityList = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.upgradeAll = new System.Windows.Forms.Button();
            this.DevelopmentList = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IDESList = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MediaList = new System.Windows.Forms.CheckedListBox();
            this.UtilitiesList = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ThemeSwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(33, 64);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Browsers";
            // 
            // BrowserList
            // 
            this.BrowserList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowserList.FormattingEnabled = true;
            this.BrowserList.Items.AddRange(new object[] {
            "Mozzila Firefox",
            "Google Chrome",
            "Opera",
            "Opera GX",
            "Brave",
            "Tor Browser"});
            this.BrowserList.Location = new System.Drawing.Point(36, 94);
            this.BrowserList.Name = "BrowserList";
            this.BrowserList.Size = new System.Drawing.Size(198, 130);
            this.BrowserList.TabIndex = 0;
            this.BrowserList.SelectedIndexChanged += new System.EventHandler(this.BrowsersCheckedList);
            // 
            // GamingList
            // 
            this.GamingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamingList.FormattingEnabled = true;
            this.GamingList.Items.AddRange(new object[] {
            "Discord",
            "Steam",
            "Epic Games",
            "League of Legends",
            "EA Desktop Client"});
            this.GamingList.Location = new System.Drawing.Point(269, 94);
            this.GamingList.Name = "GamingList";
            this.GamingList.Size = new System.Drawing.Size(182, 109);
            this.GamingList.TabIndex = 1;
            this.GamingList.SelectedIndexChanged += new System.EventHandler(this.GamingCheckedList);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gaming";
            // 
            // ProductivityList
            // 
            this.ProductivityList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductivityList.FormattingEnabled = true;
            this.ProductivityList.Items.AddRange(new object[] {
            "Adobe Reader PDF",
            "SumatraPDF",
            "LibreOffice"});
            this.ProductivityList.Location = new System.Drawing.Point(486, 94);
            this.ProductivityList.Name = "ProductivityList";
            this.ProductivityList.Size = new System.Drawing.Size(181, 109);
            this.ProductivityList.TabIndex = 4;
            this.ProductivityList.SelectedIndexChanged += new System.EventHandler(this.ProductivityCheckList);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(483, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Productivity";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(36, 547);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Install";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.InstallClick);
            // 
            // upgradeAll
            // 
            this.upgradeAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upgradeAll.Location = new System.Drawing.Point(232, 547);
            this.upgradeAll.Name = "upgradeAll";
            this.upgradeAll.Size = new System.Drawing.Size(157, 52);
            this.upgradeAll.TabIndex = 7;
            this.upgradeAll.Text = "Update all apps";
            this.upgradeAll.UseVisualStyleBackColor = true;
            this.upgradeAll.Click += new System.EventHandler(this.UpgradeAllApps);
            // 
            // DevelopmentList
            // 
            this.DevelopmentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevelopmentList.FormattingEnabled = true;
            this.DevelopmentList.Items.AddRange(new object[] {
            "Python",
            "NodeJS",
            "Git",
            "Docker"});
            this.DevelopmentList.Location = new System.Drawing.Point(687, 94);
            this.DevelopmentList.Name = "DevelopmentList";
            this.DevelopmentList.Size = new System.Drawing.Size(152, 109);
            this.DevelopmentList.TabIndex = 8;
            this.DevelopmentList.SelectedIndexChanged += new System.EventHandler(this.DevelopmentCheckedList);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(684, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Development";
            // 
            // IDESList
            // 
            this.IDESList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDESList.FormattingEnabled = true;
            this.IDESList.Items.AddRange(new object[] {
            "VS Code",
            "PyCharm",
            "Vim",
            "Notepad++",
            "NeoVim",
            "Atom",
            "SublimeText",
            "Visual Studio"});
            this.IDESList.Location = new System.Drawing.Point(877, 94);
            this.IDESList.Name = "IDESList";
            this.IDESList.Size = new System.Drawing.Size(151, 172);
            this.IDESList.TabIndex = 10;
            this.IDESList.SelectedIndexChanged += new System.EventHandler(this.IDESCheckList);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(874, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "IDEs  / Text Editors";
            // 
            // MediaList
            // 
            this.MediaList.CheckOnClick = true;
            this.MediaList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediaList.FormattingEnabled = true;
            this.MediaList.Items.AddRange(new object[] {
            "VLC",
            "Spotify",
            "HandBrake"});
            this.MediaList.Location = new System.Drawing.Point(36, 292);
            this.MediaList.Name = "MediaList";
            this.MediaList.Size = new System.Drawing.Size(183, 130);
            this.MediaList.TabIndex = 12;
            this.MediaList.SelectedIndexChanged += new System.EventHandler(this.MediaCheckList);
            // 
            // UtilitiesList
            // 
            this.UtilitiesList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UtilitiesList.FormattingEnabled = true;
            this.UtilitiesList.Items.AddRange(new object[] {
            "Greenshot",
            "Lightshot",
            "7-zip",
            "Winrar",
            "PowerISO",
            "Bitwarden"});
            this.UtilitiesList.Location = new System.Drawing.Point(269, 292);
            this.UtilitiesList.Name = "UtilitiesList";
            this.UtilitiesList.Size = new System.Drawing.Size(182, 130);
            this.UtilitiesList.TabIndex = 13;
            this.UtilitiesList.SelectedIndexChanged += new System.EventHandler(this.UtilitiesCheckList);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Media";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(266, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Utilities";
            // 
            // ThemeSwitch
            // 
            this.ThemeSwitch.AutoSize = true;
            this.ThemeSwitch.Depth = 0;
            this.ThemeSwitch.Location = new System.Drawing.Point(846, 562);
            this.ThemeSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.ThemeSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ThemeSwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.ThemeSwitch.Name = "ThemeSwitch";
            this.ThemeSwitch.Ripple = true;
            this.ThemeSwitch.Size = new System.Drawing.Size(94, 37);
            this.ThemeSwitch.TabIndex = 17;
            this.ThemeSwitch.Text = "Light";
            this.ThemeSwitch.UseVisualStyleBackColor = true;
            this.ThemeSwitch.CheckedChanged += new System.EventHandler(this.materialSwitch1_CheckedChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(732, 571);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 18;
            this.materialLabel1.Text = "Theme";
            // 
            // Eru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1054, 636);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.ThemeSwitch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UtilitiesList);
            this.Controls.Add(this.MediaList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IDESList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DevelopmentList);
            this.Controls.Add(this.upgradeAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductivityList);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.GamingList);
            this.Controls.Add(this.BrowserList);
            this.Name = "Eru";
            this.Text = "Eru";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox BrowserList;
        private System.Windows.Forms.CheckedListBox GamingList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox ProductivityList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button upgradeAll;
        private System.Windows.Forms.CheckedListBox DevelopmentList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox IDESList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox MediaList;
        private System.Windows.Forms.CheckedListBox UtilitiesList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private MaterialSkin.Controls.MaterialSwitch ThemeSwitch;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}

