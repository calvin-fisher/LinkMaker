using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LinkMaker.UI
{
    public partial class Error : Form
    {
        public Error(Exception ex)
        {
            InitializeComponent();

            ErrorMessageLabel.Text = ex.Message;

            DetailsButton.Click += (o, e) => ShowDetails(ex.ToString());
        }

        private void ShowDetails(string details)
        {
            MessageBox.Show(this, details, "Exception Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
