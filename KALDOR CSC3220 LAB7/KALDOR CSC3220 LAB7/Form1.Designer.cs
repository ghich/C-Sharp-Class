namespace KALDOR_CSC3220_LAB7
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.clearTextToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fontDialogToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.redColorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.greenColorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.blueColorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fontColorDialogToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.aboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.fontNameStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.boldStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.italicStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.underlineStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dateStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainColorDialog = new System.Windows.Forms.ColorDialog();
            this.mainFontDialog = new System.Windows.Forms.FontDialog();
            this.mainTextBox = new System.Windows.Forms.TextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenuStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(374, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearTextToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.textToolStripMenuItem.Text = "&Text";
            // 
            // clearTextToolStripMenuItem
            // 
            this.clearTextToolStripMenuItem.Name = "clearTextToolStripMenuItem";
            this.clearTextToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.clearTextToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.clearTextToolStripMenuItem.Text = "C&lear Text";
            this.clearTextToolStripMenuItem.Click += new System.EventHandler(this.clearTextToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.fontToolStripMenuItem.Text = "&Font...";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.customToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.colorToolStripMenuItem.Text = "&Color";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // customToolStripMenuItem
            // 
            this.customToolStripMenuItem.Name = "customToolStripMenuItem";
            this.customToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.customToolStripMenuItem.Text = "Custom...";
            this.customToolStripMenuItem.Click += new System.EventHandler(this.customToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearTextToolStripButton,
            this.toolStripSeparator2,
            this.fontDialogToolStripButton,
            this.redColorToolStripButton,
            this.greenColorToolStripButton,
            this.blueColorToolStripButton,
            this.fontColorDialogToolStripButton,
            this.toolStripSeparator3,
            this.aboutToolStripButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 24);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(374, 25);
            this.mainToolStrip.TabIndex = 1;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // clearTextToolStripButton
            // 
            this.clearTextToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clearTextToolStripButton.Image = global::KALDOR_CSC3220_LAB7.Properties.Resources.Clearwindowcontent_6304_32;
            this.clearTextToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearTextToolStripButton.Name = "clearTextToolStripButton";
            this.clearTextToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.clearTextToolStripButton.Text = "clearTextToolStripButton";
            this.clearTextToolStripButton.Click += new System.EventHandler(this.clearTextToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // fontDialogToolStripButton
            // 
            this.fontDialogToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.fontDialogToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fontDialogToolStripButton.Image = global::KALDOR_CSC3220_LAB7.Properties.Resources.FontDialogControl_679_24;
            this.fontDialogToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontDialogToolStripButton.Name = "fontDialogToolStripButton";
            this.fontDialogToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.fontDialogToolStripButton.Text = "fontDialogToolStripButton";
            this.fontDialogToolStripButton.Click += new System.EventHandler(this.fontDialogToolStripButton_Click);
            // 
            // redColorToolStripButton
            // 
            this.redColorToolStripButton.BackColor = System.Drawing.Color.Maroon;
            this.redColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.redColorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("redColorToolStripButton.Image")));
            this.redColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redColorToolStripButton.Name = "redColorToolStripButton";
            this.redColorToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.redColorToolStripButton.Text = "toolStripButton3";
            this.redColorToolStripButton.Click += new System.EventHandler(this.redColorToolStripButton_Click);
            // 
            // greenColorToolStripButton
            // 
            this.greenColorToolStripButton.BackColor = System.Drawing.Color.DarkGreen;
            this.greenColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.greenColorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("greenColorToolStripButton.Image")));
            this.greenColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.greenColorToolStripButton.Name = "greenColorToolStripButton";
            this.greenColorToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.greenColorToolStripButton.Text = "toolStripButton4";
            this.greenColorToolStripButton.Click += new System.EventHandler(this.greenColorToolStripButton_Click);
            // 
            // blueColorToolStripButton
            // 
            this.blueColorToolStripButton.BackColor = System.Drawing.Color.DarkBlue;
            this.blueColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.blueColorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("blueColorToolStripButton.Image")));
            this.blueColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.blueColorToolStripButton.Name = "blueColorToolStripButton";
            this.blueColorToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.blueColorToolStripButton.Text = "toolStripButton2";
            this.blueColorToolStripButton.Click += new System.EventHandler(this.blueColorToolStripButton_Click);
            // 
            // fontColorDialogToolStripButton
            // 
            this.fontColorDialogToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fontColorDialogToolStripButton.Image = global::KALDOR_CSC3220_LAB7.Properties.Resources.FontColor_11146_24;
            this.fontColorDialogToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontColorDialogToolStripButton.Name = "fontColorDialogToolStripButton";
            this.fontColorDialogToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.fontColorDialogToolStripButton.Text = "fontColorDialogToolStripButton";
            this.fontColorDialogToolStripButton.Click += new System.EventHandler(this.fontColorDialogToolStripButton_Click);
            // 
            // aboutToolStripButton
            // 
            this.aboutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aboutToolStripButton.Image = global::KALDOR_CSC3220_LAB7.Properties.Resources.info_256;
            this.aboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutToolStripButton.Name = "aboutToolStripButton";
            this.aboutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.aboutToolStripButton.Text = "aboutToolStripButton";
            this.aboutToolStripButton.Click += new System.EventHandler(this.aboutToolStripButton_Click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontNameStatusLabel,
            this.boldStatusLabel,
            this.italicStatusLabel,
            this.underlineStatusLabel,
            this.dateStatusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 275);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(374, 22);
            this.mainStatusStrip.TabIndex = 2;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // fontNameStatusLabel
            // 
            this.fontNameStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.fontNameStatusLabel.Name = "fontNameStatusLabel";
            this.fontNameStatusLabel.Size = new System.Drawing.Size(77, 17);
            this.fontNameStatusLabel.Text = "Font and Size";
            // 
            // boldStatusLabel
            // 
            this.boldStatusLabel.Name = "boldStatusLabel";
            this.boldStatusLabel.Size = new System.Drawing.Size(31, 17);
            this.boldStatusLabel.Text = "Bold";
            // 
            // italicStatusLabel
            // 
            this.italicStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.italicStatusLabel.Name = "italicStatusLabel";
            this.italicStatusLabel.Size = new System.Drawing.Size(32, 17);
            this.italicStatusLabel.Text = "Italic";
            // 
            // underlineStatusLabel
            // 
            this.underlineStatusLabel.Name = "underlineStatusLabel";
            this.underlineStatusLabel.Size = new System.Drawing.Size(58, 17);
            this.underlineStatusLabel.Text = "Underline";
            // 
            // dateStatusLabel
            // 
            this.dateStatusLabel.AutoSize = false;
            this.dateStatusLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dateStatusLabel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dateStatusLabel.Name = "dateStatusLabel";
            this.dateStatusLabel.Size = new System.Drawing.Size(161, 17);
            this.dateStatusLabel.Spring = true;
            this.dateStatusLabel.Text = "Date";
            // 
            // mainTextBox
            // 
            this.mainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.mainTextBox.Location = new System.Drawing.Point(65, 137);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(245, 23);
            this.mainTextBox.TabIndex = 3;
            this.mainTextBox.Text = "\"Enter Message Here\"";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 297);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "mainForm";
            this.Text = "Text Editor";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton clearTextToolStripButton;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ColorDialog mainColorDialog;
        private System.Windows.Forms.FontDialog mainFontDialog;
        private System.Windows.Forms.ToolStripButton fontDialogToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton redColorToolStripButton;
        private System.Windows.Forms.ToolStripButton greenColorToolStripButton;
        private System.Windows.Forms.ToolStripButton blueColorToolStripButton;
        private System.Windows.Forms.ToolStripButton fontColorDialogToolStripButton;
        private System.Windows.Forms.ToolStripButton aboutToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customToolStripMenuItem;
        private System.Windows.Forms.TextBox mainTextBox;
        private System.Windows.Forms.ToolStripStatusLabel fontNameStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel boldStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel italicStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel underlineStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel dateStatusLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

