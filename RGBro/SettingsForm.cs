using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGBro
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            textBoxPort.Text = RGBro.Properties.Settings.Default.port;
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBoxPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            RGBro.Properties.Settings.Default.port = textBoxPort.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
