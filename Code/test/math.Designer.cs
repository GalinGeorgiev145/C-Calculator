namespace test
{
    partial class math
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(math));
            this.textSinOr = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.btnCalculateSinCos = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textB = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalYrav = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKvDel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.logB = new System.Windows.Forms.TextBox();
            this.logA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.logX = new System.Windows.Forms.TextBox();
            this.logBtnCalculate = new System.Windows.Forms.Button();
            this.kybX = new System.Windows.Forms.TextBox();
            this.kybZ = new System.Windows.Forms.TextBox();
            this.kybY = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kybXX = new System.Windows.Forms.TextBox();
            this.kybZZ = new System.Windows.Forms.TextBox();
            this.kybYY = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.kybResult = new System.Windows.Forms.TextBox();
            this.kybDel = new System.Windows.Forms.Button();
            this.kybCalculate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textSinOr
            // 
            this.textSinOr.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textSinOr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSinOr.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.textSinOr.Location = new System.Drawing.Point(492, 81);
            this.textSinOr.Name = "textSinOr";
            this.textSinOr.Size = new System.Drawing.Size(46, 33);
            this.textSinOr.TabIndex = 4;
            this.textSinOr.TextChanged += new System.EventHandler(this.textSinOr_TextChanged);
            this.textSinOr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSinOr_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "sin",
            "sin-1",
            "cos",
            "cos-1",
            "tan",
            "tan-1"});
            this.comboBox1.Location = new System.Drawing.Point(424, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(62, 25);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(541, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "° = ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(477, 60);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(61, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "радиус";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(405, 60);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(66, 17);
            this.checkBox2.TabIndex = 27;
            this.checkBox2.Text = "градуси";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // btnCalculateSinCos
            // 
            this.btnCalculateSinCos.BackColor = System.Drawing.Color.Silver;
            this.btnCalculateSinCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCalculateSinCos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalculateSinCos.Location = new System.Drawing.Point(589, 55);
            this.btnCalculateSinCos.Name = "btnCalculateSinCos";
            this.btnCalculateSinCos.Size = new System.Drawing.Size(102, 25);
            this.btnCalculateSinCos.TabIndex = 28;
            this.btnCalculateSinCos.Text = "изчисли";
            this.btnCalculateSinCos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalculateSinCos.UseVisualStyleBackColor = false;
            this.btnCalculateSinCos.Click += new System.EventHandler(this.btnCalculateSinCos_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.textBox1.Location = new System.Drawing.Point(589, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(102, 33);
            this.textBox1.TabIndex = 29;
            // 
            // textA
            // 
            this.textA.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textA.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.textA.Location = new System.Drawing.Point(23, 43);
            this.textA.Name = "textA";
            this.textA.Size = new System.Drawing.Size(46, 33);
            this.textA.TabIndex = 30;
            this.textA.TextChanged += new System.EventHandler(this.textA_TextChanged);
            this.textA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textA_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(70, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "x²";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "+",
            "-"});
            this.comboBox2.Location = new System.Drawing.Point(99, 51);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(35, 25);
            this.comboBox2.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(187, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "x";
            // 
            // textB
            // 
            this.textB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textB.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.textB.Location = new System.Drawing.Point(140, 43);
            this.textB.Name = "textB";
            this.textB.Size = new System.Drawing.Size(46, 33);
            this.textB.TabIndex = 33;
            this.textB.TextChanged += new System.EventHandler(this.textB_TextChanged);
            this.textB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textB_KeyPress);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "+",
            "-"});
            this.comboBox3.Location = new System.Drawing.Point(207, 48);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(35, 25);
            this.comboBox3.TabIndex = 35;
            // 
            // textC
            // 
            this.textC.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textC.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.textC.Location = new System.Drawing.Point(248, 43);
            this.textC.Name = "textC";
            this.textC.Size = new System.Drawing.Size(46, 33);
            this.textC.TabIndex = 36;
            this.textC.TextChanged += new System.EventHandler(this.textC_TextChanged);
            this.textC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textC_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(300, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "= 0 ";
            // 
            // btnCalYrav
            // 
            this.btnCalYrav.BackColor = System.Drawing.Color.Silver;
            this.btnCalYrav.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCalYrav.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCalYrav.Location = new System.Drawing.Point(243, 84);
            this.btnCalYrav.Name = "btnCalYrav";
            this.btnCalYrav.Size = new System.Drawing.Size(102, 34);
            this.btnCalYrav.TabIndex = 43;
            this.btnCalYrav.Text = "изчисли";
            this.btnCalYrav.UseVisualStyleBackColor = false;
            this.btnCalYrav.Click += new System.EventHandler(this.btnCalYrav_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(3, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(3, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 25);
            this.label7.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(23, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 126);
            this.panel1.TabIndex = 47;
            // 
            // btnKvDel
            // 
            this.btnKvDel.BackColor = System.Drawing.Color.Silver;
            this.btnKvDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnKvDel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKvDel.Location = new System.Drawing.Point(135, 84);
            this.btnKvDel.Name = "btnKvDel";
            this.btnKvDel.Size = new System.Drawing.Size(102, 34);
            this.btnKvDel.TabIndex = 48;
            this.btnKvDel.Text = "изтрий";
            this.btnKvDel.UseVisualStyleBackColor = false;
            this.btnKvDel.Click += new System.EventHandler(this.btnKvDel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(401, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 25);
            this.label8.TabIndex = 47;
            this.label8.Text = "Log";
            // 
            // logB
            // 
            this.logB.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.logB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logB.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.logB.Location = new System.Drawing.Point(476, 177);
            this.logB.Name = "logB";
            this.logB.Size = new System.Drawing.Size(46, 33);
            this.logB.TabIndex = 49;
            this.logB.TextChanged += new System.EventHandler(this.logB_TextChanged);
            this.logB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.logB_KeyPress);
            // 
            // logA
            // 
            this.logA.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.logA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logA.Location = new System.Drawing.Point(448, 194);
            this.logA.Name = "logA";
            this.logA.Size = new System.Drawing.Size(22, 20);
            this.logA.TabIndex = 50;
            this.logA.TextChanged += new System.EventHandler(this.logA_TextChanged);
            this.logA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.logA_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(525, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 25);
            this.label9.TabIndex = 51;
            this.label9.Text = "=";
            // 
            // logX
            // 
            this.logX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.logX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logX.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.logX.Location = new System.Drawing.Point(555, 177);
            this.logX.Name = "logX";
            this.logX.Size = new System.Drawing.Size(46, 33);
            this.logX.TabIndex = 52;
            this.logX.TextChanged += new System.EventHandler(this.logX_TextChanged);
            this.logX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.logX_KeyPress);
            // 
            // logBtnCalculate
            // 
            this.logBtnCalculate.BackColor = System.Drawing.Color.Silver;
            this.logBtnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.logBtnCalculate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logBtnCalculate.Location = new System.Drawing.Point(613, 177);
            this.logBtnCalculate.Name = "logBtnCalculate";
            this.logBtnCalculate.Size = new System.Drawing.Size(78, 33);
            this.logBtnCalculate.TabIndex = 53;
            this.logBtnCalculate.Text = "изчисли";
            this.logBtnCalculate.UseVisualStyleBackColor = false;
            this.logBtnCalculate.Click += new System.EventHandler(this.logBtnCalculate_Click);
            // 
            // kybX
            // 
            this.kybX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.kybX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kybX.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.kybX.ForeColor = System.Drawing.Color.Red;
            this.kybX.Location = new System.Drawing.Point(153, 356);
            this.kybX.Name = "kybX";
            this.kybX.Size = new System.Drawing.Size(64, 33);
            this.kybX.TabIndex = 54;
            this.kybX.TextChanged += new System.EventHandler(this.kybX_TextChanged);
            this.kybX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kybX_KeyPress);
            // 
            // kybZ
            // 
            this.kybZ.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.kybZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kybZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.kybZ.ForeColor = System.Drawing.Color.Blue;
            this.kybZ.Location = new System.Drawing.Point(266, 286);
            this.kybZ.Name = "kybZ";
            this.kybZ.Size = new System.Drawing.Size(64, 33);
            this.kybZ.TabIndex = 55;
            this.kybZ.TextChanged += new System.EventHandler(this.kybZ_TextChanged);
            this.kybZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kybZ_KeyPress);
            // 
            // kybY
            // 
            this.kybY.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.kybY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kybY.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.kybY.ForeColor = System.Drawing.Color.Green;
            this.kybY.Location = new System.Drawing.Point(214, 191);
            this.kybY.Name = "kybY";
            this.kybY.Size = new System.Drawing.Size(64, 33);
            this.kybY.TabIndex = 56;
            this.kybY.TextChanged += new System.EventHandler(this.kybY_TextChanged);
            this.kybY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kybY_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(127, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // kybXX
            // 
            this.kybXX.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.kybXX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kybXX.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.kybXX.ForeColor = System.Drawing.Color.Red;
            this.kybXX.Location = new System.Drawing.Point(333, 366);
            this.kybXX.Name = "kybXX";
            this.kybXX.Size = new System.Drawing.Size(64, 33);
            this.kybXX.TabIndex = 58;
            this.kybXX.TextChanged += new System.EventHandler(this.kybXX_TextChanged);
            this.kybXX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kybXX_KeyPress);
            // 
            // kybZZ
            // 
            this.kybZZ.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.kybZZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kybZZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.kybZZ.ForeColor = System.Drawing.Color.Blue;
            this.kybZZ.Location = new System.Drawing.Point(505, 366);
            this.kybZZ.Name = "kybZZ";
            this.kybZZ.Size = new System.Drawing.Size(64, 33);
            this.kybZZ.TabIndex = 59;
            this.kybZZ.TextChanged += new System.EventHandler(this.kybZZ_TextChanged);
            this.kybZZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kybZZ_KeyPress);
            // 
            // kybYY
            // 
            this.kybYY.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.kybYY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kybYY.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.kybYY.ForeColor = System.Drawing.Color.Green;
            this.kybYY.Location = new System.Drawing.Point(419, 366);
            this.kybYY.Name = "kybYY";
            this.kybYY.Size = new System.Drawing.Size(64, 33);
            this.kybYY.TabIndex = 60;
            this.kybYY.TextChanged += new System.EventHandler(this.kybYY_TextChanged);
            this.kybYY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kybYY_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(397, 371);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 25);
            this.label10.TabIndex = 61;
            this.label10.Text = "x";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(483, 371);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 25);
            this.label11.TabIndex = 62;
            this.label11.Text = "x";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label12.Location = new System.Drawing.Point(569, 371);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 25);
            this.label12.TabIndex = 63;
            this.label12.Text = "=";
            // 
            // kybResult
            // 
            this.kybResult.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.kybResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kybResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.kybResult.Location = new System.Drawing.Point(589, 366);
            this.kybResult.Name = "kybResult";
            this.kybResult.Size = new System.Drawing.Size(72, 33);
            this.kybResult.TabIndex = 64;
            // 
            // kybDel
            // 
            this.kybDel.BackColor = System.Drawing.Color.Silver;
            this.kybDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.kybDel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kybDel.Location = new System.Drawing.Point(436, 326);
            this.kybDel.Name = "kybDel";
            this.kybDel.Size = new System.Drawing.Size(102, 34);
            this.kybDel.TabIndex = 66;
            this.kybDel.Text = "изтрий";
            this.kybDel.UseVisualStyleBackColor = false;
            this.kybDel.Click += new System.EventHandler(this.kybDel_Click);
            // 
            // kybCalculate
            // 
            this.kybCalculate.BackColor = System.Drawing.Color.Silver;
            this.kybCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.kybCalculate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kybCalculate.Location = new System.Drawing.Point(559, 326);
            this.kybCalculate.Name = "kybCalculate";
            this.kybCalculate.Size = new System.Drawing.Size(102, 34);
            this.kybCalculate.TabIndex = 65;
            this.kybCalculate.Text = "изчисли";
            this.kybCalculate.UseVisualStyleBackColor = false;
            this.kybCalculate.Click += new System.EventHandler(this.button2_Click);
            // 
            // math
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 420);
            this.Controls.Add(this.kybDel);
            this.Controls.Add(this.kybCalculate);
            this.Controls.Add(this.kybResult);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.kybYY);
            this.Controls.Add(this.kybZZ);
            this.Controls.Add(this.kybXX);
            this.Controls.Add(this.kybY);
            this.Controls.Add(this.kybZ);
            this.Controls.Add(this.kybX);
            this.Controls.Add(this.logBtnCalculate);
            this.Controls.Add(this.logX);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.logA);
            this.Controls.Add(this.logB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnKvDel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCalYrav);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textC);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textB);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textA);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCalculateSinCos);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textSinOr);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "math";
            this.Text = "math";
            this.Load += new System.EventHandler(this.math_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSinOr;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button btnCalculateSinCos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textB;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalYrav;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKvDel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox logB;
        private System.Windows.Forms.TextBox logA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox logX;
        private System.Windows.Forms.Button logBtnCalculate;
        private System.Windows.Forms.TextBox kybX;
        private System.Windows.Forms.TextBox kybZ;
        private System.Windows.Forms.TextBox kybY;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox kybXX;
        private System.Windows.Forms.TextBox kybZZ;
        private System.Windows.Forms.TextBox kybYY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox kybResult;
        private System.Windows.Forms.Button kybDel;
        private System.Windows.Forms.Button kybCalculate;
    }
}