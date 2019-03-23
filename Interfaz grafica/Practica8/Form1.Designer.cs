namespace Practica8
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbButton1 = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.lbLed2 = new LBSoft.IndustrialCtrls.Leds.LBLed();
            this.lbLed3 = new LBSoft.IndustrialCtrls.Leds.LBLed();
            this.lbLed4 = new LBSoft.IndustrialCtrls.Leds.LBLed();
            this.lbLed5 = new LBSoft.IndustrialCtrls.Leds.LBLed();
            this.lbButton2 = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.lbButton3 = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.lbButton4 = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Flecha3_Arr = new System.Windows.Forms.PictureBox();
            this.Flecha1_D = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Flecha4_D = new System.Windows.Forms.PictureBox();
            this.Flecha1_I = new System.Windows.Forms.PictureBox();
            this.Flecha4_I = new System.Windows.Forms.PictureBox();
            this.Flecha2_Arr = new System.Windows.Forms.PictureBox();
            this.Flecha3_Abj = new System.Windows.Forms.PictureBox();
            this.Flecha2_Abj = new System.Windows.Forms.PictureBox();
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.lbButton5 = new LBSoft.IndustrialCtrls.Buttons.LBButton();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Flecha3_Arr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flecha1_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flecha4_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flecha1_I)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flecha4_I)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flecha2_Arr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flecha3_Abj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flecha2_Abj)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM37";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbButton1
            // 
            this.lbButton1.BackColor = System.Drawing.Color.Transparent;
            this.lbButton1.ButtonColor = System.Drawing.Color.Gray;
            this.lbButton1.Label = "";
            this.lbButton1.Location = new System.Drawing.Point(40, 149);
            this.lbButton1.Name = "lbButton1";
            this.lbButton1.Renderer = null;
            this.lbButton1.RepeatInterval = 100;
            this.lbButton1.RepeatState = false;
            this.lbButton1.Size = new System.Drawing.Size(50, 50);
            this.lbButton1.StartRepeatInterval = 500;
            this.lbButton1.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.lbButton1.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Circular;
            this.lbButton1.TabIndex = 0;
            this.lbButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbButton1_MouseClick);
            // 
            // lbLed2
            // 
            this.lbLed2.AutoSize = true;
            this.lbLed2.BackColor = System.Drawing.Color.White;
            this.lbLed2.BlinkInterval = 500;
            this.lbLed2.Label = "Ala este";
            this.lbLed2.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top;
            this.lbLed2.LedColor = System.Drawing.Color.Red;
            this.lbLed2.LedSize = new System.Drawing.SizeF(40F, 40F);
            this.lbLed2.Location = new System.Drawing.Point(435, 418);
            this.lbLed2.Name = "lbLed2";
            this.lbLed2.Renderer = null;
            this.lbLed2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbLed2.Size = new System.Drawing.Size(73, 76);
            this.lbLed2.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
            this.lbLed2.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular;
            this.lbLed2.TabIndex = 2;
            // 
            // lbLed3
            // 
            this.lbLed3.BackColor = System.Drawing.Color.White;
            this.lbLed3.BlinkInterval = 500;
            this.lbLed3.Label = "Ala norte";
            this.lbLed3.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top;
            this.lbLed3.LedColor = System.Drawing.Color.Red;
            this.lbLed3.LedSize = new System.Drawing.SizeF(40F, 40F);
            this.lbLed3.Location = new System.Drawing.Point(592, 194);
            this.lbLed3.Name = "lbLed3";
            this.lbLed3.Renderer = null;
            this.lbLed3.Size = new System.Drawing.Size(83, 69);
            this.lbLed3.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
            this.lbLed3.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular;
            this.lbLed3.TabIndex = 3;
            // 
            // lbLed4
            // 
            this.lbLed4.BackColor = System.Drawing.Color.White;
            this.lbLed4.BlinkInterval = 500;
            this.lbLed4.Label = "Ala sur";
            this.lbLed4.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top;
            this.lbLed4.LedColor = System.Drawing.Color.Red;
            this.lbLed4.LedSize = new System.Drawing.SizeF(40F, 40F);
            this.lbLed4.Location = new System.Drawing.Point(1030, 565);
            this.lbLed4.Name = "lbLed4";
            this.lbLed4.Renderer = null;
            this.lbLed4.Size = new System.Drawing.Size(79, 81);
            this.lbLed4.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
            this.lbLed4.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular;
            this.lbLed4.TabIndex = 4;
            // 
            // lbLed5
            // 
            this.lbLed5.BackColor = System.Drawing.Color.White;
            this.lbLed5.BlinkInterval = 500;
            this.lbLed5.Label = "Ala oeste";
            this.lbLed5.LabelPosition = LBSoft.IndustrialCtrls.Leds.LBLed.LedLabelPosition.Top;
            this.lbLed5.LedColor = System.Drawing.Color.Red;
            this.lbLed5.LedSize = new System.Drawing.SizeF(40F, 40F);
            this.lbLed5.Location = new System.Drawing.Point(884, 225);
            this.lbLed5.Name = "lbLed5";
            this.lbLed5.Renderer = null;
            this.lbLed5.Size = new System.Drawing.Size(81, 76);
            this.lbLed5.State = LBSoft.IndustrialCtrls.Leds.LBLed.LedState.Off;
            this.lbLed5.Style = LBSoft.IndustrialCtrls.Leds.LBLed.LedStyle.Circular;
            this.lbLed5.TabIndex = 5;
            // 
            // lbButton2
            // 
            this.lbButton2.BackColor = System.Drawing.Color.Transparent;
            this.lbButton2.ButtonColor = System.Drawing.Color.Gray;
            this.lbButton2.Label = "";
            this.lbButton2.Location = new System.Drawing.Point(40, 313);
            this.lbButton2.Name = "lbButton2";
            this.lbButton2.Renderer = null;
            this.lbButton2.RepeatInterval = 100;
            this.lbButton2.RepeatState = false;
            this.lbButton2.Size = new System.Drawing.Size(50, 50);
            this.lbButton2.StartRepeatInterval = 500;
            this.lbButton2.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.lbButton2.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Circular;
            this.lbButton2.TabIndex = 7;
            this.lbButton2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbButton2_MouseClick);
            // 
            // lbButton3
            // 
            this.lbButton3.BackColor = System.Drawing.Color.Transparent;
            this.lbButton3.ButtonColor = System.Drawing.Color.Gray;
            this.lbButton3.Label = "";
            this.lbButton3.Location = new System.Drawing.Point(40, 494);
            this.lbButton3.Name = "lbButton3";
            this.lbButton3.Renderer = null;
            this.lbButton3.RepeatInterval = 100;
            this.lbButton3.RepeatState = false;
            this.lbButton3.Size = new System.Drawing.Size(50, 50);
            this.lbButton3.StartRepeatInterval = 500;
            this.lbButton3.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.lbButton3.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Circular;
            this.lbButton3.TabIndex = 8;
            this.lbButton3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbButton3_MouseClick);
            // 
            // lbButton4
            // 
            this.lbButton4.BackColor = System.Drawing.Color.Transparent;
            this.lbButton4.ButtonColor = System.Drawing.Color.Gray;
            this.lbButton4.Label = "";
            this.lbButton4.Location = new System.Drawing.Point(40, 719);
            this.lbButton4.Name = "lbButton4";
            this.lbButton4.Renderer = null;
            this.lbButton4.RepeatInterval = 100;
            this.lbButton4.RepeatState = false;
            this.lbButton4.Size = new System.Drawing.Size(50, 50);
            this.lbButton4.StartRepeatInterval = 500;
            this.lbButton4.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.lbButton4.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Circular;
            this.lbButton4.TabIndex = 9;
            this.lbButton4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbButton4_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 699);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ala Oeste";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(570, 767);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Puerta 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 466);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ala Sur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1144, 683);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Puerta 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ala Norte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(1101, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Puerta 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ala Este";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1101, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Puerta 4";
            // 
            // Flecha3_Arr
            // 
            this.Flecha3_Arr.BackColor = System.Drawing.Color.Transparent;
            this.Flecha3_Arr.Image = ((System.Drawing.Image)(resources.GetObject("Flecha3_Arr.Image")));
            this.Flecha3_Arr.Location = new System.Drawing.Point(884, 368);
            this.Flecha3_Arr.Name = "Flecha3_Arr";
            this.Flecha3_Arr.Size = new System.Drawing.Size(52, 76);
            this.Flecha3_Arr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flecha3_Arr.TabIndex = 20;
            this.Flecha3_Arr.TabStop = false;
            // 
            // Flecha1_D
            // 
            this.Flecha1_D.Image = ((System.Drawing.Image)(resources.GetObject("Flecha1_D.Image")));
            this.Flecha1_D.Location = new System.Drawing.Point(342, 445);
            this.Flecha1_D.Name = "Flecha1_D";
            this.Flecha1_D.Size = new System.Drawing.Size(87, 49);
            this.Flecha1_D.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flecha1_D.TabIndex = 18;
            this.Flecha1_D.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(150, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1128, 841);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Flecha4_D
            // 
            this.Flecha4_D.Image = ((System.Drawing.Image)(resources.GetObject("Flecha4_D.Image")));
            this.Flecha4_D.Location = new System.Drawing.Point(849, 522);
            this.Flecha4_D.Name = "Flecha4_D";
            this.Flecha4_D.Size = new System.Drawing.Size(87, 49);
            this.Flecha4_D.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flecha4_D.TabIndex = 21;
            this.Flecha4_D.TabStop = false;
            // 
            // Flecha1_I
            // 
            this.Flecha1_I.Image = ((System.Drawing.Image)(resources.GetObject("Flecha1_I.Image")));
            this.Flecha1_I.Location = new System.Drawing.Point(342, 445);
            this.Flecha1_I.Name = "Flecha1_I";
            this.Flecha1_I.Size = new System.Drawing.Size(87, 49);
            this.Flecha1_I.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flecha1_I.TabIndex = 22;
            this.Flecha1_I.TabStop = false;
            this.Flecha1_I.Visible = false;
            // 
            // Flecha4_I
            // 
            this.Flecha4_I.Image = ((System.Drawing.Image)(resources.GetObject("Flecha4_I.Image")));
            this.Flecha4_I.Location = new System.Drawing.Point(849, 522);
            this.Flecha4_I.Name = "Flecha4_I";
            this.Flecha4_I.Size = new System.Drawing.Size(87, 49);
            this.Flecha4_I.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flecha4_I.TabIndex = 23;
            this.Flecha4_I.TabStop = false;
            this.Flecha4_I.Visible = false;
            // 
            // Flecha2_Arr
            // 
            this.Flecha2_Arr.BackColor = System.Drawing.SystemColors.Control;
            this.Flecha2_Arr.Image = ((System.Drawing.Image)(resources.GetObject("Flecha2_Arr.Image")));
            this.Flecha2_Arr.Location = new System.Drawing.Point(592, 304);
            this.Flecha2_Arr.Name = "Flecha2_Arr";
            this.Flecha2_Arr.Size = new System.Drawing.Size(52, 75);
            this.Flecha2_Arr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flecha2_Arr.TabIndex = 24;
            this.Flecha2_Arr.TabStop = false;
            // 
            // Flecha3_Abj
            // 
            this.Flecha3_Abj.BackColor = System.Drawing.Color.Transparent;
            this.Flecha3_Abj.Image = ((System.Drawing.Image)(resources.GetObject("Flecha3_Abj.Image")));
            this.Flecha3_Abj.Location = new System.Drawing.Point(884, 368);
            this.Flecha3_Abj.Name = "Flecha3_Abj";
            this.Flecha3_Abj.Size = new System.Drawing.Size(52, 76);
            this.Flecha3_Abj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flecha3_Abj.TabIndex = 25;
            this.Flecha3_Abj.TabStop = false;
            this.Flecha3_Abj.Visible = false;
            // 
            // Flecha2_Abj
            // 
            this.Flecha2_Abj.BackColor = System.Drawing.SystemColors.Control;
            this.Flecha2_Abj.Image = ((System.Drawing.Image)(resources.GetObject("Flecha2_Abj.Image")));
            this.Flecha2_Abj.Location = new System.Drawing.Point(592, 304);
            this.Flecha2_Abj.Name = "Flecha2_Abj";
            this.Flecha2_Abj.Size = new System.Drawing.Size(52, 75);
            this.Flecha2_Abj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flecha2_Abj.TabIndex = 26;
            this.Flecha2_Abj.TabStop = false;
            this.Flecha2_Abj.Visible = false;
            // 
            // serialPort2
            // 
            this.serialPort2.PortName = "COM20";
            this.serialPort2.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort2_DataReceived_1);
            // 
            // lbButton5
            // 
            this.lbButton5.BackColor = System.Drawing.Color.Transparent;
            this.lbButton5.ButtonColor = System.Drawing.Color.Gray;
            this.lbButton5.Label = "";
            this.lbButton5.Location = new System.Drawing.Point(40, 51);
            this.lbButton5.Name = "lbButton5";
            this.lbButton5.Renderer = null;
            this.lbButton5.RepeatInterval = 100;
            this.lbButton5.RepeatState = false;
            this.lbButton5.Size = new System.Drawing.Size(50, 50);
            this.lbButton5.StartRepeatInterval = 500;
            this.lbButton5.State = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonState.Normal;
            this.lbButton5.Style = LBSoft.IndustrialCtrls.Buttons.LBButton.ButtonStyle.Circular;
            this.lbButton5.TabIndex = 27;
            this.lbButton5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lbButton5_MouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "RESET";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1483, 875);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbButton5);
            this.Controls.Add(this.Flecha2_Abj);
            this.Controls.Add(this.Flecha3_Abj);
            this.Controls.Add(this.Flecha2_Arr);
            this.Controls.Add(this.Flecha4_I);
            this.Controls.Add(this.Flecha1_I);
            this.Controls.Add(this.Flecha4_D);
            this.Controls.Add(this.Flecha3_Arr);
            this.Controls.Add(this.Flecha1_D);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbButton4);
            this.Controls.Add(this.lbButton3);
            this.Controls.Add(this.lbButton2);
            this.Controls.Add(this.lbLed5);
            this.Controls.Add(this.lbLed4);
            this.Controls.Add(this.lbLed3);
            this.Controls.Add(this.lbLed2);
            this.Controls.Add(this.lbButton1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "SCADA";
            ((System.ComponentModel.ISupportInitialize)(this.Flecha3_Arr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flecha1_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flecha4_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flecha1_I)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flecha4_I)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flecha2_Arr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flecha3_Abj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flecha2_Abj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private LBSoft.IndustrialCtrls.Buttons.LBButton lbButton1;
        private LBSoft.IndustrialCtrls.Leds.LBLed lbLed2;
        private LBSoft.IndustrialCtrls.Leds.LBLed lbLed3;
        private LBSoft.IndustrialCtrls.Leds.LBLed lbLed4;
        private LBSoft.IndustrialCtrls.Leds.LBLed lbLed5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private LBSoft.IndustrialCtrls.Buttons.LBButton lbButton2;
        private LBSoft.IndustrialCtrls.Buttons.LBButton lbButton3;
        private LBSoft.IndustrialCtrls.Buttons.LBButton lbButton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox Flecha1_D;
        private System.Windows.Forms.PictureBox Flecha3_Arr;
        private System.Windows.Forms.PictureBox Flecha4_D;
        private System.Windows.Forms.PictureBox Flecha1_I;
        private System.Windows.Forms.PictureBox Flecha4_I;
        private System.Windows.Forms.PictureBox Flecha2_Arr;
        private System.Windows.Forms.PictureBox Flecha3_Abj;
        private System.Windows.Forms.PictureBox Flecha2_Abj;
        private System.IO.Ports.SerialPort serialPort2;
        private LBSoft.IndustrialCtrls.Buttons.LBButton lbButton5;
        private System.Windows.Forms.Label label9;
    }
}

