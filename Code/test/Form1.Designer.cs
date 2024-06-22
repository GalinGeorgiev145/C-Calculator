namespace test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.buttonCalculator = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.buttonMath = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonHome
            // 
            resources.ApplyResources(this.buttonHome, "buttonHome");
            this.buttonHome.BackColor = System.Drawing.Color.Gray;
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Controls.Add(this.buttonMinimize);
            this.panel1.Controls.Add(this.btnclose);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.buttonMinimize, "buttonMinimize");
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.ForeColor = System.Drawing.Color.White;
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Gray;
            resources.ApplyResources(this.btnclose, "btnclose");
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Name = "btnclose";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // buttonCalculator
            // 
            resources.ApplyResources(this.buttonCalculator, "buttonCalculator");
            this.buttonCalculator.BackColor = System.Drawing.Color.Gray;
            this.buttonCalculator.FlatAppearance.BorderSize = 0;
            this.buttonCalculator.ForeColor = System.Drawing.Color.White;
            this.buttonCalculator.Name = "buttonCalculator";
            this.buttonCalculator.UseVisualStyleBackColor = false;
            this.buttonCalculator.Click += new System.EventHandler(this.buttonCalculator_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.buttonSquare);
            this.panel2.Controls.Add(this.buttonTriangle);
            this.panel2.Controls.Add(this.buttonMath);
            this.panel2.Controls.Add(this.buttonCalculator);
            this.panel2.Controls.Add(this.buttonCircle);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buttonSquare
            // 
            resources.ApplyResources(this.buttonSquare, "buttonSquare");
            this.buttonSquare.BackColor = System.Drawing.Color.Gray;
            this.buttonSquare.FlatAppearance.BorderSize = 0;
            this.buttonSquare.ForeColor = System.Drawing.Color.White;
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.UseVisualStyleBackColor = false;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // buttonTriangle
            // 
            resources.ApplyResources(this.buttonTriangle, "buttonTriangle");
            this.buttonTriangle.BackColor = System.Drawing.Color.Gray;
            this.buttonTriangle.FlatAppearance.BorderSize = 0;
            this.buttonTriangle.ForeColor = System.Drawing.Color.White;
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.UseVisualStyleBackColor = false;
            this.buttonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
            // 
            // buttonMath
            // 
            resources.ApplyResources(this.buttonMath, "buttonMath");
            this.buttonMath.BackColor = System.Drawing.Color.Gray;
            this.buttonMath.FlatAppearance.BorderSize = 0;
            this.buttonMath.ForeColor = System.Drawing.Color.White;
            this.buttonMath.Name = "buttonMath";
            this.buttonMath.UseVisualStyleBackColor = false;
            this.buttonMath.Click += new System.EventHandler(this.buttonMath_Click);
            // 
            // buttonCircle
            // 
            resources.ApplyResources(this.buttonCircle, "buttonCircle");
            this.buttonCircle.BackColor = System.Drawing.Color.Gray;
            this.buttonCircle.FlatAppearance.BorderSize = 0;
            this.buttonCircle.ForeColor = System.Drawing.Color.White;
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.UseVisualStyleBackColor = false;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button buttonCalculator;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.Button buttonMath;
        private System.Windows.Forms.Button buttonCircle;
    }
}

