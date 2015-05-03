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

namespace ControlLED
{
    public partial class Form1 : Form
    {
        private ArduinoConnection arduinoConnection;
        private List<ColorListItem> crossfadeColors;
        private ColorListItem currentColorItem;

        public Form1()
        {
            InitializeComponent();

            arduinoConnection = new ArduinoConnection();
            crossfadeColors = new List<ColorListItem>();
            trackBarRed.SetRange(0,255);
            trackBarGreen.SetRange(0, 255);
            trackBarBlue.SetRange(0, 255);

            textBoxRed.DataBindings.Add("Text", trackBarRed, "Value");
            textBoxGreen.DataBindings.Add("Text", trackBarGreen, "Value");
            textBoxBlue.DataBindings.Add("Text", trackBarBlue, "Value");

            listBoxCrossfade.DisplayMember = "ItemColor";
            listBoxCrossfade.ValueMember = "HexColor";
            listBoxCrossfade.DataSource = crossfadeColors;

            radioButtonSingle.Checked = true;
            groupBoxCrossfade.Visible = false;
            currentColorItem = new ColorListItem(Color.FromArgb(255, trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value));
            textBoxHex.DataBindings.Add("Text", currentColorItem, "HexColor");

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBarRed_Scroll(object sender, EventArgs e)
        {
            currentColorItem.changeRed(trackBarRed.Value);
            textBoxHex.Text = currentColorItem.HexColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxBlue_TextChanged(object sender, EventArgs e)
        {

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
            BindData();
        }

        private void BindData()
        {
            listBoxCrossfade.DataSource = null;
            listBoxCrossfade.DisplayMember = "ItemColor";
            listBoxCrossfade.ValueMember = "HexColor";
            listBoxCrossfade.DataSource = crossfadeColors;
        }

        private void buttonApplyCrossfade_Click(object sender, EventArgs e)
        {
            
        }

        private void listBoxCrossfade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxCrossfade_DrawItem(object sender, DrawItemEventArgs e)
        {
            /*
            ColorListItem item = listBoxCrossfade.Items[e.Index] as ColorListItem; // Get the current item and cast it to MyListBoxItem
            if (item != null)
            {
                e.Graphics.DrawString( // Draw the appropriate text in the ListBox
                    item.HexColor, // The message linked to the item
                    listBoxCrossfade.Font, // Take the font from the listbox
                    new SolidBrush(item.ItemColor), // Set the color 
                    0, // X pixel coordinate
                    e.Index * listBoxCrossfade.ItemHeight // Y pixel coordinate.  Multiply the index by the ItemHeight defined in the listbox.
                );
            }
            else
            {
                // The item isn't a MyListBoxItem, do something about it
            }*/
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            crossfadeColors.RemoveAt(listBoxCrossfade.SelectedIndex);
            BindData();
        }

        private void textBoxGreen_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBarGreen_Scroll(object sender, EventArgs e)
        {
            currentColorItem.changeGreen(trackBarGreen.Value);
            textBoxHex.Text = currentColorItem.HexColor;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

       
        private void textBoxHex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("ABCDEF0123456789".IndexOf(e.KeyChar) == -1)
                e.Handled = true;
        }

        private void trackBarBlue_Scroll(object sender, EventArgs e)
        {
            currentColorItem.changeBlue(trackBarBlue.Value);
            textBoxHex.Text = currentColorItem.HexColor;
        }

        private void buttonColorPicker_Click(object sender, EventArgs e)
        {
            
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
            if (radioButtonSingle.Checked)
            {
                arduinoConnection.sendSingleColor(trackBarRed.Value, trackBarGreen.Value, trackBarBlue.Value);
            }
            else if (radioButtonCrossfade.Checked)
            {
                arduinoConnection.sendMultipleColors(crossfadeColors, Convert.ToInt32(textBoxCrossfadeDelay.Text));
            }
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {

        }

        private void listBoxCrossfade_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void buttonRemove_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click_2(object sender, EventArgs e)
        {

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
            }
        }

        private void listBoxCrossfade_SelectedIndexChanged_2(object sender, EventArgs e)
        {
        }

    }
}
