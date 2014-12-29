namespace SymlinkUtility
{
    partial class SymlinkCreated
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
            if(disposing && (components != null))
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
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnOpenNewLinkLocation = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // picInfo
            // 
            this.picInfo.Location = new System.Drawing.Point(12, 12);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(30, 30);
            this.picInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInfo.TabIndex = 0;
            this.picInfo.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(48, 12);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(158, 46);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "The symlink was successfully created.";
            // 
            // btnOpenNewLinkLocation
            // 
            this.btnOpenNewLinkLocation.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnOpenNewLinkLocation.Location = new System.Drawing.Point(12, 61);
            this.btnOpenNewLinkLocation.Name = "btnOpenNewLinkLocation";
            this.btnOpenNewLinkLocation.Size = new System.Drawing.Size(121, 54);
            this.btnOpenNewLinkLocation.TabIndex = 2;
            this.btnOpenNewLinkLocation.Text = "Open New\r\n&Link Location";
            this.btnOpenNewLinkLocation.UseVisualStyleBackColor = false;
            this.btnOpenNewLinkLocation.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnOK.Location = new System.Drawing.Point(139, 61);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(67, 54);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // SymlinkCreated
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(222, 127);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnOpenNewLinkLocation);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.picInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SymlinkCreated";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Symlink Successfully Created";
            this.Load += new System.EventHandler(this.frmSymlinkCreated_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnOpenNewLinkLocation;
        private System.Windows.Forms.Button btnOK;
    }
}