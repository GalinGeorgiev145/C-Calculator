using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class triangle : Form
    {
        public triangle()
        {
            InitializeComponent();
            btnDelete.Hide();
            panel2.Hide();
        }

        double sideA, sideB, sideC, angelA, angelB, angelC,formula;
        string txtA, txtB, txtC, txtAA, txtBB, txtCC;

        private void textSideA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
            if((e.KeyChar==',')&&((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled= true;
            }
        }

        private void textSideB_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textSideC_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textAgnelGreen_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textAgnelBlue_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textAgnelRed_KeyPress(object sender, KeyPressEventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void triangle_Load(object sender, EventArgs e)
        {
        }

        double sinAngelA,sinAngelB,sinAngelC;
        int[,] res = {{ 0, 0, 0 },{ 0 , 0 ,0 }};

        //      0,0 = side A       1,0 = angel A
        //      0,1 = side B       1,1 = angel B
        //      0,2 = side C       1,2 = angel C

        private void btnDelete_Click(object sender, EventArgs e)
        {
            textAgnelBlue.Text = "0";
            textAgnelGreen.Text = "0";
            textAgnelRed.Text = "0";
            textSideA.Text = "0";
            textSideB.Text = "0";
            textSideC.Text = "0";
            sideA = sideB = sideC = angelA = angelB = angelC = formula = 0;
            res[0, 0] = 0;
            res[0, 1] = 0;
            res[0, 2] = 0;
            res[1, 0] = 0;
            res[1, 1] = 0;
            res[1, 2] = 0;
            btnCalculate.Show();
            btnDelete.Hide();
            panel2.Hide();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (res[0,2]==1&& res[1,1] == 1&&res[1,0] == 1)
            {//C b a
                angelC = 180 - (angelB + angelA);
                sinAngelC = Math.Sin(angelC * Math.PI / 180);
                formula = 2;
            }
            else if (res[0,2] == 1 && res[1,1] == 1 && res[1,2] == 1)
            {//C b c
                angelA = 180 - (angelB + angelC);
                sinAngelA = Math.Sin(angelA * Math.PI / 180);
                formula = 2;
            }
            else if(res[0, 2] == 1 && res[1, 2] == 1 && res[1, 0] == 1)
            {//C c a
                angelB = 180 - (angelA + angelC);
                sinAngelB = Math.Sin(angelB * Math.PI / 180);
                formula = 2;
            }
            else if(res[0, 1] == 1 && res[1, 1] == 1 && res[1, 0] == 1)
            {//B b a
                angelC = 180 - (angelB + angelA);
                sinAngelC = Math.Sin(angelC * Math.PI / 180);
                formula =3;
            }
            else if (res[0, 1] == 1 && res[1, 1] == 1 && res[1, 2] == 1)
            {//B b c 
                angelA = 180 - (angelB + angelC);
                sinAngelA = Math.Sin(angelA * Math.PI / 180);
                formula = 3;
            }
            else if(res[0, 1] == 1 && res[1, 2] == 1 && res[1, 0] == 1)
            {//B c a 
                angelB = 180 - (angelA + angelC);
                sinAngelB = Math.Sin(angelB * Math.PI / 180);
                formula = 3;
            }
            else if (res[0, 0] == 1 && res[1, 1] == 1 && res[1, 0] == 1)
            {//A b a 
                angelC = 180 - (angelB + angelA);
                sinAngelC = Math.Sin(angelC * Math.PI / 180);
                formula =1;
            }
            else if (res[0, 0] == 1 && res[1, 1] == 1 && res[1, 2] == 1)
            {//A b c 
                angelA = 180 - (angelB + angelC);
                sinAngelA = Math.Sin(angelA * Math.PI / 180);
                formula = 1;
            }
            else if (res[0, 0] == 1 && res[1, 2] == 1 && res[1, 0] == 1)
            {//A c a 
                angelB = 180 - (angelA + angelC);
                sinAngelB = Math.Sin(angelB * Math.PI / 180);
                formula = 1;
            }
            else if (res[0, 1] == 1 && res[0, 2] == 1 && res[1,0]==1)
            {//B C a 
                sideA = (sideC * sideC) + (sideB * sideB) - 2 * sideB * sideC * Math.Cos(angelA * Math.PI / 180);
                sideA = Math.Sqrt(sideA);
                angelB = (sideA * sideA) + (sideC * sideC) - (sideB * sideB);
                angelB /= (2 * sideC * sideA);
                angelB = Math.Acos(angelB);
                angelB *= (180 / Math.PI);
                angelC = 180 - (angelA + angelB);
            }
            else if (res[0, 1] == 1 && res[0, 2] == 1 && res[1, 1] == 1)
            {//B C b
                angelC = sinAngelB * sideC;
                angelC /= sideB;
                angelC = Math.Asin(angelC);
                angelC = angelC * (180 / Math.PI);
                angelA = 180 - (angelC + angelB);
                sinAngelA = Math.Sin(angelA * Math.PI / 180);
                sideA = sinAngelA * sideB;
                sideA /= sinAngelB;
            }
            else if (res[0, 1] == 1 && res[0, 2] == 1 && res[1, 2] == 1)
            {//B C c 
                angelB = sinAngelC * sideB;
                angelB /= sideC;
                angelB = Math.Asin(angelB);
                angelB = angelB * (180 / Math.PI);
                sinAngelB = Math.Sin(angelB * Math.PI / 180);
                angelA = 180 - (angelB + angelC);
                sinAngelA = Math.Sin(angelA * Math.PI / 180);
                sideA = sinAngelA * sideB;
                sideA /= sinAngelB;
            }
            else if(res[0, 0] == 1 && res[0, 2] == 1 && res[1, 0] == 1)
            {//A C a
                angelC = sinAngelA * sideC;
                angelC /= sideA;
                angelC = Math.Asin(angelC);
                angelC = angelC * (180 / Math.PI);
                sinAngelC = Math.Sin(angelC * Math.PI / 180);
                angelB = 180 - (angelA + angelC);
                sinAngelB = Math.Sin(angelB * Math.PI / 180);
                sideB = (sinAngelB * sideC);
                sideB /= sinAngelC;
            }
            else if(res[0, 0] == 1 && res[0, 2] == 1 && res[1, 1] == 1)
            {//A C b
                sideB = (sideC * sideC) + (sideA * sideA) - 2 * sideA * sideC * Math.Cos(angelB * Math.PI / 180);
                sideB = Math.Sqrt(sideB);
                angelA = (sideB * sideB) + (sideC * sideC) - (sideA * sideA);
                angelA /= (2 * sideB * sideC);
                angelA = Math.Acos(angelA);
                angelA *= (180 / Math.PI);
                angelC = 180 - (angelA + angelB);
            }
            else if (res[0, 0] == 1 && res[0, 2] == 1 && res[1, 2] == 1)
            {//A C c
                angelA = sinAngelC * sideA;
                angelA /= sideC;
                angelA = Math.Asin(angelA);
                angelA = angelA * (180 / Math.PI);
                angelB = 180 - (angelA + angelC);
                sinAngelB = Math.Sin(angelB * Math.PI / 180);
                sideB = (sinAngelB * sideC);
                sideB /= sinAngelC;
            }
            else if (res[0, 1] == 1 && res[0, 0] == 1 && res[1, 0] == 1)
            {//B A a
                angelB = sinAngelA * sideB;
                angelB /= sideA;
                angelB = Math.Asin(angelB);
                angelB = angelB * (180 / Math.PI);
                angelC = 180 - (angelB + angelA);
                sinAngelB = Math.Sin(angelB * Math.PI / 180);
                sinAngelC = Math.Sin(angelC * Math.PI / 180);
                sideC = (sinAngelC * sideB) / sinAngelB;
            }
            else if (res[0, 1] == 1 && res[0, 0] == 1 && res[1, 1] == 1)
            {//B A b
                angelA = sinAngelB * sideA;
                angelA /= sideB;
                angelA = Math.Asin(angelA);
                angelA = angelA * (180 / Math.PI);
                angelC = 180 - (angelA + angelB);
                sinAngelB = Math.Sin(angelB * Math.PI / 180);
                sinAngelC = Math.Sin(angelC * Math.PI / 180);
                sideC = (sinAngelC * sideB);
                sideC /= sinAngelB;
            }
            else if (res[0, 1] == 1 && res[0, 0] == 1 && res[1, 2] == 1)
            {//B A c
                sideC = (sideB * sideB) + (sideA * sideA) - 2 * sideA * sideB * Math.Cos(angelC * Math.PI / 180);
                sideC = Math.Sqrt(sideC);
                angelA = (sideB * sideB) + (sideC * sideC) - (sideA * sideA);
                angelA /= (2 * sideB * sideC);
                angelA = Math.Acos(angelA);
                angelA *= (180 / Math.PI);
                angelB = 180 - (angelA + angelC);
            }
            else if (res[0,0] == 1 && res[0,1] == 1 && res[0,2] == 1)
            {//    A B C sides
                angelA = (sideB * sideB) + (sideC * sideC) - (sideA * sideA);
                angelA /= 2 * sideB * sideC;
                angelA = Math.Acos(angelA);
                angelA *= (180 / Math.PI);

                angelB = (sideA * sideA) + (sideC * sideC) - (sideB * sideB);
                angelB /= 2 * sideA * sideC;
                angelB = Math.Acos(angelB);
                angelB *= (180 / Math.PI);

                angelC = (sideB * sideB) + (sideA * sideA) - (sideC * sideC);
                angelC /= 2 * sideB * sideA;
                angelC = Math.Acos(angelC);
                angelC *= (180 / Math.PI);
            }

            if (formula == 2)
            {
                sideB = (sinAngelB * sideC);
                sideB /= sinAngelC; 
                sideA = (sinAngelA * sideC) / sinAngelC; 
            }
            else if (formula == 3)
            {
                 sideC = sinAngelC * sideB; 
                 sideC /= sinAngelB;
                 sideA = sinAngelA * sideC; 
                 sideA /= sinAngelC;
            }
            else if (formula == 1)
            {
                sideB = sinAngelB * sideA;
                sideB /= sinAngelA;
                sideC = sinAngelC * sideA ;
                sideC /= sinAngelA;
            }



            if (sideA > sideB + sideC || sideB > sideA + sideC || sideC > sideA + sideB||sideA==0||sideB==0||sideC==0||angelA==0||angelB==0||angelC==0)
            {
                MessageBox.Show("Този триъгълник е нереален, моля въведете нови стойности", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textAgnelBlue.Text = "0";
                textAgnelGreen.Text = "0";
                textAgnelRed.Text = "0";
                textSideA.Text = "0";
                textSideB.Text = "0";
                textSideC.Text = "0";
                sideA = sideB = sideC = angelA = angelB = angelC = formula = 0;
                res[0, 0] = 0;
                res[0, 1] = 0;
                res[0, 2] = 0;
                res[1, 0] = 0;
                res[1, 1] = 0;
                res[1, 2] = 0;
            }
            else if (res[0, 0] == 0 && res[0, 1] == 0&&res[0, 2] == 0 && res[1, 0] == 1&& res[1, 1] == 1 && res[1, 2] == 1)
            {
                MessageBox.Show("Моля въведете само две страни и един ъгъл, една страна и два ъгъла, или само 3 страни.","Грешка");
                textAgnelBlue.Text = "0";
                textAgnelGreen.Text = "0";
                textAgnelRed.Text = "0";
                textSideA.Text = "0";
                textSideB.Text = "0";
                textSideC.Text = "0";
                sideA = sideB = sideC = angelA = angelB = angelC = formula = 0;
                res[0, 0] = 0;
                res[0, 1] = 0;
                res[0, 2] = 0;
                res[1, 0] = 0;
                res[1, 1] = 0;
                res[1, 2] = 0;
            }
            else
            {
                double pT = (sideA+sideC+sideB)/2;
                double arayTr = Math.Sqrt(pT * (pT - sideA) * (pT - sideB) * (pT - sideC));
                pT = Math.Round(pT, 2);
                arayTr = Math.Round(arayTr, 2);
                pT = pT * 2;
                angelA = Math.Round(angelA, 2,MidpointRounding.ToEven);
                angelB = Math.Round(angelB, 2, MidpointRounding.ToEven);
                angelC = Math.Round(angelC, 2, MidpointRounding.ToEven);
                sideA = Math.Round(sideA, 2, MidpointRounding.ToEven);
                sideB = Math.Round(sideB, 2, MidpointRounding.ToEven);
                sideC = Math.Round(sideC, 2, MidpointRounding.ToEven);

                textAgnelBlue.Text = angelA.ToString();
                textAgnelGreen.Text = angelC.ToString();
                textAgnelRed.Text = angelB.ToString();
                textSideA.Text = sideA.ToString();
                textSideB.Text = sideB.ToString();
                textSideC.Text = sideC.ToString();
                finalRes.Text = $"Side A = {sideA}\nSide B = {sideB}\nSide C = {sideC} \n∡ A = {angelA}°\n∡ B = {angelB}°\n∡ C = {angelC}°\nP = {pT}\nS = {arayTr}²";
                btnCalculate.Hide();
                btnDelete.Show();
                panel2.Show();
            }
        }
        private void textAgnelBlue_TextChanged(object sender, EventArgs e)
        {
            txtAA = textAgnelBlue.Text;
            angelA = double.Parse(txtAA);
            sinAngelA = Math.Sin(angelA * Math.PI / 180);
            res[1, 0] = 1;
            
        }

        private void textAgnelGreen_TextChanged(object sender, EventArgs e)
        {
            txtCC = textAgnelGreen.Text;
            angelC = double.Parse(txtCC);
            sinAngelC = Math.Sin(angelC * Math.PI / 180);
            res[1, 2] = 1;
        }

        private void textAgnelRed_TextChanged(object sender, EventArgs e)
        {
            txtBB = textAgnelRed.Text;
            angelB = double.Parse(txtBB);
            sinAngelB = Math.Sin(angelB * Math.PI / 180);
            res[1, 1] = 1;
        }
        private void textSideC_TextChanged(object sender, EventArgs e)
        {
            txtC = textSideC.Text;
            sideC = double.Parse(txtC);
            res[0, 2] = 1;
        }

        private void textSideB_TextChanged(object sender, EventArgs e)
        {
            txtB = textSideB.Text;
            sideB = double.Parse(txtB);
            res[0, 1] = 1;
        }

        private void textSideA_TextChanged(object sender, EventArgs e)
        {
            txtA=textSideA.Text;
            sideA=double.Parse(txtA);
            res[0, 0] = 1;
        }
    }
}
