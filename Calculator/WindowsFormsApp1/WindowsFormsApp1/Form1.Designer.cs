namespace WindowsFormsApp1
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.TXTdisplay = new System.Windows.Forms.TextBox();
            this.BTN7 = new System.Windows.Forms.Button();
            this.BTN8 = new System.Windows.Forms.Button();
            this.BTN5 = new System.Windows.Forms.Button();
            this.BTN4 = new System.Windows.Forms.Button();
            this.BTN6 = new System.Windows.Forms.Button();
            this.BTN9 = new System.Windows.Forms.Button();
            this.BTNminus = new System.Windows.Forms.Button();
            this.BTN3 = new System.Windows.Forms.Button();
            this.BTN0 = new System.Windows.Forms.Button();
            this.BTNplus = new System.Windows.Forms.Button();
            this.BTN2 = new System.Windows.Forms.Button();
            this.BTN1 = new System.Windows.Forms.Button();
            this.BTNmultiply = new System.Windows.Forms.Button();
            this.BTNdivide = new System.Windows.Forms.Button();
            this.BTNclear = new System.Windows.Forms.Button();
            this.BTNpoint = new System.Windows.Forms.Button();
            this.BTNequals = new System.Windows.Forms.Button();
            this.BTNexit = new System.Windows.Forms.Button();
            this.BTNmemplsus = new System.Windows.Forms.Button();
            this.BTNmemminus = new System.Windows.Forms.Button();
            this.BTNmemrecall = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BTNhlaf = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.BTNsquare = new System.Windows.Forms.Button();
            this.BTNans = new System.Windows.Forms.Button();
            this.BTNce = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BTNsin = new System.Windows.Forms.Button();
            this.BTNcos = new System.Windows.Forms.Button();
            this.BTNtan = new System.Windows.Forms.Button();
            this.BTNround = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTdisplay
            // 
            this.TXTdisplay.Location = new System.Drawing.Point(12, 12);
            this.TXTdisplay.Name = "TXTdisplay";
            this.TXTdisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TXTdisplay.Size = new System.Drawing.Size(217, 20);
            this.TXTdisplay.TabIndex = 0;
            this.TXTdisplay.TabStop = false;
            this.TXTdisplay.Text = "0";
            this.TXTdisplay.TextChanged += new System.EventHandler(this.TXTdisplay_TextChanged);
            // 
            // BTN7
            // 
            this.BTN7.Location = new System.Drawing.Point(12, 60);
            this.BTN7.Name = "BTN7";
            this.BTN7.Size = new System.Drawing.Size(50, 50);
            this.BTN7.TabIndex = 1;
            this.BTN7.Text = "7";
            this.BTN7.UseVisualStyleBackColor = true;
            this.BTN7.Click += new System.EventHandler(this.BTN7_Click);
            // 
            // BTN8
            // 
            this.BTN8.Location = new System.Drawing.Point(68, 60);
            this.BTN8.Name = "BTN8";
            this.BTN8.Size = new System.Drawing.Size(50, 50);
            this.BTN8.TabIndex = 2;
            this.BTN8.Text = "8";
            this.BTN8.UseVisualStyleBackColor = true;
            this.BTN8.Click += new System.EventHandler(this.BTN8_Click);
            // 
            // BTN5
            // 
            this.BTN5.Location = new System.Drawing.Point(68, 116);
            this.BTN5.Name = "BTN5";
            this.BTN5.Size = new System.Drawing.Size(50, 50);
            this.BTN5.TabIndex = 4;
            this.BTN5.Text = "5";
            this.BTN5.UseVisualStyleBackColor = true;
            this.BTN5.Click += new System.EventHandler(this.BTN5_Click);
            // 
            // BTN4
            // 
            this.BTN4.Location = new System.Drawing.Point(12, 116);
            this.BTN4.Name = "BTN4";
            this.BTN4.Size = new System.Drawing.Size(50, 50);
            this.BTN4.TabIndex = 3;
            this.BTN4.Text = "4";
            this.BTN4.UseVisualStyleBackColor = true;
            this.BTN4.Click += new System.EventHandler(this.BTN4_Click);
            // 
            // BTN6
            // 
            this.BTN6.Location = new System.Drawing.Point(124, 116);
            this.BTN6.Name = "BTN6";
            this.BTN6.Size = new System.Drawing.Size(50, 50);
            this.BTN6.TabIndex = 7;
            this.BTN6.Text = "6";
            this.BTN6.UseVisualStyleBackColor = true;
            this.BTN6.Click += new System.EventHandler(this.BTN6_Click);
            // 
            // BTN9
            // 
            this.BTN9.Location = new System.Drawing.Point(124, 60);
            this.BTN9.Name = "BTN9";
            this.BTN9.Size = new System.Drawing.Size(50, 50);
            this.BTN9.TabIndex = 5;
            this.BTN9.Text = "9";
            this.BTN9.UseVisualStyleBackColor = true;
            this.BTN9.Click += new System.EventHandler(this.BTN9_Click);
            // 
            // BTNminus
            // 
            this.BTNminus.Location = new System.Drawing.Point(182, 60);
            this.BTNminus.Name = "BTNminus";
            this.BTNminus.Size = new System.Drawing.Size(50, 50);
            this.BTNminus.TabIndex = 15;
            this.BTNminus.Text = "-";
            this.BTNminus.UseVisualStyleBackColor = true;
            this.BTNminus.Click += new System.EventHandler(this.BTNminus_Click);
            // 
            // BTN3
            // 
            this.BTN3.Location = new System.Drawing.Point(124, 172);
            this.BTN3.Name = "BTN3";
            this.BTN3.Size = new System.Drawing.Size(50, 50);
            this.BTN3.TabIndex = 13;
            this.BTN3.Text = "3";
            this.BTN3.UseVisualStyleBackColor = true;
            this.BTN3.Click += new System.EventHandler(this.BTN3_Click);
            // 
            // BTN0
            // 
            this.BTN0.Location = new System.Drawing.Point(68, 228);
            this.BTN0.Name = "BTN0";
            this.BTN0.Size = new System.Drawing.Size(50, 50);
            this.BTN0.TabIndex = 12;
            this.BTN0.Text = "0";
            this.BTN0.UseVisualStyleBackColor = true;
            this.BTN0.Click += new System.EventHandler(this.BTN0_Click);
            // 
            // BTNplus
            // 
            this.BTNplus.Location = new System.Drawing.Point(182, 116);
            this.BTNplus.Name = "BTNplus";
            this.BTNplus.Size = new System.Drawing.Size(50, 50);
            this.BTNplus.TabIndex = 11;
            this.BTNplus.Text = "+";
            this.BTNplus.UseVisualStyleBackColor = true;
            this.BTNplus.Click += new System.EventHandler(this.BTNplus_Click);
            // 
            // BTN2
            // 
            this.BTN2.Location = new System.Drawing.Point(68, 172);
            this.BTN2.Name = "BTN2";
            this.BTN2.Size = new System.Drawing.Size(50, 50);
            this.BTN2.TabIndex = 10;
            this.BTN2.Text = "2";
            this.BTN2.UseVisualStyleBackColor = true;
            this.BTN2.Click += new System.EventHandler(this.BTN2_Click);
            // 
            // BTN1
            // 
            this.BTN1.Location = new System.Drawing.Point(12, 172);
            this.BTN1.Name = "BTN1";
            this.BTN1.Size = new System.Drawing.Size(50, 50);
            this.BTN1.TabIndex = 9;
            this.BTN1.Text = "1";
            this.BTN1.UseVisualStyleBackColor = true;
            this.BTN1.Click += new System.EventHandler(this.BTN1_Click);
            // 
            // BTNmultiply
            // 
            this.BTNmultiply.Location = new System.Drawing.Point(182, 172);
            this.BTNmultiply.Name = "BTNmultiply";
            this.BTNmultiply.Size = new System.Drawing.Size(50, 50);
            this.BTNmultiply.TabIndex = 16;
            this.BTNmultiply.Text = "x";
            this.BTNmultiply.UseVisualStyleBackColor = true;
            this.BTNmultiply.Click += new System.EventHandler(this.BTNmultiply_Click);
            // 
            // BTNdivide
            // 
            this.BTNdivide.Location = new System.Drawing.Point(182, 228);
            this.BTNdivide.Name = "BTNdivide";
            this.BTNdivide.Size = new System.Drawing.Size(50, 50);
            this.BTNdivide.TabIndex = 17;
            this.BTNdivide.Text = "÷";
            this.BTNdivide.UseVisualStyleBackColor = true;
            this.BTNdivide.Click += new System.EventHandler(this.BTNdivide_Click);
            // 
            // BTNclear
            // 
            this.BTNclear.Location = new System.Drawing.Point(12, 38);
            this.BTNclear.Name = "BTNclear";
            this.BTNclear.Size = new System.Drawing.Size(50, 20);
            this.BTNclear.TabIndex = 18;
            this.BTNclear.Text = "clear";
            this.BTNclear.UseVisualStyleBackColor = true;
            this.BTNclear.Click += new System.EventHandler(this.BTNclear_Click);
            // 
            // BTNpoint
            // 
            this.BTNpoint.Location = new System.Drawing.Point(12, 228);
            this.BTNpoint.Name = "BTNpoint";
            this.BTNpoint.Size = new System.Drawing.Size(50, 50);
            this.BTNpoint.TabIndex = 19;
            this.BTNpoint.Text = ".";
            this.BTNpoint.UseVisualStyleBackColor = true;
            this.BTNpoint.Click += new System.EventHandler(this.BTNpoint_Click);
            // 
            // BTNequals
            // 
            this.BTNequals.Location = new System.Drawing.Point(126, 228);
            this.BTNequals.Name = "BTNequals";
            this.BTNequals.Size = new System.Drawing.Size(50, 50);
            this.BTNequals.TabIndex = 20;
            this.BTNequals.Text = "=";
            this.BTNequals.UseVisualStyleBackColor = true;
            this.BTNequals.Click += new System.EventHandler(this.BTNequals_Click);
            // 
            // BTNexit
            // 
            this.BTNexit.Location = new System.Drawing.Point(124, 38);
            this.BTNexit.Name = "BTNexit";
            this.BTNexit.Size = new System.Drawing.Size(50, 20);
            this.BTNexit.TabIndex = 21;
            this.BTNexit.Text = "exit";
            this.BTNexit.UseVisualStyleBackColor = true;
            this.BTNexit.Click += new System.EventHandler(this.BTNexit_Click);
            // 
            // BTNmemplsus
            // 
            this.BTNmemplsus.Location = new System.Drawing.Point(238, 60);
            this.BTNmemplsus.Name = "BTNmemplsus";
            this.BTNmemplsus.Size = new System.Drawing.Size(50, 50);
            this.BTNmemplsus.TabIndex = 22;
            this.BTNmemplsus.Text = "M+";
            this.BTNmemplsus.UseVisualStyleBackColor = true;
            this.BTNmemplsus.Click += new System.EventHandler(this.BTNmemplsus_Click);
            // 
            // BTNmemminus
            // 
            this.BTNmemminus.Location = new System.Drawing.Point(238, 116);
            this.BTNmemminus.Name = "BTNmemminus";
            this.BTNmemminus.Size = new System.Drawing.Size(50, 50);
            this.BTNmemminus.TabIndex = 23;
            this.BTNmemminus.Text = "M-";
            this.BTNmemminus.UseVisualStyleBackColor = true;
            this.BTNmemminus.Click += new System.EventHandler(this.BTNmemminus_Click);
            // 
            // BTNmemrecall
            // 
            this.BTNmemrecall.Location = new System.Drawing.Point(238, 172);
            this.BTNmemrecall.Name = "BTNmemrecall";
            this.BTNmemrecall.Size = new System.Drawing.Size(50, 50);
            this.BTNmemrecall.TabIndex = 24;
            this.BTNmemrecall.Text = "Mr";
            this.BTNmemrecall.UseVisualStyleBackColor = true;
            this.BTNmemrecall.Click += new System.EventHandler(this.BTNmemrecall_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(294, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 25;
            this.button4.Text = "C";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BTNhlaf
            // 
            this.BTNhlaf.Location = new System.Drawing.Point(294, 172);
            this.BTNhlaf.Name = "BTNhlaf";
            this.BTNhlaf.Size = new System.Drawing.Size(50, 50);
            this.BTNhlaf.TabIndex = 26;
            this.BTNhlaf.Text = "1/2";
            this.BTNhlaf.UseVisualStyleBackColor = true;
            this.BTNhlaf.Click += new System.EventHandler(this.BTNhlaf_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(294, 228);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 27;
            this.button6.Text = "+/-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // BTNsquare
            // 
            this.BTNsquare.Location = new System.Drawing.Point(294, 116);
            this.BTNsquare.Name = "BTNsquare";
            this.BTNsquare.Size = new System.Drawing.Size(50, 50);
            this.BTNsquare.TabIndex = 28;
            this.BTNsquare.Text = "x2";
            this.BTNsquare.UseVisualStyleBackColor = true;
            this.BTNsquare.Click += new System.EventHandler(this.BTNsquare_Click);
            // 
            // BTNans
            // 
            this.BTNans.Location = new System.Drawing.Point(238, 227);
            this.BTNans.Name = "BTNans";
            this.BTNans.Size = new System.Drawing.Size(50, 50);
            this.BTNans.TabIndex = 29;
            this.BTNans.Text = "ANS";
            this.BTNans.UseVisualStyleBackColor = true;
            this.BTNans.Click += new System.EventHandler(this.BTNans_Click);
            // 
            // BTNce
            // 
            this.BTNce.Location = new System.Drawing.Point(68, 38);
            this.BTNce.Name = "BTNce";
            this.BTNce.Size = new System.Drawing.Size(50, 20);
            this.BTNce.TabIndex = 30;
            this.BTNce.Text = "ce";
            this.BTNce.UseVisualStyleBackColor = true;
            this.BTNce.Click += new System.EventHandler(this.BTNce_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.trackBar1.Location = new System.Drawing.Point(12, 283);
            this.trackBar1.Maximum = 10000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(332, 45);
            this.trackBar1.TabIndex = 31;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 32;
            this.button1.Text = "x3";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(68, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 33;
            this.button2.Text = "√x";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTNsin
            // 
            this.BTNsin.Location = new System.Drawing.Point(126, 334);
            this.BTNsin.Name = "BTNsin";
            this.BTNsin.Size = new System.Drawing.Size(50, 50);
            this.BTNsin.TabIndex = 34;
            this.BTNsin.Text = "Sin()";
            this.BTNsin.UseVisualStyleBackColor = true;
            this.BTNsin.Click += new System.EventHandler(this.BTNsin_Click);
            // 
            // BTNcos
            // 
            this.BTNcos.Location = new System.Drawing.Point(182, 334);
            this.BTNcos.Name = "BTNcos";
            this.BTNcos.Size = new System.Drawing.Size(50, 50);
            this.BTNcos.TabIndex = 35;
            this.BTNcos.Text = "Cos()";
            this.BTNcos.UseVisualStyleBackColor = true;
            this.BTNcos.Click += new System.EventHandler(this.BTNcos_Click);
            // 
            // BTNtan
            // 
            this.BTNtan.Location = new System.Drawing.Point(238, 334);
            this.BTNtan.Name = "BTNtan";
            this.BTNtan.Size = new System.Drawing.Size(50, 50);
            this.BTNtan.TabIndex = 36;
            this.BTNtan.Text = "Tan()";
            this.BTNtan.UseVisualStyleBackColor = true;
            this.BTNtan.Click += new System.EventHandler(this.BTNtan_Click);
            // 
            // BTNround
            // 
            this.BTNround.Location = new System.Drawing.Point(294, 334);
            this.BTNround.Name = "BTNround";
            this.BTNround.Size = new System.Drawing.Size(50, 50);
            this.BTNround.TabIndex = 37;
            this.BTNround.Text = "Rou()";
            this.BTNround.UseVisualStyleBackColor = true;
            this.BTNround.Click += new System.EventHandler(this.BTNround_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Colorful_Geometric_Simple_Background_Image;
            this.ClientSize = new System.Drawing.Size(356, 393);
            this.Controls.Add(this.BTNround);
            this.Controls.Add(this.BTNtan);
            this.Controls.Add(this.BTNcos);
            this.Controls.Add(this.BTNsin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.BTNce);
            this.Controls.Add(this.BTNans);
            this.Controls.Add(this.BTNsquare);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.BTNhlaf);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.BTNmemrecall);
            this.Controls.Add(this.BTNmemminus);
            this.Controls.Add(this.BTNmemplsus);
            this.Controls.Add(this.BTNexit);
            this.Controls.Add(this.BTNequals);
            this.Controls.Add(this.BTNpoint);
            this.Controls.Add(this.BTNclear);
            this.Controls.Add(this.BTNdivide);
            this.Controls.Add(this.BTNmultiply);
            this.Controls.Add(this.BTNminus);
            this.Controls.Add(this.BTN3);
            this.Controls.Add(this.BTN0);
            this.Controls.Add(this.BTNplus);
            this.Controls.Add(this.BTN2);
            this.Controls.Add(this.BTN1);
            this.Controls.Add(this.BTN6);
            this.Controls.Add(this.BTN9);
            this.Controls.Add(this.BTN5);
            this.Controls.Add(this.BTN4);
            this.Controls.Add(this.BTN8);
            this.Controls.Add(this.BTN7);
            this.Controls.Add(this.TXTdisplay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTdisplay;
        private System.Windows.Forms.Button BTN7;
        private System.Windows.Forms.Button BTN8;
        private System.Windows.Forms.Button BTN5;
        private System.Windows.Forms.Button BTN4;
        private System.Windows.Forms.Button BTN6;
        private System.Windows.Forms.Button BTN9;
        private System.Windows.Forms.Button BTNminus;
        private System.Windows.Forms.Button BTN3;
        private System.Windows.Forms.Button BTN0;
        private System.Windows.Forms.Button BTNplus;
        private System.Windows.Forms.Button BTN2;
        private System.Windows.Forms.Button BTN1;
        private System.Windows.Forms.Button BTNmultiply;
        private System.Windows.Forms.Button BTNdivide;
        private System.Windows.Forms.Button BTNclear;
        private System.Windows.Forms.Button BTNpoint;
        private System.Windows.Forms.Button BTNequals;
        private System.Windows.Forms.Button BTNexit;
        private System.Windows.Forms.Button BTNmemplsus;
        private System.Windows.Forms.Button BTNmemminus;
        private System.Windows.Forms.Button BTNmemrecall;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BTNhlaf;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button BTNsquare;
        private System.Windows.Forms.Button BTNans;
        private System.Windows.Forms.Button BTNce;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTNsin;
        private System.Windows.Forms.Button BTNcos;
        private System.Windows.Forms.Button BTNtan;
        private System.Windows.Forms.Button BTNround;
    }
}

