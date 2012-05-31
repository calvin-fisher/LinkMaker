using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using LinkMaker.XML;

namespace LinkMaker.UI
{
    public partial class Main : Form
    {
        protected XML.LinkPackage _linkPackage;

        public const string TimestampFormatString = "HH:mm:ss.ffFFFFF";

        public Main()
        {
            InitializeComponent();
        }

        protected bool OpenFileDialogFor(TextBox textBox)
        {
            var applicationPath = System.Reflection.Assembly.GetAssembly(typeof(Main)).Location;
            var dialog = new OpenFileDialog
            {
                AddExtension = true,
                AutoUpgradeEnabled = true,
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = ".links.xml",
                Filter = "XML Link Files|*.links.xml|All Files|*.*",
                InitialDirectory = System.IO.Path.GetDirectoryName(applicationPath),
            };
            var result = dialog.ShowDialog(this);
            if (result != DialogResult.OK)
                return false;

            textBox.Text = dialog.FileName;
            return true;
        }

        protected void LoadLinkPackage()
        {
            try
            {
                Debug.WriteLine(DateTime.Now.ToString(TimestampFormatString) + " -- Starting link package load");

                // Load XML
                var selection = PackageFileTextBox.Text;
                var linkPackage = XML.LinkPackage.LoadFromFile(
                    selection,
                    s => MessageBox.Show(this, s, "Error Loading Link Package", MessageBoxButtons.OK, MessageBoxIcon.Error));
                
                if (linkPackage == null)
                    return;

                _linkPackage = linkPackage;

                // Prompt for variables
                VariablesDataGridView.DataSource = _linkPackage.Variables;

                // Show predicted links
                LinksDataGridView.DataSource = _linkPackage.Links;

                Debug.WriteLine(DateTime.Now.ToString(TimestampFormatString) + " -- Finished link package load");
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception in PackageFileChooseButton_Click");
                Error(ex);
            }
        }

        private void ClearLinkPackage()
        {
            _linkPackage = null;
            VariablesDataGridView.DataSource = null;
            LinksDataGridView.DataSource = null;
        }

        protected void Error(Exception ex)
        {
            try
            {
                var stackTrace = new StackTrace();
                var callFrame = stackTrace.GetFrame(stackTrace.FrameCount - 2);
                Debug.WriteLine(string.Format("Exception in {0}", callFrame.GetMethod()));
            }
            catch {}

            Debug.WriteLine(ex.ToString());

            var errorDialog = new Error(ex);
            if (this.InvokeRequired)
                this.Invoke(new Action(() => errorDialog.ShowDialog(this)));
            else
                errorDialog.ShowDialog(this);
        }

        private void PackageFileChooseButton_Click(object sender, EventArgs e)
        {
            var result = OpenFileDialogFor(PackageFileTextBox);
            if (result)
                LoadLinkPackage();
            else
                ClearLinkPackage();
        }

        private void TargetChooseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialogFor(TargetTextBox);
        }

        private void JunctionChooseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialogFor(LinkTextBox);
        }

        private void SingleLinkMakeLinkButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TargetTextBox.Text))
                {
                    MessageBox.Show(this, "No target selected.", "Could Not Create Link", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (string.IsNullOrEmpty(LinkTextBox.Text))
                {
                    MessageBox.Show(this, "No link location selected.", "Could Not Create Link", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (!File.Exists(TargetTextBox.Text))
                {
                    MessageBox.Show(this, "Target does not exist", "Could Not Create Link", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Files.MakeLink(LinkTextBox.Text, TargetTextBox.Text);

                MessageBox.Show(this, "Link created successfully!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Error(ex);
            }
        }

        private void PackageFileMakeLinksButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_linkPackage == null)
                {
                    MessageBox.Show(this, "Select a link package file to implement.", "No File Selected",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate that targets exist
                foreach (var looseLink in _linkPackage.Links.Where(x => !x.TargetPath.Exists))
                {
                    var warningMessage = string.Format(
                        "The path {0} does not exist. Attempt to create a {1} will likely fail.",
                        looseLink.TargetPath,
                        looseLink.LinkType);
                    var keepGoing = MessageBox.Show(this, warningMessage, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (keepGoing == DialogResult.Cancel)
                        return;
                }

                _linkPackage.Implement();

                MessageBox.Show(this, "All links created successfully!", "Links Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exceptions.VariableNotFoundException ex)
            {
                this.Invoke(new Action(() => Error(ex)));
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() => Error(ex)));
            }
        }

        private void VariablesDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            LinksDataGridView.Refresh();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PackageFileTextBox.Text))
                return;

            LoadLinkPackage();
        }

        private void LinksDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Error(e.Exception);
        }

    }
}
