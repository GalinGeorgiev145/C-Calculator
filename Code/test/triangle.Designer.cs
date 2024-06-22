namespace test
{
    partial class triangle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(triangle));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textAgnelBlue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textSideB = new System.Windows.Forms.TextBox();
            this.textSideC = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.textSideA = new System.Windows.Forms.TextBox();
            this.textAgnelGreen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textAgnelRed = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.finalRes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(95, -8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(471, 414);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(207, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(433, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label3.Location = new System.Drawing.Point(327, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label5.Location = new System.Drawing.Point(523, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 39);
            this.label5.TabIndex = 9;
            this.label5.Text = "°";
            // 
            // textAgnelBlue
            // 
            this.textAgnelBlue.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textAgnelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textAgnelBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.textAgnelBlue.ForeColor = System.Drawing.Color.Blue;
            this.textAgnelBlue.Location = new System.Drawing.Point(459, 335);
            this.textAgnelBlue.Name = "textAgnelBlue";
            this.textAgnelBlue.Size = new System.Drawing.Size(64, 33);
            this.textAgnelBlue.TabIndex = 8;
            this.textAgnelBlue.TextChanged += new System.EventHandler(this.textAgnelBlue_TextChanged);
            this.textAgnelBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAgnelBlue_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label7.Location = new System.Drawing.Point(12, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 155);
            this.label7.TabIndex = 12;
            this.label7.Text = "A=\r\n\r\nB=\r\n\r\nC=\r\n";
            // 
            // textSideB
            // 
            this.textSideB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textSideB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSideB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textSideB.ForeColor = System.Drawing.Color.Black;
            this.textSideB.Location = new System.Drawing.Point(68, 97);
            this.textSideB.Name = "textSideB";
            this.textSideB.Size = new System.Drawing.Size(80, 38);
            this.textSideB.TabIndex = 14;
            this.textSideB.TextChanged += new System.EventHandler(this.textSideB_TextChanged);
            this.textSideB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSideB_KeyPress);
            // 
            // textSideC
            // 
            this.textSideC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textSideC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSideC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textSideC.ForeColor = System.Drawing.Color.Black;
            this.textSideC.Location = new System.Drawing.Point(68, 159);
            this.textSideC.Name = "textSideC";
            this.textSideC.Size = new System.Drawing.Size(80, 38);
            this.textSideC.TabIndex = 15;
            this.textSideC.TextChanged += new System.EventHandler(this.textSideC_TextChanged);
            this.textSideC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSideC_KeyPress);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Silver;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDelete.Location = new System.Drawing.Point(18, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 43);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Изтрий";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Silver;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalculate.Location = new System.Drawing.Point(18, 216);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(130, 43);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "Изчисли";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // textSideA
            // 
            this.textSideA.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textSideA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSideA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textSideA.ForeColor = System.Drawing.Color.Black;
            this.textSideA.Location = new System.Drawing.Point(68, 34);
            this.textSideA.Name = "textSideA";
            this.textSideA.Size = new System.Drawing.Size(80, 38);
            this.textSideA.TabIndex = 19;
            this.textSideA.TextChanged += new System.EventHandler(this.textSideA_TextChanged);
            this.textSideA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSideA_KeyPress);
            // 
            // textAgnelGreen
            // 
            this.textAgnelGreen.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textAgnelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textAgnelGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.textAgnelGreen.ForeColor = System.Drawing.Color.Green;
            this.textAgnelGreen.Location = new System.Drawing.Point(354, 35);
            this.textAgnelGreen.Name = "textAgnelGreen";
            this.textAgnelGreen.Size = new System.Drawing.Size(64, 33);
            this.textAgnelGreen.TabIndex = 10;
            this.textAgnelGreen.TextChanged += new System.EventHandler(this.textAgnelGreen_TextChanged);
            this.textAgnelGreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAgnelGreen_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label6.Location = new System.Drawing.Point(418, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 39);
            this.label6.TabIndex = 11;
            this.label6.Text = "°";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label4.Location = new System.Drawing.Point(184, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 39);
            this.label4.TabIndex = 22;
            this.label4.Text = "°";
            // 
            // textAgnelRed
            // 
            this.textAgnelRed.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textAgnelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textAgnelRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.textAgnelRed.ForeColor = System.Drawing.Color.Red;
            this.textAgnelRed.Location = new System.Drawing.Point(117, 335);
            this.textAgnelRed.Name = "textAgnelRed";
            this.textAgnelRed.Size = new System.Drawing.Size(64, 33);
            this.textAgnelRed.TabIndex = 21;
            this.textAgnelRed.TextChanged += new System.EventHandler(this.textAgnelRed_TextChanged);
            this.textAgnelRed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textAgnelRed_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(-1, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(705, 34);
            this.label8.TabIndex = 23;
            this.label8.Text = "Начини на употреба:\r\n2 страни 1 ъгъл / 1 страна 2 ъгъла / 3 страни. След като сте" +
    " въвели тези стойности, натиснете изчисли.";
            // 
            // finalRes
            // 
            this.finalRes.AutoSize = true;
            this.finalRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.finalRes.Location = new System.Drawing.Point(11, 11);
            this.finalRes.Name = "finalRes";
            this.finalRes.Size = new System.Drawing.Size(73, 29);
            this.finalRes.TabIndex = 24;
            this.finalRes.Text = "          ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.finalRes);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(177, 259);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(504, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 269);
            this.panel2.TabIndex = 26;
            // 
            // triangle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 420);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textAgnelRed);
            this.Controls.Add(this.textSideA);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.textSideC);
            this.Controls.Add(this.textSideB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textAgnelGreen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textAgnelBlue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "triangle";
            this.Text = "triangle";
            this.Load += new System.EventHandler(this.triangle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textAgnelBlue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textSideB;
        private System.Windows.Forms.TextBox textSideC;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox textSideA;
        private System.Windows.Forms.TextBox textAgnelGreen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAgnelRed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label finalRes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}