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
    public partial class VariablePrompt : Form
    {
        private XML.Variable _variable;

        public string Value
        {
             get { return _variable.Value; }   
        }

        public VariablePrompt(XML.Variable variable, Action<string> onClose = null)
        {
            if (variable == null)
                throw new ArgumentException("Cannot prompt for null XML Variable.");

            if (variable.Name == null)
                throw new ArgumentException("Cannot prompt for XML Variable without name.");

            InitializeComponent();

            _variable = variable;

            NameTextBox.Text = _variable.Name;
            if (_variable.DefaultValue != null)
                ValueTextBox.Text = _variable.DefaultValue;

            if (onClose != null)
                this.FormClosing += (s,e) => onClose(_variable.Value);

            this.AcceptButton = OkButton;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            _variable.Value = ValueTextBox.Text;

            this.Close();
        }
    }
}
