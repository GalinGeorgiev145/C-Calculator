using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        bool mousedown;
        public Form1()
        {
            InitializeComponent();
            loadform(new Home());
        }
        public void loadform(object Form)
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(f);
            this.panelMain.Tag = f;
            f.Show();
        }


        private void buttonHome_Click(object sender, EventArgs e)
        {
            loadform(new Home());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            loadform(new Calculator());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            loadform(new circle());
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            loadform(new triangle());
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            loadform(new square());
        }

        private void buttonMath_Click(object sender, EventArgs e)
        {
            loadform(new math());
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;   
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                int mousex= MousePosition.X-400;
                int mousey= MousePosition.Y-20;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown= false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
