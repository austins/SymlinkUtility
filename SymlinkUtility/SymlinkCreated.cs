using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SymlinkUtility
{
    public partial class SymlinkCreated : Form
    {
        // Declare class-wide variables for this class.
        private readonly string _strNewLinkLocation;
        private readonly string _strNewLinkName;
        /**
         * Assign variables to the strings passed in.
         */

        public SymlinkCreated(string strNewLinkLocationPassed,
            string strNewLinkNamePassed)
        {
            InitializeComponent();

            _strNewLinkLocation = strNewLinkLocationPassed;
            _strNewLinkName = strNewLinkNamePassed;
        }

        /*
         * Show information icon in the picture box on load.
         */

        private void frmSymlinkCreated_Load(object sender, EventArgs e)
        {
            picInfo.Image = SystemIcons.Information.ToBitmap();
        }

        /*
         * Close this form.
         */

        private void btnOK_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        /*
         * Open the folder of the new link location and close this form.
         */

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start(_strNewLinkLocation, " /select, "
                                               + _strNewLinkName);

            Dispose();
        }
    }
}