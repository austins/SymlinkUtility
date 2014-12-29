/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * Symlink Utility
 * Created by Austin S.
 * Date Created: 01/14/2014
 * Date Finished: v1.0.0.0 - 01/16/2014
 * Date Updated: 01/18/2014
 * Project Name: SymlinkUtility
 * Time: 6 hours 30 minutes
 * Platform: PC, Windows 7, C# 2012
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * This program lets the user create NTFS symbolic links.
 * 
 * A symbolic link is a special type of file that contains
 * a reference to another file or folder.
 * 
 * A symbolic link is similar to a shortcut, but it behaves like
 * a real file or folder with its own absolute paths.
 * 
 * Required input for creating a link:
 * 1. Source path.
 * 2. New link location.
 * 3. New link name.
 * 
 * Output: Symbolic link for a file or folder.
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
 * Comments by the developer:
 * 
 * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SymlinkUtility
{
    public partial class SymlinkUtility : Form
    {
        public SymlinkUtility()
        {
            InitializeComponent();
        }

        /**
         * Validate version of OS.
         * MKLINK executable is only available in Windows Vista and newer.
         */

        private void frmSymlinkUtility_Load(object sender, EventArgs e)
        {
            var os = Environment.OSVersion;

            // If OS version is older than Windows Vista.
            if ((os.Platform != PlatformID.Win32NT) || (os.Version.Major < 6))
            {
                MessageBox.Show("Windows Vista or newer is required to run"
                                + " this program.", "Operating System Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Application.Exit(); // Terminate the application.
            }
        }

        /**
         * Clear the user input for text boxes.
         */

        private void ClearPathTextBoxes()
        {
            btnCreateLink.Enabled = false;
            mnuFileCreateLink.Enabled = false;
            errSymlinkUtility.Clear();
            txtSourcePath.Clear();
            txtNewLinkLocation.Clear();
            txtNewLinkName.Clear();
            txtSourcePath.Focus(); // set focus to the source path text box.
        }

        /**
         * Synchronize the radio buttons with the menu buttons
         * and clear text box input.
         */

        private void radSourceTypeFolder_CheckedChanged(object sender,
            EventArgs e)
        {
            if (radSourceTypeFolder.Checked)
            {
                mnuSourceTypeFile.Enabled = true;
                mnuSourceTypeFolder.Checked = true;
                lblSourcePath.Text = "Source Folder Path:";
                lblNewLinkName.Text = "New Link Folder Name:";
            }
            else
            {
                mnuSourceTypeFile.Enabled = false;
                mnuSourceTypeFolder.Checked = false;
            }

            ClearPathTextBoxes(); // Reset validation for the text boxes.
        }

        /**
         * Synchronize the radio buttons with the menu buttons
         * and clear text box input.
         */

        private void radSourceTypeFile_CheckedChanged(object sender,
            EventArgs e)
        {
            if (radSourceTypeFile.Checked)
            {
                mnuSourceTypeFolder.Enabled = true;
                mnuSourceTypeFile.Checked = true;
                lblSourcePath.Text = "Source File Path:";
                lblNewLinkName.Text = "New Link File Name:";
            }
            else
            {
                mnuSourceTypeFolder.Enabled = false;
                mnuSourceTypeFile.Checked = false;
            }

            ClearPathTextBoxes(); // Reset validation for the text boxes.
        }

        /**
         * Synchronize the menu buttons with the radio buttons
         * and clear text box input.
         */

        private void mnuSourceTypeFolder_CheckedChanged(object sender,
            EventArgs e)
        {
            if (mnuSourceTypeFolder.Checked)
            {
                mnuSourceTypeFile.Enabled = true;
                radSourceTypeFolder.Checked = true;
                lblSourcePath.Text = "Source Folder Path:";
                lblNewLinkName.Text = "New Link Folder Name:";
            }
            else
            {
                mnuSourceTypeFile.Enabled = false;
                radSourceTypeFolder.Checked = false;
            }

            ClearPathTextBoxes(); // Reset validation for the text boxes.
        }

        /**
         * Synchronize the menu buttons with the radio buttons
         * and clear text box input.
         */

        private void mnuSourceTypeFile_CheckedChanged(object sender,
            EventArgs e)
        {
            if (mnuSourceTypeFile.Checked)
            {
                mnuSourceTypeFolder.Enabled = true;
                radSourceTypeFile.Checked = true;
                lblSourcePath.Text = "Source File Path:";
                lblNewLinkName.Text = "New Link File Name:";
            }
            else
            {
                mnuSourceTypeFolder.Enabled = false;
                radSourceTypeFile.Checked = false;
            }

            ClearPathTextBoxes(); // Reset validation for the text boxes.
        }

        /**
         * Open the folder or file browser for the source path text box.
         */

        private void btnSourcePath_Click(object sender, EventArgs e)
        {
            if (radSourceTypeFolder.Checked)
            {
                // Open the folder browser dialog.
                if (fbdSymlinkUtility.ShowDialog() == DialogResult.OK)
                    txtSourcePath.Text = fbdSymlinkUtility.SelectedPath;
            }
            else
            {
                // Open the open file dialog.
                if (ofdSymlinkUtility.ShowDialog() == DialogResult.OK)
                    txtSourcePath.Text = ofdSymlinkUtility.FileName;
            }
        }

        /**
         * Open the folder browser for the new link location text box.
         */

        private void btnNewLinkLocation_Click(object sender, EventArgs e)
        {
            // Open the folder browser dialog.
            if (fbdSymlinkUtility.ShowDialog() == DialogResult.OK)
                txtNewLinkLocation.Text = fbdSymlinkUtility.SelectedPath;
        }

        /**
         * Sets a validation error for the text boxes.
         * 
         * @param TextBox txtPath
         * @param string strError
         */

        private void SetTextBoxError(TextBox txtPath, string strError)
        {
            const sbyte errorPadding = -20;

            // Show the icon inside of the text box.
            errSymlinkUtility.SetIconPadding(txtPath, errorPadding);

            // Set the error on the text box.
            errSymlinkUtility.SetError(txtPath, strError);
        }

        /**
         * Clear the error that has been set on a text box.
         * 
         * @param TextBox txtPath
         */

        private void ClearErrorFromTextBox(TextBox txtPath)
        {
            if ((errSymlinkUtility.GetError(txtPath) != ""))
                errSymlinkUtility.SetError(txtPath, "");
        }

        /**
         * Check if all the path text boxes are filled in.
         * If they are all filled in, then enable the "create link" button.
         */

        private void CheckIfAllPathTextBoxesAreFilledIn()
        {
            if ((txtSourcePath.Text != "") && (txtNewLinkLocation.Text != "")
                && (txtNewLinkName.Text != ""))
            {
                btnCreateLink.Enabled = true;
                mnuFileCreateLink.Enabled = true;
            }
            else
            {
                btnCreateLink.Enabled = false;
                mnuFileCreateLink.Enabled = false;
            }
        }

        /**
         * Clear the error if the text changes in the text box.
         */

        private void txtSourcePath_TextChanged(object sender, EventArgs e)
        {
            ClearErrorFromTextBox(txtSourcePath);
            CheckIfAllPathTextBoxesAreFilledIn();
        }

        /**
         * Clear the error if the text changes in the text box.
         */

        private void txtNewLinkLocation_TextChanged(object sender,
            EventArgs e)
        {
            ClearErrorFromTextBox(txtNewLinkLocation);
            CheckIfAllPathTextBoxesAreFilledIn();
        }

        /**
         * Clear the error if the text changes in the text box.
         */

        private void txtNewLinkName_TextChanged(object sender, EventArgs e)
        {
            ClearErrorFromTextBox(txtNewLinkName);
            CheckIfAllPathTextBoxesAreFilledIn();
        }

        /**
         * Create the symlink.
         * 
         * @throws Win32Exception if the user did not allow elevation.
         */

        private void btnCreateLink_Click(object sender, EventArgs e)
        {
            const string pathRequiredMessage = "A path is required in this"
                                               + " text box.";
            const string folderDoesNotExistMessage = "That folder does"
                                                     + " not exist.";
            const string fileDoesNotExistMessage = "That file does not"
                                                   + " exist.";
            const string linkNameRequiredMessage = "A link name is"
                                                   + " required in this text box.";
            var blnDoesSourcePathExist = false;
            var blnDoesNewLinkLocationExist = false;

            errSymlinkUtility.Clear(); // Reset validation for the text boxes.

            // Validate source path text box input.
            // Set an error if there is no text.
            if (txtSourcePath.Text == "")
            {
                SetTextBoxError(txtSourcePath, pathRequiredMessage);
            }
            else if (radSourceTypeFolder.Checked)
            {
                // Check if the folder exists.
                if (Directory.Exists(txtSourcePath.Text))
                    blnDoesSourcePathExist = true;
                else
                    SetTextBoxError(txtSourcePath,
                        folderDoesNotExistMessage);
            }
            else
            {
                // Check if the file exists.
                if (File.Exists(txtSourcePath.Text))
                    blnDoesSourcePathExist = true;
                else
                    SetTextBoxError(txtSourcePath,
                        fileDoesNotExistMessage);
            }

            // Validate new link location text box input.
            // Set an error if there is no text.
            if (txtNewLinkLocation.Text == "")
            {
                SetTextBoxError(txtNewLinkLocation, pathRequiredMessage);
            }
            else
            {
                // Check if the folder exists.
                if (Directory.Exists(txtNewLinkLocation.Text))
                    blnDoesNewLinkLocationExist = true;
                else
                    SetTextBoxError(txtNewLinkLocation,
                        fileDoesNotExistMessage);
            }

            // Validate new link name text box input.
            // Set an error if there is no text.
            if (txtNewLinkName.Text == "")
                SetTextBoxError(txtNewLinkName, linkNameRequiredMessage);

            // If all fields are valid, then proceed with making the symlink.
            if (blnDoesSourcePathExist && blnDoesNewLinkLocationExist
                && (txtNewLinkName.Text != ""))
            {
                var strLinkArguments = "";

                // If the user wants to make a folder link.
                if (radSourceTypeFolder.Checked)
                    strLinkArguments = "/D ";

                // Set up the link arguments string.
                strLinkArguments += "\"" + txtNewLinkLocation.Text
                                    + "\\" + txtNewLinkName.Text + "\" \""
                                    + txtSourcePath.Text + "\"";

                // Open a hidden command prompt that makes
                // use of the mklink executable.
                try
                {
                    var proc = new Process();
                    var procStartInfo = new ProcessStartInfo
                    {
                        CreateNoWindow = true, // Hide the command prompt.
                        WindowStyle = ProcessWindowStyle.Hidden,
                        UseShellExecute = true, // Required for elevation.
                        Verb = "runas", // Elevation is required for mklink.
                        FileName = "cmd.exe",
                        Arguments = "/C mklink " + strLinkArguments
                    };

                    proc.StartInfo = procStartInfo;

                    // Throws Win32Exception if user didn't allow elevation.
                    proc.Start();

                    // Open the successfully created symlink dialog.
                    var frmCreated = new SymlinkCreated(
                        txtNewLinkLocation.Text,
                        txtNewLinkName.Text);

                    frmCreated.ShowDialog();
                }
                catch (Win32Exception win32Exception)
                {
                    // The user did not allow elevation, so show a message.
                    MessageBox.Show("Administrator elevation is required to"
                                    + " create symlinks in Windows.", "Permission Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        /**
         * Validates the new link folder or file name.
         */

        private void txtNewLinkName_KeyPress(object sender,
            KeyPressEventArgs e)
        {
            // If the user wants to create a folder link.
            if (radSourceTypeFolder.Checked)
            {
                // Compare key input with Windows invalid characters list.
                foreach (var chrInvalid in Path.GetInvalidPathChars())
                {
                    if (((e.KeyChar == chrInvalid)
                         || (e.KeyChar == '.')) // Don't allow periods.
                        && (e.KeyChar != (char) Keys.Back)) // Allow backspace.
                        e.Handled = true;
                }
            }
            else
            {
                // Compare key input with Windows invalid characters list.
                foreach (var chrInvalid in Path.GetInvalidFileNameChars())
                {
                    if ((e.KeyChar == chrInvalid)
                        && (e.KeyChar != (char) Keys.Back)) // Allow backspace.
                        e.Handled = true;
                }
            }
        }

        /**
         * Close the application.
         */

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * Synchronize menu button with button on form.
         */

        private void mnuFileCreateLink_Click(object sender, EventArgs e)
        {
            btnCreateLink_Click(sender, e);
        }

        /**
         * Synchronize menu button with button on form.
         */

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            btnExit_Click(sender, e);
        }

        /**
         * Show the about form.
         */

        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            var frmAbout = new SymlinkAbout();
            frmAbout.ShowDialog();
        }

        /**
         * Clear the user input.
         */

        private void btnClear_Click(object sender, EventArgs e)
        {
            radSourceTypeFolder.PerformClick();
            ClearPathTextBoxes();
        }

        /**
         * Synchronize menu button with button on form.
         */

        private void mnuFileClear_Click(object sender, EventArgs e)
        {
            btnClear_Click(sender, e);
        }
    }
}