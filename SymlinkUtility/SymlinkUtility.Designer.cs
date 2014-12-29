namespace SymlinkUtility
{
    partial class SymlinkUtility
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SymlinkUtility));
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.btnSourcePath = new System.Windows.Forms.Button();
            this.ofdSymlinkUtility = new System.Windows.Forms.OpenFileDialog();
            this.lblSourcePath = new System.Windows.Forms.Label();
            this.fbdSymlinkUtility = new System.Windows.Forms.FolderBrowserDialog();
            this.radSourceTypeFolder = new System.Windows.Forms.RadioButton();
            this.radSourceTypeFile = new System.Windows.Forms.RadioButton();
            this.lblNewLinkLocation = new System.Windows.Forms.Label();
            this.btnNewLinkLocation = new System.Windows.Forms.Button();
            this.txtNewLinkLocation = new System.Windows.Forms.TextBox();
            this.btnCreateLink = new System.Windows.Forms.Button();
            this.errSymlinkUtility = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblNewLinkName = new System.Windows.Forms.Label();
            this.txtNewLinkName = new System.Windows.Forms.TextBox();
            this.grpSourceType = new System.Windows.Forms.GroupBox();
            this.mnuSymlinkUtility = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileCreateLink = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileClear = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSourceType = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSourceTypeFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSourceTypeFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSymlinkUtility = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.ttpSymlinkUtility = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errSymlinkUtility)).BeginInit();
            this.grpSourceType.SuspendLayout();
            this.mnuSymlinkUtility.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Location = new System.Drawing.Point(15, 190);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(253, 26);
            this.txtSourcePath.TabIndex = 0;
            this.ttpSymlinkUtility.SetToolTip(this.txtSourcePath, "Input the source path for a folder or file here.");
            this.txtSourcePath.TextChanged += new System.EventHandler(this.txtSourcePath_TextChanged);
            // 
            // btnSourcePath
            // 
            this.btnSourcePath.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnSourcePath.Location = new System.Drawing.Point(274, 190);
            this.btnSourcePath.Name = "btnSourcePath";
            this.btnSourcePath.Size = new System.Drawing.Size(30, 26);
            this.btnSourcePath.TabIndex = 1;
            this.btnSourcePath.Text = "...";
            this.ttpSymlinkUtility.SetToolTip(this.btnSourcePath, "Click this to browse for a folder or file for the source path.");
            this.btnSourcePath.UseVisualStyleBackColor = false;
            this.btnSourcePath.Click += new System.EventHandler(this.btnSourcePath_Click);
            // 
            // ofdSymlinkUtility
            // 
            this.ofdSymlinkUtility.FileName = "ofdSymlinkUtility";
            // 
            // lblSourcePath
            // 
            this.lblSourcePath.Location = new System.Drawing.Point(11, 162);
            this.lblSourcePath.Name = "lblSourcePath";
            this.lblSourcePath.Size = new System.Drawing.Size(158, 20);
            this.lblSourcePath.TabIndex = 2;
            this.lblSourcePath.Text = "Source Folder Path:";
            // 
            // radSourceTypeFolder
            // 
            this.radSourceTypeFolder.Checked = true;
            this.radSourceTypeFolder.Location = new System.Drawing.Point(12, 25);
            this.radSourceTypeFolder.Name = "radSourceTypeFolder";
            this.radSourceTypeFolder.Size = new System.Drawing.Size(73, 31);
            this.radSourceTypeFolder.TabIndex = 0;
            this.radSourceTypeFolder.TabStop = true;
            this.radSourceTypeFolder.Text = "F&older";
            this.ttpSymlinkUtility.SetToolTip(this.radSourceTypeFolder, "Set the symlink type to folder based on the source path.");
            this.radSourceTypeFolder.UseVisualStyleBackColor = true;
            this.radSourceTypeFolder.CheckedChanged += new System.EventHandler(this.radSourceTypeFolder_CheckedChanged);
            // 
            // radSourceTypeFile
            // 
            this.radSourceTypeFile.Location = new System.Drawing.Point(91, 25);
            this.radSourceTypeFile.Name = "radSourceTypeFile";
            this.radSourceTypeFile.Size = new System.Drawing.Size(52, 31);
            this.radSourceTypeFile.TabIndex = 1;
            this.radSourceTypeFile.Text = "F&ile";
            this.ttpSymlinkUtility.SetToolTip(this.radSourceTypeFile, "Set the symlink type to file based on the source path.");
            this.radSourceTypeFile.UseVisualStyleBackColor = true;
            this.radSourceTypeFile.CheckedChanged += new System.EventHandler(this.radSourceTypeFile_CheckedChanged);
            // 
            // lblNewLinkLocation
            // 
            this.lblNewLinkLocation.Location = new System.Drawing.Point(11, 227);
            this.lblNewLinkLocation.Name = "lblNewLinkLocation";
            this.lblNewLinkLocation.Size = new System.Drawing.Size(147, 20);
            this.lblNewLinkLocation.TabIndex = 8;
            this.lblNewLinkLocation.Text = "New Link Location:";
            // 
            // btnNewLinkLocation
            // 
            this.btnNewLinkLocation.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnNewLinkLocation.Location = new System.Drawing.Point(274, 250);
            this.btnNewLinkLocation.Name = "btnNewLinkLocation";
            this.btnNewLinkLocation.Size = new System.Drawing.Size(30, 26);
            this.btnNewLinkLocation.TabIndex = 3;
            this.btnNewLinkLocation.Text = "...";
            this.ttpSymlinkUtility.SetToolTip(this.btnNewLinkLocation, "Click this to browse for a folder for the new link location.");
            this.btnNewLinkLocation.UseVisualStyleBackColor = false;
            this.btnNewLinkLocation.Click += new System.EventHandler(this.btnNewLinkLocation_Click);
            // 
            // txtNewLinkLocation
            // 
            this.txtNewLinkLocation.Location = new System.Drawing.Point(15, 250);
            this.txtNewLinkLocation.Name = "txtNewLinkLocation";
            this.txtNewLinkLocation.Size = new System.Drawing.Size(253, 26);
            this.txtNewLinkLocation.TabIndex = 2;
            this.ttpSymlinkUtility.SetToolTip(this.txtNewLinkLocation, "Input the location of the folder that the new link will created in here.");
            this.txtNewLinkLocation.TextChanged += new System.EventHandler(this.txtNewLinkLocation_TextChanged);
            // 
            // btnCreateLink
            // 
            this.btnCreateLink.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnCreateLink.Enabled = false;
            this.btnCreateLink.Location = new System.Drawing.Point(145, 350);
            this.btnCreateLink.Name = "btnCreateLink";
            this.btnCreateLink.Size = new System.Drawing.Size(159, 42);
            this.btnCreateLink.TabIndex = 5;
            this.btnCreateLink.Text = "&Create Link";
            this.ttpSymlinkUtility.SetToolTip(this.btnCreateLink, "Create a new link based on the user input in the form.");
            this.btnCreateLink.UseVisualStyleBackColor = false;
            this.btnCreateLink.Click += new System.EventHandler(this.btnCreateLink_Click);
            // 
            // errSymlinkUtility
            // 
            this.errSymlinkUtility.ContainerControl = this;
            // 
            // lblNewLinkName
            // 
            this.lblNewLinkName.Location = new System.Drawing.Point(11, 287);
            this.lblNewLinkName.Name = "lblNewLinkName";
            this.lblNewLinkName.Size = new System.Drawing.Size(178, 20);
            this.lblNewLinkName.TabIndex = 11;
            this.lblNewLinkName.Text = "New Link Folder Name:";
            // 
            // txtNewLinkName
            // 
            this.txtNewLinkName.Location = new System.Drawing.Point(15, 310);
            this.txtNewLinkName.MaxLength = 260;
            this.txtNewLinkName.Name = "txtNewLinkName";
            this.txtNewLinkName.Size = new System.Drawing.Size(289, 26);
            this.txtNewLinkName.TabIndex = 4;
            this.ttpSymlinkUtility.SetToolTip(this.txtNewLinkName, "Input the folder or file name for the new link.");
            this.txtNewLinkName.TextChanged += new System.EventHandler(this.txtNewLinkName_TextChanged);
            this.txtNewLinkName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNewLinkName_KeyPress);
            // 
            // grpSourceType
            // 
            this.grpSourceType.Controls.Add(this.radSourceTypeFolder);
            this.grpSourceType.Controls.Add(this.radSourceTypeFile);
            this.grpSourceType.Location = new System.Drawing.Point(15, 89);
            this.grpSourceType.Name = "grpSourceType";
            this.grpSourceType.Size = new System.Drawing.Size(292, 62);
            this.grpSourceType.TabIndex = 6;
            this.grpSourceType.TabStop = false;
            this.grpSourceType.Text = "Source Type";
            // 
            // mnuSymlinkUtility
            // 
            this.mnuSymlinkUtility.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuSourceType,
            this.mnuHelp});
            this.mnuSymlinkUtility.Location = new System.Drawing.Point(0, 0);
            this.mnuSymlinkUtility.Name = "mnuSymlinkUtility";
            this.mnuSymlinkUtility.Size = new System.Drawing.Size(323, 24);
            this.mnuSymlinkUtility.TabIndex = 8;
            this.mnuSymlinkUtility.Text = "mnuSymlinkUtility";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileCreateLink,
            this.mnuFileClear,
            this.mnuFileSep1,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileCreateLink
            // 
            this.mnuFileCreateLink.Enabled = false;
            this.mnuFileCreateLink.Name = "mnuFileCreateLink";
            this.mnuFileCreateLink.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuFileCreateLink.Size = new System.Drawing.Size(176, 22);
            this.mnuFileCreateLink.Text = "&Create Link";
            this.mnuFileCreateLink.ToolTipText = "Create a new link based on the user input in the form.";
            this.mnuFileCreateLink.Click += new System.EventHandler(this.mnuFileCreateLink_Click);
            // 
            // mnuFileClear
            // 
            this.mnuFileClear.Name = "mnuFileClear";
            this.mnuFileClear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mnuFileClear.Size = new System.Drawing.Size(176, 22);
            this.mnuFileClear.Text = "C&lear";
            this.mnuFileClear.ToolTipText = "Clear user input from the form.";
            this.mnuFileClear.Click += new System.EventHandler(this.mnuFileClear_Click);
            // 
            // mnuFileSep1
            // 
            this.mnuFileSep1.Name = "mnuFileSep1";
            this.mnuFileSep1.Size = new System.Drawing.Size(173, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.mnuFileExit.Size = new System.Drawing.Size(176, 22);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.ToolTipText = "Close the program.";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // mnuSourceType
            // 
            this.mnuSourceType.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSourceTypeFolder,
            this.mnuSourceTypeFile});
            this.mnuSourceType.Name = "mnuSourceType";
            this.mnuSourceType.Size = new System.Drawing.Size(84, 20);
            this.mnuSourceType.Text = "&Source Type";
            // 
            // mnuSourceTypeFolder
            // 
            this.mnuSourceTypeFolder.Checked = true;
            this.mnuSourceTypeFolder.CheckOnClick = true;
            this.mnuSourceTypeFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuSourceTypeFolder.Enabled = false;
            this.mnuSourceTypeFolder.Name = "mnuSourceTypeFolder";
            this.mnuSourceTypeFolder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuSourceTypeFolder.Size = new System.Drawing.Size(150, 22);
            this.mnuSourceTypeFolder.Text = "F&older";
            this.mnuSourceTypeFolder.ToolTipText = "Set the symlink type to folder based on the source path.";
            this.mnuSourceTypeFolder.CheckedChanged += new System.EventHandler(this.mnuSourceTypeFolder_CheckedChanged);
            // 
            // mnuSourceTypeFile
            // 
            this.mnuSourceTypeFile.CheckOnClick = true;
            this.mnuSourceTypeFile.Name = "mnuSourceTypeFile";
            this.mnuSourceTypeFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.mnuSourceTypeFile.Size = new System.Drawing.Size(150, 22);
            this.mnuSourceTypeFile.Text = "F&ile";
            this.mnuSourceTypeFile.ToolTipText = "Set the symlink type to file based on the source path.";
            this.mnuSourceTypeFile.CheckedChanged += new System.EventHandler(this.mnuSourceTypeFile_CheckedChanged);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.mnuHelpAbout.Size = new System.Drawing.Size(145, 22);
            this.mnuHelpAbout.Text = "&About";
            this.mnuHelpAbout.ToolTipText = "Find out more about Symlink Utility.";
            this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(15, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 42);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.ttpSymlinkUtility.SetToolTip(this.btnExit, "Close the program.");
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSymlinkUtility
            // 
            this.lblSymlinkUtility.Font = new System.Drawing.Font("Lucida Sans", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSymlinkUtility.Location = new System.Drawing.Point(37, 34);
            this.lblSymlinkUtility.Name = "lblSymlinkUtility";
            this.lblSymlinkUtility.Size = new System.Drawing.Size(278, 44);
            this.lblSymlinkUtility.TabIndex = 15;
            this.lblSymlinkUtility.Text = "Symlink Utility";
            this.lblSymlinkUtility.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(12, 34);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(53, 44);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 16;
            this.picLogo.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(71, 350);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 42);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "C&lear";
            this.ttpSymlinkUtility.SetToolTip(this.btnClear, "Clear user input from the form.");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SymlinkUtility
            // 
            this.AcceptButton = this.btnCreateLink;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(323, 405);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblSymlinkUtility);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpSourceType);
            this.Controls.Add(this.lblNewLinkName);
            this.Controls.Add(this.txtNewLinkName);
            this.Controls.Add(this.btnCreateLink);
            this.Controls.Add(this.lblNewLinkLocation);
            this.Controls.Add(this.btnNewLinkLocation);
            this.Controls.Add(this.txtNewLinkLocation);
            this.Controls.Add(this.lblSourcePath);
            this.Controls.Add(this.btnSourcePath);
            this.Controls.Add(this.txtSourcePath);
            this.Controls.Add(this.mnuSymlinkUtility);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuSymlinkUtility;
            this.MaximizeBox = false;
            this.Name = "SymlinkUtility";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Symlink Utility";
            this.Load += new System.EventHandler(this.frmSymlinkUtility_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errSymlinkUtility)).EndInit();
            this.grpSourceType.ResumeLayout(false);
            this.mnuSymlinkUtility.ResumeLayout(false);
            this.mnuSymlinkUtility.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.Button btnSourcePath;
        private System.Windows.Forms.OpenFileDialog ofdSymlinkUtility;
        private System.Windows.Forms.Label lblSourcePath;
        private System.Windows.Forms.FolderBrowserDialog fbdSymlinkUtility;
        private System.Windows.Forms.RadioButton radSourceTypeFolder;
        private System.Windows.Forms.RadioButton radSourceTypeFile;
        private System.Windows.Forms.Label lblNewLinkLocation;
        private System.Windows.Forms.Button btnNewLinkLocation;
        private System.Windows.Forms.TextBox txtNewLinkLocation;
        private System.Windows.Forms.Button btnCreateLink;
        private System.Windows.Forms.ErrorProvider errSymlinkUtility;
        private System.Windows.Forms.Label lblNewLinkName;
        private System.Windows.Forms.TextBox txtNewLinkName;
        private System.Windows.Forms.GroupBox grpSourceType;
        private System.Windows.Forms.MenuStrip mnuSymlinkUtility;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem mnuFileCreateLink;
        private System.Windows.Forms.ToolStripSeparator mnuFileSep1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuSourceType;
        private System.Windows.Forms.ToolStripMenuItem mnuSourceTypeFolder;
        private System.Windows.Forms.ToolStripMenuItem mnuSourceTypeFile;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
        private System.Windows.Forms.Label lblSymlinkUtility;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClear;
        private System.Windows.Forms.ToolTip ttpSymlinkUtility;
    }
}

