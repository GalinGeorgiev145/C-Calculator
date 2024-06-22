using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class circle : Form
    {
        public circle()
        {
            InitializeComponent();
        }

        private void circle_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "см";
            labelS1.Text = "";
            labelS2.Text = "";
            labelS3.Text = "";
            labelP1.Text = "";
            labelP2.Text = "";
            labelP3.Text = "";
            labelD1.Text = "";
            labelD2.Text = "";
        }
        string radius, diametur, lice, obikolka,shortCut;
        double radiusF, diameturF, liceF, obikolkaF;
        int fButton,ffButton;

        private void radiusText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void diameturText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void obikolkaText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void liceText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            ffButton = 1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "см":
                    shortCut = "см";
                    break;
                case "мм":
                    shortCut = "мм";
                    break;
                case "м":
                    shortCut = "м";
                    break;
                case "дм":
                    shortCut = "дм";
                    break;
            }
            if (ffButton != 0)
            {
                liceText.Clear(); liceText.Text = liceF.ToString() + shortCut + "²";
                obikolkaText.Clear(); obikolkaText.Text = obikolkaF.ToString() + shortCut;
                diameturText.Clear(); diameturText.Text = diameturF.ToString() + shortCut;
                radiusText.Clear(); radiusText.Text = radiusF.ToString() + shortCut;

                radiusLabel.Text = radiusF.ToString() + shortCut;
                diameturLabel.Text = diameturF.ToString() + shortCut;
                ffButton = 0;
            }
        }



        private void radiusText_TextChanged(object sender, EventArgs e)
        {
            radius=radiusText.Text;
            fButton = 1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            radiusText.Clear();
            diameturText.Clear();
            liceText.Clear();   
            obikolkaText.Clear();
            fButton = 0;
            radius = null; diametur = null; lice = null; obikolka = null;
            radiusF = 0; diameturF = 0; liceF = 0; obikolkaF = 0;
        }

        private void diameturText_TextChanged(object sender, EventArgs e)
        {
            diametur = diameturText.Text;
            fButton = 2;
        }

        private void liceText_TextChanged(object sender, EventArgs e)
        {
            lice = liceText.Text;
            fButton = 3;
        }

        private void obikolkaText_TextChanged(object sender, EventArgs e)
        {
            obikolka = obikolkaText.Text;
            fButton = 4;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (fButton == 0)
                return;
            switch (fButton)
            {
                case 0:
                    break;
                case 1:
                    //radius kal
                    radiusF=double.Parse(radius);
                    liceF = Math.PI * radiusF * radiusF;                 liceF = Math.Round(liceF,1);
                    obikolkaF = 2 * Math.PI * radiusF;                   obikolkaF = Math.Round(obikolkaF,1);
                    diameturF = radiusF * 2;                             diameturF = Math.Round(diameturF,1);
                    fButton = 0;
                    break; 
                
                case 2:
                    //diametur kal
                    diameturF = double.Parse(diametur);                  
                    radiusF = diameturF/2;                               radiusF = Math.Round(radiusF,1);
                    liceF = Math.PI * radiusF * radiusF;                 liceF = Math.Round(liceF, 1);
                    obikolkaF = 2 * Math.PI * radiusF;                   obikolkaF = Math.Round(obikolkaF, 1);
                    fButton = 0;
                    break; 

                case 3:
                    //lice kal
                    liceF = double.Parse(lice);
                    radiusF = liceF / Math.PI;
                    radiusF = Math.Sqrt(radiusF);                        radiusF= Math.Round(radiusF, 1);
                    obikolkaF = 2 * Math.PI * radiusF;                   obikolkaF = Math.Round(obikolkaF, 1);
                    diameturF = radiusF * 2;                             diameturF = Math.Round(diameturF, 1);
                    fButton = 0;
                    break; 

                case 4:
                    //obikolka kal
                    obikolkaF = double.Parse(obikolka);
                    radiusF = obikolkaF/(2*Math.PI);                       radiusF = Math.Round(radiusF,1);
                    liceF = Math.PI * radiusF * radiusF;                 liceF = Math.Round(liceF, 1);
                    diameturF = radiusF * 2;                             diameturF = Math.Round(diameturF, 1);
                    fButton = 0;
                    break;
            }

            liceText.Clear();                                           liceText.Text = liceF.ToString() + shortCut + "²";
            obikolkaText.Clear();                                       obikolkaText.Text = obikolkaF.ToString() + shortCut;
            diameturText.Clear();                                       diameturText.Text = diameturF.ToString() + shortCut;
            radiusText.Clear();                                         radiusText.Text = radiusF.ToString() + shortCut;

            radiusLabel.Text = radiusF.ToString() + shortCut;
            diameturLabel.Text = diameturF.ToString() + shortCut;
            fButton = 0;

            labelS1.Text = "S=3,14×" + radiusF+"²";
            labelS2.Text = "S=3,14×" + radiusF*radiusF;
            labelS3.Text = "S= "+liceText.Text;

            labelP1.Text = "P=2×3,14×" + radiusF;
            labelP2.Text = "P=2×" + Math.Round(Math.PI * radiusF,2);
            labelP3.Text = "P= "+obikolkaText.Text;

            labelD1.Text = "d=2×" + radiusF;
            labelD2.Text = "d= "+radiusText.Text;



        }
    }
}
