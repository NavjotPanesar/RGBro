using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using RGBro;

namespace ControlLED
{
    delegate void SetTextCallback(string text);
    public partial class Form1 : Form
    {
        private ArduinoConnection arduinoConnection;
        private List<ColorListItem> crossfadeColors;
        private ColorListItem currentColorItem = new ColorListItem(Color.FromArgb(255, 0, 0, 0));

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            arduinoConnection = new ArduinoConnection();
            crossfadeColors = new List<ColorListItem>();
            trackBarRed.SetRange(0, 255);
            trackBarGreen.SetRange(0, 255);
            trackBarBlue.SetRange(0, 255);

            BindColorControls();
            BindListData();

            radioButtonSingle.Checked = true;
            groupBoxCrossfade.Visible = false;
            
            textBoxHex.DataBindings.Add("Text", currentColorItem, "HexColor");

            if (!backgroundWorkerConnect.IsBusy)
            {
                backgroundWorkerConnect.RunWorkerAsync();
            }
        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            refreshHexText();
        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            refreshHexText();
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            refreshHexText();
        }

        private void color_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //struct, so pass by value
            Color newColor = currentColorItem.ItemColor; 
            crossfadeColors.Add(new ColorListItem(newColor));
            BindListData();
        }

        private void BindListData()
        {
            listBoxCrossfade.DataSource = null;
            listBoxCrossfade.DisplayMember = "ItemColor";
            listBoxCrossfade.ValueMember = "HexColor";
            listBoxCrossfade.DataSource = crossfadeColors;
        }

        private void BindColorControls()
        {
            textBoxRed.DataBindings.Clear();
            textBoxGreen.DataBindings.Clear();
            textBoxBlue.DataBindings.Clear();

            trackBarRed.DataBindings.Clear();
            trackBarGreen.DataBindings.Clear();
            trackBarBlue.DataBindings.Clear();

            textBoxRed.DataBindings.Add("Text", currentColorItem, "Red", false, DataSourceUpdateMode.OnPropertyChanged);
            textBoxGreen.DataBindings.Add("Text", currentColorItem, "Green", false, DataSourceUpdateMode.OnPropertyChanged);
            textBoxBlue.DataBindings.Add("Text", currentColorItem, "Blue", false, DataSourceUpdateMode.OnPropertyChanged);

            trackBarRed.DataBindings.Add("Value", currentColorItem, "Red", false, DataSourceUpdateMode.OnPropertyChanged);
            trackBarGreen.DataBindings.Add("Value", currentColorItem, "Green", false, DataSourceUpdateMode.OnPropertyChanged);
            trackBarBlue.DataBindings.Add("Value", currentColorItem, "Blue", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        
        private void listBoxCrossfade_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            bool isItemSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);
            int itemIndex = e.Index;
            if (itemIndex >= 0 && itemIndex < crossfadeColors.Count)
            {
                Graphics g = e.Graphics;

                Color backgroundColor = crossfadeColors[itemIndex].ItemColor;
                // Background Color
                SolidBrush backgroundColorBrush = new SolidBrush(backgroundColor); 
                g.FillRectangle(backgroundColorBrush, e.Bounds);

                // Set text color
                string itemText = crossfadeColors[itemIndex].HexColor;

                //awesome
                //http://stackoverflow.com/questions/3942878/how-to-decide-font-color-in-white-or-black-depending-on-background-color
                bool useBlack = (backgroundColor.R * 0.299 + backgroundColor.G * 0.587 + backgroundColor.B * 0.114) > 186;

                SolidBrush itemTextColorBrush;
                if (isItemSelected)
                {
                    itemTextColorBrush = (useBlack) ? new SolidBrush(Color.DarkGray) : new SolidBrush(Color.LightGray);
                }
                else
                {
                    itemTextColorBrush = (useBlack) ? new SolidBrush(Color.Black) : new SolidBrush(Color.White);
                }
                
                g.DrawString(itemText, e.Font, itemTextColorBrush, listBoxCrossfade.GetItemRectangle(itemIndex).Location);

                // Clean up
                backgroundColorBrush.Dispose();
                itemTextColorBrush.Dispose();
            }

            e.DrawFocusRectangle();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listBoxCrossfade.SelectedIndex != -1)
            {
                crossfadeColors.RemoveAt(listBoxCrossfade.SelectedIndex);
                BindListData();
            }
            
        }

      
        private void textBoxHex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("ABCDEF0123456789".IndexOf(e.KeyChar) == -1)
                e.Handled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCrossfade.Checked)
            {
                groupBoxCrossfade.Visible = true;
            }
            else
            {
                groupBoxCrossfade.Visible = false;
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if(arduinoConnection.Connect() == false)
            {
                MessageBox.Show("Error: not currently connected.");
            }
            if (radioButtonSingle.Checked)
            {
                arduinoConnection.sendSingleColor(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            }
            else if (radioButtonCrossfade.Checked)
            {
                arduinoConnection.sendMultipleColors(crossfadeColors, Convert.ToInt32(textBoxCrossfadeDelay.Text));
            }
        }

     
        private void buttonColorPicker_Click_1(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                trackBarRed.Value = colorDialog1.Color.R;
                trackBarGreen.Value = colorDialog1.Color.G;
                trackBarBlue.Value = colorDialog1.Color.B;
                textBoxHex.Text = trackBarRed.Value.ToString("X2") + trackBarGreen.Value.ToString("X2") + trackBarBlue.Value.ToString("X2"); 
            }
        }

        private void textBoxHex_TextChanged_1(object sender, EventArgs e)
        {
            if (textBoxHex.Text.Length == 6)
            {
                currentColorItem.ItemColor = System.Drawing.ColorTranslator.FromHtml("0x" + textBoxHex.Text);
                pictureBoxColorPreview.BackColor = currentColorItem.ItemColor;
                BindListData();
                refreshHexText();
                BindColorControls();
            }
        }

        private void listBoxCrossfade_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            
        }

        private void refreshHexText()
        {
            textBoxHex.Text = currentColorItem.HexColor;
        }


        private void backgroundWorkerConnect_DoWork(object sender, DoWorkEventArgs e)
        {
            SetConnectionText("Connecting...");
            bool success = arduinoConnection.Connect();
            if (success)
            {
                SetConnectionText(arduinoConnection.PortName);
            }
            else
            {
                SetConnectionText("Error");
            }
        }

        private void SetConnectionText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.labelPort.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetConnectionText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.labelPort.Text = text;
            }
        }

        private void toolStripLabelSettings_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                arduinoConnection.resetConnection();
                if (!backgroundWorkerConnect.IsBusy)
                {
                    backgroundWorkerConnect.RunWorkerAsync();
                }
            }
            
        }

        private void textBoxRed_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxGreen_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBoxBlue_TextChanged(object sender, EventArgs e)
        {
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


    }
}
