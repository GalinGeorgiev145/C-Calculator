namespace test
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
            this.notesCal = new System.Windows.Forms.RichTextBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textDisplay = new System.Windows.Forms.TextBox();
            this.buttonDevide = new System.Windows.Forms.Button();
            this.buttonMutiply = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonBackSpace = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.panelCal = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonHis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelCal.SuspendLayout();
            this.SuspendLayout();
            // 
            // notesCal
            // 
            this.notesCal.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.notesCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.notesCal.ForeColor = System.Drawing.Color.White;
            this.notesCal.Location = new System.Drawing.Point(416, 24);
            this.notesCal.Name = "notesCal";
            this.notesCal.Size = new System.Drawing.Size(280, 330);
            this.notesCal.TabIndex = 101;
            this.notesCal.Text = "";
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonDel.Location = new System.Drawing.Point(576, 366);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(120, 40);
            this.buttonDel.TabIndex = 102;
            this.buttonDel.Text = "Изтриване на бележкките";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.button1_Click);
            // 
            // textDisplay
            // 
            this.textDisplay.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDisplay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.textDisplay.Location = new System.Drawing.Point(23, 24);
            this.textDisplay.Name = "textDisplay";
            this.textDisplay.ReadOnly = true;
            this.textDisplay.Size = new System.Drawing.Size(272, 60);
            this.textDisplay.TabIndex = 103;
            this.textDisplay.Text = "0";
            this.textDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonDevide
            // 
            this.buttonDevide.BackColor = System.Drawing.Color.DimGray;
            this.buttonDevide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDevide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonDevide.ForeColor = System.Drawing.Color.White;
            this.buttonDevide.Location = new System.Drawing.Point(23, 102);
            this.buttonDevide.Name = "buttonDevide";
            this.buttonDevide.Size = new System.Drawing.Size(60, 60);
            this.buttonDevide.TabIndex = 104;
            this.buttonDevide.Text = "÷";
            this.buttonDevide.UseVisualStyleBackColor = false;
            this.buttonDevide.Click += new System.EventHandler(this.buttonDevide_Click);
            // 
            // buttonMutiply
            // 
            this.buttonMutiply.BackColor = System.Drawing.Color.DimGray;
            this.buttonMutiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMutiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonMutiply.ForeColor = System.Drawing.Color.White;
            this.buttonMutiply.Location = new System.Drawing.Point(93, 102);
            this.buttonMutiply.Name = "buttonMutiply";
            this.buttonMutiply.Size = new System.Drawing.Size(60, 60);
            this.buttonMutiply.TabIndex = 105;
            this.buttonMutiply.Text = "x";
            this.buttonMutiply.UseVisualStyleBackColor = false;
            this.buttonMutiply.Click += new System.EventHandler(this.buttonMutiply_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.DimGray;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonMinus.ForeColor = System.Drawing.Color.White;
            this.buttonMinus.Location = new System.Drawing.Point(164, 102);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(60, 60);
            this.buttonMinus.TabIndex = 106;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonBackSpace
            // 
            this.buttonBackSpace.BackColor = System.Drawing.Color.DimGray;
            this.buttonBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.buttonBackSpace.ForeColor = System.Drawing.Color.White;
            this.buttonBackSpace.Location = new System.Drawing.Point(235, 102);
            this.buttonBackSpace.Name = "buttonBackSpace";
            this.buttonBackSpace.Size = new System.Drawing.Size(60, 60);
            this.buttonBackSpace.TabIndex = 107;
            this.buttonBackSpace.Text = "⇍";
            this.buttonBackSpace.UseVisualStyleBackColor = false;
            this.buttonBackSpace.Click += new System.EventHandler(this.buttonBackSpace_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.DimGray;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.buttonPlus.ForeColor = System.Drawing.Color.White;
            this.buttonPlus.Location = new System.Drawing.Point(235, 179);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(60, 60);
            this.buttonPlus.TabIndex = 111;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.DimGray;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(164, 179);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 60);
            this.button9.TabIndex = 110;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DimGray;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(93, 179);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 60);
            this.button8.TabIndex = 109;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.DimGray;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(23, 179);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 60);
            this.button7.TabIndex = 108;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.BackColor = System.Drawing.Color.DimGray;
            this.buttonEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonEquals.ForeColor = System.Drawing.Color.White;
            this.buttonEquals.Location = new System.Drawing.Point(235, 256);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(60, 60);
            this.buttonEquals.TabIndex = 115;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = false;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DimGray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(164, 256);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 60);
            this.button6.TabIndex = 114;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(93, 256);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.TabIndex = 113;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(23, 256);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.TabIndex = 112;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.DimGray;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.ForeColor = System.Drawing.Color.White;
            this.button0.Location = new System.Drawing.Point(235, 327);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(60, 60);
            this.button0.TabIndex = 119;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(164, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.TabIndex = 118;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(93, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.TabIndex = 117;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(23, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.TabIndex = 116;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonHistory.Location = new System.Drawing.Point(416, 366);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(120, 40);
            this.buttonHistory.TabIndex = 120;
            this.buttonHistory.Text = "История на \r\nкалкулатора\r\n";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // panelCal
            // 
            this.panelCal.BackColor = System.Drawing.Color.White;
            this.panelCal.Controls.Add(this.buttonMinus);
            this.panelCal.Controls.Add(this.buttonBackSpace);
            this.panelCal.Controls.Add(this.button8);
            this.panelCal.Controls.Add(this.textDisplay);
            this.panelCal.Controls.Add(this.buttonEquals);
            this.panelCal.Controls.Add(this.button0);
            this.panelCal.Controls.Add(this.button6);
            this.panelCal.Controls.Add(this.button7);
            this.panelCal.Controls.Add(this.buttonDevide);
            this.panelCal.Controls.Add(this.button9);
            this.panelCal.Controls.Add(this.button1);
            this.panelCal.Controls.Add(this.button3);
            this.panelCal.Controls.Add(this.button5);
            this.panelCal.Controls.Add(this.buttonPlus);
            this.panelCal.Controls.Add(this.buttonMutiply);
            this.panelCal.Controls.Add(this.button2);
            this.panelCal.Controls.Add(this.button4);
            this.panelCal.Location = new System.Drawing.Point(35, 0);
            this.panelCal.Name = "panelCal";
            this.panelCal.Size = new System.Drawing.Size(319, 420);
            this.panelCal.TabIndex = 121;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(58, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 290);
            this.listBox1.TabIndex = 122;
            // 
            // buttonHis
            // 
            this.buttonHis.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonHis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonHis.Location = new System.Drawing.Point(58, 329);
            this.buttonHis.Name = "buttonHis";
            this.buttonHis.Size = new System.Drawing.Size(272, 40);
            this.buttonHis.TabIndex = 123;
            this.buttonHis.Text = "Изтриване на историята";
            this.buttonHis.UseVisualStyleBackColor = false;
            this.buttonHis.Click += new System.EventHandler(this.buttonHis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(417, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 124;
            this.label1.Text = "Бележки:";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 418);
            this.Controls.Add(this.panelCal);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.notesCal);
            this.Controls.Add(this.buttonHis);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.panelCal.ResumeLayout(false);
            this.panelCal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox notesCal;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonDevide;
        private System.Windows.Forms.Button buttonMutiply;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonBackSpace;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonHistory;
        protected System.Windows.Forms.TextBox textDisplay;
        private System.Windows.Forms.Panel panelCal;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonHis;
        private System.Windows.Forms.Label label1;
    }
}