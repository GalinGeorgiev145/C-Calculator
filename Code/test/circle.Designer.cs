namespace test
{
    partial class circle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(circle));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.diameturLabel = new System.Windows.Forms.Label();
            this.radiusText = new System.Windows.Forms.TextBox();
            this.diameturText = new System.Windows.Forms.TextBox();
            this.liceText = new System.Windows.Forms.TextBox();
            this.obikolkaText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelD2 = new System.Windows.Forms.Label();
            this.labelD1 = new System.Windows.Forms.Label();
            this.labelP3 = new System.Windows.Forms.Label();
            this.labelP2 = new System.Windows.Forms.Label();
            this.labelP1 = new System.Windows.Forms.Label();
            this.labelS3 = new System.Windows.Forms.Label();
            this.labelS2 = new System.Windows.Forms.Label();
            this.labelS1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelLice = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 349);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.radiusLabel.ForeColor = System.Drawing.Color.Red;
            this.radiusLabel.Location = new System.Drawing.Point(134, 102);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(18, 17);
            this.radiusLabel.TabIndex = 1;
            this.radiusLabel.Text = "R";
            // 
            // diameturLabel
            // 
            this.diameturLabel.AutoSize = true;
            this.diameturLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.diameturLabel.ForeColor = System.Drawing.Color.Blue;
            this.diameturLabel.Location = new System.Drawing.Point(229, 178);
            this.diameturLabel.Name = "diameturLabel";
            this.diameturLabel.Size = new System.Drawing.Size(16, 17);
            this.diameturLabel.TabIndex = 2;
            this.diameturLabel.Text = "d";
            // 
            // radiusText
            // 
            this.radiusText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.radiusText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.radiusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.radiusText.Location = new System.Drawing.Point(382, 63);
            this.radiusText.Name = "radiusText";
            this.radiusText.Size = new System.Drawing.Size(111, 33);
            this.radiusText.TabIndex = 3;
            this.radiusText.TextChanged += new System.EventHandler(this.radiusText_TextChanged);
            this.radiusText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.radiusText_KeyPress);
            // 
            // diameturText
            // 
            this.diameturText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.diameturText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diameturText.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.diameturText.Location = new System.Drawing.Point(546, 63);
            this.diameturText.Name = "diameturText";
            this.diameturText.Size = new System.Drawing.Size(111, 33);
            this.diameturText.TabIndex = 4;
            this.diameturText.TextChanged += new System.EventHandler(this.diameturText_TextChanged);
            this.diameturText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.diameturText_KeyPress);
            // 
            // liceText
            // 
            this.liceText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.liceText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.liceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.liceText.Location = new System.Drawing.Point(382, 150);
            this.liceText.Name = "liceText";
            this.liceText.Size = new System.Drawing.Size(111, 33);
            this.liceText.TabIndex = 5;
            this.liceText.TextChanged += new System.EventHandler(this.liceText_TextChanged);
            this.liceText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.liceText_KeyPress);
            // 
            // obikolkaText
            // 
            this.obikolkaText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.obikolkaText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.obikolkaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.obikolkaText.Location = new System.Drawing.Point(546, 150);
            this.obikolkaText.Name = "obikolkaText";
            this.obikolkaText.Size = new System.Drawing.Size(111, 33);
            this.obikolkaText.TabIndex = 6;
            this.obikolkaText.TextChanged += new System.EventHandler(this.obikolkaText_TextChanged);
            this.obikolkaText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.obikolkaText_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(378, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Радиус:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(542, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Диаметър:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(542, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Обиколка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(378, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Лице:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Silver;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalculate.Location = new System.Drawing.Point(375, 215);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(130, 43);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Изчисли";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Silver;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDelete.Location = new System.Drawing.Point(537, 215);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 43);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Изтрий";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(360, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Формула:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.labelD2);
            this.panel1.Controls.Add(this.labelD1);
            this.panel1.Controls.Add(this.labelP3);
            this.panel1.Controls.Add(this.labelP2);
            this.panel1.Controls.Add(this.labelP1);
            this.panel1.Controls.Add(this.labelS3);
            this.panel1.Controls.Add(this.labelS2);
            this.panel1.Controls.Add(this.labelS1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.labelLice);
            this.panel1.Location = new System.Drawing.Point(361, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 102);
            this.panel1.TabIndex = 19;
            // 
            // labelD2
            // 
            this.labelD2.AutoSize = true;
            this.labelD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelD2.Location = new System.Drawing.Point(237, 53);
            this.labelD2.Name = "labelD2";
            this.labelD2.Size = new System.Drawing.Size(61, 17);
            this.labelD2.TabIndex = 31;
            this.labelD2.Text = "LabelD2";
            // 
            // labelD1
            // 
            this.labelD1.AutoSize = true;
            this.labelD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelD1.Location = new System.Drawing.Point(237, 36);
            this.labelD1.Name = "labelD1";
            this.labelD1.Size = new System.Drawing.Size(61, 17);
            this.labelD1.TabIndex = 30;
            this.labelD1.Text = "LabelD1";
            // 
            // labelP3
            // 
            this.labelP3.AutoSize = true;
            this.labelP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelP3.Location = new System.Drawing.Point(123, 70);
            this.labelP3.Name = "labelP3";
            this.labelP3.Size = new System.Drawing.Size(60, 17);
            this.labelP3.TabIndex = 29;
            this.labelP3.Text = "LabelP3";
            // 
            // labelP2
            // 
            this.labelP2.AutoSize = true;
            this.labelP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelP2.Location = new System.Drawing.Point(123, 53);
            this.labelP2.Name = "labelP2";
            this.labelP2.Size = new System.Drawing.Size(60, 17);
            this.labelP2.TabIndex = 28;
            this.labelP2.Text = "LabelP2";
            // 
            // labelP1
            // 
            this.labelP1.AutoSize = true;
            this.labelP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelP1.Location = new System.Drawing.Point(123, 36);
            this.labelP1.Name = "labelP1";
            this.labelP1.Size = new System.Drawing.Size(60, 17);
            this.labelP1.TabIndex = 27;
            this.labelP1.Text = "LabelP1";
            // 
            // labelS3
            // 
            this.labelS3.AutoSize = true;
            this.labelS3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelS3.Location = new System.Drawing.Point(11, 70);
            this.labelS3.Name = "labelS3";
            this.labelS3.Size = new System.Drawing.Size(60, 17);
            this.labelS3.TabIndex = 26;
            this.labelS3.Text = "LabelS3";
            // 
            // labelS2
            // 
            this.labelS2.AutoSize = true;
            this.labelS2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelS2.Location = new System.Drawing.Point(11, 53);
            this.labelS2.Name = "labelS2";
            this.labelS2.Size = new System.Drawing.Size(60, 17);
            this.labelS2.TabIndex = 25;
            this.labelS2.Text = "LabelS2";
            // 
            // labelS1
            // 
            this.labelS1.AutoSize = true;
            this.labelS1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelS1.Location = new System.Drawing.Point(11, 36);
            this.labelS1.Name = "labelS1";
            this.labelS1.Size = new System.Drawing.Size(60, 17);
            this.labelS1.TabIndex = 24;
            this.labelS1.Text = "LabelS1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.Location = new System.Drawing.Point(237, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "d=2×r";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(123, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "P=2×pi×r";
            // 
            // labelLice
            // 
            this.labelLice.AutoSize = true;
            this.labelLice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelLice.Location = new System.Drawing.Point(11, 8);
            this.labelLice.Name = "labelLice";
            this.labelLice.Size = new System.Drawing.Size(54, 17);
            this.labelLice.TabIndex = 21;
            this.labelLice.Text = "S=pi×r²";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(356, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 112);
            this.panel2.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(47, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Мерна единица:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "мм",
            "см",
            "дм",
            "м"});
            this.comboBox1.Location = new System.Drawing.Point(164, 361);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(62, 25);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // circle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(708, 418);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.obikolkaText);
            this.Controls.Add(this.liceText);
            this.Controls.Add(this.diameturText);
            this.Controls.Add(this.radiusText);
            this.Controls.Add(this.diameturLabel);
            this.Controls.Add(this.radiusLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "circle";
            this.Text = "circle";
            this.Load += new System.EventHandler(this.circle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.Label diameturLabel;
        private System.Windows.Forms.TextBox radiusText;
        private System.Windows.Forms.TextBox diameturText;
        private System.Windows.Forms.TextBox liceText;
        private System.Windows.Forms.TextBox obikolkaText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelLice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelS1;
        private System.Windows.Forms.Label labelS2;
        private System.Windows.Forms.Label labelS3;
        private System.Windows.Forms.Label labelD2;
        private System.Windows.Forms.Label labelD1;
        private System.Windows.Forms.Label labelP3;
        private System.Windows.Forms.Label labelP2;
        private System.Windows.Forms.Label labelP1;
    }
}