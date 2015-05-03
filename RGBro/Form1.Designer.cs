namespace ControlLED
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorListItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxColorPreview = new System.Windows.Forms.PictureBox();
            this.radioButtonSingle = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCrossfade = new System.Windows.Forms.RadioButton();
            this.buttonApply = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonColorPicker = new System.Windows.Forms.Button();
            this.textBoxHex = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxRed = new System.Windows.Forms.TextBox();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.textBoxGreen = new System.Windows.Forms.TextBox();
            this.textBoxBlue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxCrossfade = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCrossfadeLength = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCrossfadeDelay = new System.Windows.Forms.TextBox();
            this.listBoxCrossfade = new System.Windows.Forms.ListBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelPort = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonSettings = new System.Windows.Forms.ToolStripButton();
            this.backgroundWorkerConnect = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.colorListItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorPreview)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.groupBoxCrossfade.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorListItemBindingSource
            // 
            this.colorListItemBindingSource.DataSource = typeof(ControlLED.ColorListItem);
            // 
            // pictureBoxColorPreview
            // 
            this.pictureBoxColorPreview.Location = new System.Drawing.Point(12, 219);
            this.pictureBoxColorPreview.Name = "pictureBoxColorPreview";
            this.pictureBoxColorPreview.Size = new System.Drawing.Size(188, 50);
            this.pictureBoxColorPreview.TabIndex = 19;
            this.pictureBoxColorPreview.TabStop = false;
            // 
            // radioButtonSingle
            // 
            this.radioButtonSingle.AutoSize = true;
            this.radioButtonSingle.Checked = true;
            this.radioButtonSingle.Location = new System.Drawing.Point(6, 35);
            this.radioButtonSingle.Name = "radioButtonSingle";
            this.radioButtonSingle.Size = new System.Drawing.Size(81, 17);
            this.radioButtonSingle.TabIndex = 20;
            this.radioButtonSingle.TabStop = true;
            this.radioButtonSingle.Text = "Single Color";
            this.radioButtonSingle.UseVisualStyleBackColor = true;
            this.radioButtonSingle.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCrossfade);
            this.groupBox1.Controls.Add(this.radioButtonSingle);
            this.groupBox1.Location = new System.Drawing.Point(12, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 85);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LED Mode";
            // 
            // radioButtonCrossfade
            // 
            this.radioButtonCrossfade.AutoSize = true;
            this.radioButtonCrossfade.Location = new System.Drawing.Point(6, 58);
            this.radioButtonCrossfade.Name = "radioButtonCrossfade";
            this.radioButtonCrossfade.Size = new System.Drawing.Size(72, 17);
            this.radioButtonCrossfade.TabIndex = 21;
            this.radioButtonCrossfade.Text = "Crossfade";
            this.radioButtonCrossfade.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(12, 367);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(80, 23);
            this.buttonApply.TabIndex = 22;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonColorPicker);
            this.groupBox2.Controls.Add(this.textBoxHex);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxRed);
            this.groupBox2.Controls.Add(this.trackBarRed);
            this.groupBox2.Controls.Add(this.trackBarGreen);
            this.groupBox2.Controls.Add(this.trackBarBlue);
            this.groupBox2.Controls.Add(this.textBoxGreen);
            this.groupBox2.Controls.Add(this.textBoxBlue);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 187);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // buttonColorPicker
            // 
            this.buttonColorPicker.Location = new System.Drawing.Point(10, 161);
            this.buttonColorPicker.Name = "buttonColorPicker";
            this.buttonColorPicker.Size = new System.Drawing.Size(75, 23);
            this.buttonColorPicker.TabIndex = 21;
            this.buttonColorPicker.Text = "Color Picker";
            this.buttonColorPicker.UseVisualStyleBackColor = true;
            this.buttonColorPicker.Click += new System.EventHandler(this.buttonColorPicker_Click_1);
            // 
            // textBoxHex
            // 
            this.textBoxHex.Location = new System.Drawing.Point(117, 160);
            this.textBoxHex.Name = "textBoxHex";
            this.textBoxHex.Size = new System.Drawing.Size(59, 20);
            this.textBoxHex.TabIndex = 20;
            this.textBoxHex.Text = "000000";
            this.textBoxHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxHex.TextChanged += new System.EventHandler(this.textBoxHex_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "#";
            // 
            // textBoxRed
            // 
            this.textBoxRed.Location = new System.Drawing.Point(137, 27);
            this.textBoxRed.Name = "textBoxRed";
            this.textBoxRed.Size = new System.Drawing.Size(38, 20);
            this.textBoxRed.TabIndex = 13;
            this.textBoxRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxRed.TextChanged += new System.EventHandler(this.textBoxRed_TextChanged);
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(28, 27);
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(104, 45);
            this.trackBarRed.TabIndex = 10;
            this.trackBarRed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(27, 71);
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(104, 45);
            this.trackBarGreen.TabIndex = 11;
            this.trackBarGreen.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(28, 115);
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(104, 45);
            this.trackBarBlue.TabIndex = 12;
            this.trackBarBlue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // textBoxGreen
            // 
            this.textBoxGreen.Location = new System.Drawing.Point(137, 71);
            this.textBoxGreen.Name = "textBoxGreen";
            this.textBoxGreen.Size = new System.Drawing.Size(37, 20);
            this.textBoxGreen.TabIndex = 14;
            this.textBoxGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxGreen.TextChanged += new System.EventHandler(this.textBoxGreen_TextChanged);
            // 
            // textBoxBlue
            // 
            this.textBoxBlue.Location = new System.Drawing.Point(136, 116);
            this.textBoxBlue.Name = "textBoxBlue";
            this.textBoxBlue.Size = new System.Drawing.Size(38, 20);
            this.textBoxBlue.TabIndex = 15;
            this.textBoxBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxBlue.TextChanged += new System.EventHandler(this.textBoxBlue_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "R";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "G";
            // 
            // groupBoxCrossfade
            // 
            this.groupBoxCrossfade.Controls.Add(this.label6);
            this.groupBoxCrossfade.Controls.Add(this.textBoxCrossfadeLength);
            this.groupBoxCrossfade.Controls.Add(this.label5);
            this.groupBoxCrossfade.Controls.Add(this.textBoxCrossfadeDelay);
            this.groupBoxCrossfade.Controls.Add(this.listBoxCrossfade);
            this.groupBoxCrossfade.Controls.Add(this.buttonRemove);
            this.groupBoxCrossfade.Controls.Add(this.buttonAdd);
            this.groupBoxCrossfade.Location = new System.Drawing.Point(216, 26);
            this.groupBoxCrossfade.Name = "groupBoxCrossfade";
            this.groupBoxCrossfade.Size = new System.Drawing.Size(202, 277);
            this.groupBoxCrossfade.TabIndex = 29;
            this.groupBoxCrossfade.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Crossfade length";
            this.label6.Visible = false;
            // 
            // textBoxCrossfadeLength
            // 
            this.textBoxCrossfadeLength.Location = new System.Drawing.Point(101, 221);
            this.textBoxCrossfadeLength.Name = "textBoxCrossfadeLength";
            this.textBoxCrossfadeLength.Size = new System.Drawing.Size(89, 20);
            this.textBoxCrossfadeLength.TabIndex = 38;
            this.textBoxCrossfadeLength.Text = "0";
            this.textBoxCrossfadeLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCrossfadeLength.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Crossfade delay";
            // 
            // textBoxCrossfadeDelay
            // 
            this.textBoxCrossfadeDelay.Location = new System.Drawing.Point(101, 247);
            this.textBoxCrossfadeDelay.Name = "textBoxCrossfadeDelay";
            this.textBoxCrossfadeDelay.Size = new System.Drawing.Size(89, 20);
            this.textBoxCrossfadeDelay.TabIndex = 36;
            this.textBoxCrossfadeDelay.Text = "0";
            this.textBoxCrossfadeDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listBoxCrossfade
            // 
            this.listBoxCrossfade.DataSource = this.colorListItemBindingSource;
            this.listBoxCrossfade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxCrossfade.FormattingEnabled = true;
            this.listBoxCrossfade.Location = new System.Drawing.Point(101, 30);
            this.listBoxCrossfade.Name = "listBoxCrossfade";
            this.listBoxCrossfade.Size = new System.Drawing.Size(89, 173);
            this.listBoxCrossfade.TabIndex = 35;
            this.listBoxCrossfade.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxCrossfade_DrawItem);
            this.listBoxCrossfade.SelectedIndexChanged += new System.EventHandler(this.listBoxCrossfade_SelectedIndexChanged_2);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(6, 59);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(89, 23);
            this.buttonRemove.TabIndex = 34;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(6, 30);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(89, 23);
            this.buttonAdd.TabIndex = 33;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelPort
            // 
            this.labelPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(348, 377);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(70, 13);
            this.labelPort.TabIndex = 30;
            this.labelPort.Text = "Connecting...";
            this.labelPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelPort.Click += new System.EventHandler(this.toolStripButtonSettings_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSettings});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(426, 25);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButtonSettings
            // 
            this.toolStripButtonSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSettings.Image")));
            this.toolStripButtonSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSettings.Name = "toolStripButtonSettings";
            this.toolStripButtonSettings.Size = new System.Drawing.Size(53, 22);
            this.toolStripButtonSettings.Text = "Settings";
            this.toolStripButtonSettings.Click += new System.EventHandler(this.toolStripButtonSettings_Click);
            // 
            // backgroundWorkerConnect
            // 
            this.backgroundWorkerConnect.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerConnect_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(426, 398);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.groupBoxCrossfade);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxColorPreview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RGBro";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.colorListItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorPreview)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.groupBoxCrossfade.ResumeLayout(false);
            this.groupBoxCrossfade.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.BindingSource colorListItemBindingSource;
        private System.Windows.Forms.PictureBox pictureBoxColorPreview;
        private System.Windows.Forms.RadioButton radioButtonSingle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCrossfade;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxRed;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.TextBox textBoxGreen;
        private System.Windows.Forms.TextBox textBoxBlue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxCrossfade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCrossfadeLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCrossfadeDelay;
        private System.Windows.Forms.ListBox listBoxCrossfade;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonColorPicker;
        private System.Windows.Forms.TextBox textBoxHex;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerConnect;
        private System.Windows.Forms.ToolStripButton toolStripButtonSettings;

    }
}

