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
    public partial class math : Form
    {
        public math()
        {
            InitializeComponent();
        }

        private void math_Load(object sender, EventArgs e)
        {
            checkBox2.Checked = true;
            checkBox2.BackColor = SystemColors.ScrollBar;
            comboBox1.Text = "sin";
            comboBox2.Text = "+";
            comboBox3.Text = "+";
            panel1.Hide();
            kybResult.Enabled = false;
            textBox1.Enabled = false;
        }
        string radOrDegree;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                checkBox2.Checked = false;
                checkBox1.BackColor = SystemColors.ScrollBar;
                radOrDegree = "Radius";
                checkBox2.BackColor = Color.White;
            }
            else
            {
                checkBox1.Checked = false;
                checkBox2.Checked= true;
                checkBox2.BackColor = SystemColors.ScrollBar;
                radOrDegree = "Degree"; 
                checkBox1.BackColor = Color.White;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.BackColor = SystemColors.ScrollBar;
                radOrDegree = "Degree";
                checkBox1.BackColor = Color.White;
            }
            else
            {
                checkBox2.Checked = false;
                checkBox1.Checked = true;
                checkBox1.BackColor = SystemColors.ScrollBar;
                radOrDegree = "Radius";
                checkBox2.BackColor = Color.White;
            }
        }
        int formSinOr;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "sin":
                    formSinOr = 1;
                    break;

                case "sin-1":
                    formSinOr = 10;
                    break;

                case "cos":
                    formSinOr = 2;
                    break;

                case "cos-1":
                    formSinOr = 20;
                    break;

                case "tan":
                    formSinOr = 3;
                    break;

                case "tan-1":
                    formSinOr = 30;
                    break;
            }
        }

        private void btnCalculateSinCos_Click(object sender, EventArgs e)
        {
            if (radOrDegree == "Degree")
            {
                SinRes = sinOr;
                SinRes *= Math.PI / 180;
            }
            else
                SinRes = sinOr;
            switch (formSinOr)
            {
                case 1:
                    SinRes = Math.Sin(SinRes);
                    break;

                case 10:
                    SinRes = Math.Asin(SinRes);
                    break;

                case 2:
                    SinRes = Math.Cos(SinRes);
                    break;

                case 20:
                    SinRes = Math.Acos(SinRes);
                    break;

                case 3:
                    SinRes = Math.Tan(SinRes);
                    break;  

                case 30:
                    SinRes = Math.Atan(SinRes);
                    break;
            }
            SinRes = Math.Round(SinRes, 3);
            textBox1.Text = SinRes.ToString(); 
        }
        double sinOr,SinRes;
        double kvA,kvB,kvC,kvD,xOne,xTwo;
        double logAInput, logBInput, logXInput=0;
        private void logA_TextChanged(object sender, EventArgs e)
        {
            logAInput = double.Parse(logA.Text);
        }

        private void logBtnCalculate_Click(object sender, EventArgs e)
        {
            if (logBInput!=0&&logAInput!=0)
            {
                logXInput = Math.Log(logBInput,logAInput);
            }
            else if (logAInput!=0&&logXInput!=0)
            {
                logBInput = Math.Pow(logAInput,logXInput);
            }
            else if (logBInput != 0 && logXInput != 0)
            {
                logAInput = Math.Pow(logBInput,(1/logXInput));
            }
            if (double.IsNaN(logAInput) || double.IsNaN(logBInput) || double.IsNaN(logXInput))
            {
                MessageBox.Show("Грешно подадена информация.");
            }
            else
            {
                logA.Text = logAInput.ToString();
                logX.Text = logXInput.ToString();
                logB.Text = logBInput.ToString();
            }
        }
        double kobY, kobX, kobZ;

        private void kybX_TextChanged(object sender, EventArgs e)
        {
            kobX = double.Parse(kybX.Text);
            kybXX.Text = kybX.Text;
        }

        private void kybXX_TextChanged(object sender, EventArgs e)
        {
            kobX = double.Parse(kybXX.Text);
            kybX.Text = kybXX.Text;
        }

        private void kybYY_TextChanged(object sender, EventArgs e)
        {
            kobY = double.Parse(kybYY.Text);
            kybY.Text = kybYY.Text;
        }

        private void kybZZ_TextChanged(object sender, EventArgs e)
        {
            kobZ = double.Parse(kybZZ.Text);
            kybZ.Text = kybZZ.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kybResult.Text = (kobX*kobY*kobZ).ToString();
        }

        private void kybDel_Click(object sender, EventArgs e)
        {
            kobX = kobY = kobZ = 0;
            kybZZ.Text = kybZ.Text = kybY.Text = kybYY.Text = kybX.Text=kybXX.Text="0";
        }

        private void textA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textB_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textC_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textSinOr_KeyPress(object sender, KeyPressEventArgs e)
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

        private void logB_KeyPress(object sender, KeyPressEventArgs e)
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

        private void logA_KeyPress(object sender, KeyPressEventArgs e)
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

        private void logX_KeyPress(object sender, KeyPressEventArgs e)
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

        private void kybY_KeyPress(object sender, KeyPressEventArgs e)
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

        private void kybZ_KeyPress(object sender, KeyPressEventArgs e)
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

        private void kybX_KeyPress(object sender, KeyPressEventArgs e)
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

        private void kybXX_KeyPress(object sender, KeyPressEventArgs e)
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

        private void kybYY_KeyPress(object sender, KeyPressEventArgs e)
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

        private void kybZZ_KeyPress(object sender, KeyPressEventArgs e)
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

        private void kybZ_TextChanged(object sender, EventArgs e)
        {
            kobZ = double.Parse(kybZ.Text);
            kybZZ.Text = kybZ.Text;
        }

        private void kybY_TextChanged(object sender, EventArgs e)
        {
            kobY = double.Parse(kybY.Text);
            kybYY.Text = kybY.Text;
        }


        private void logB_TextChanged(object sender, EventArgs e)
        {
            logBInput = double.Parse(logB.Text);

        }

        private void logX_TextChanged(object sender, EventArgs e)
        {
            logXInput = double.Parse(logX.Text);
        }

        private void btnKvDel_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            kvA = kvB = kvC = 0;
            textA.Text = textB.Text = textC.Text = "0";
            comboBox2.Text = comboBox3.Text = "+";
        }

        private void btnCalYrav_Click(object sender, EventArgs e)
        {
            if (kvA != 0 && kvB != 0 && kvC != 0)
            {
                if (comboBox2.Text == "-")
                {
                    kvB *= (-1);
                }
                if (comboBox3.Text == "-")
                {
                    kvC *= (-1);
                }
                kvD = kvB * kvB - 4 * kvA * kvC;
                if (kvD < 0)
                {
                    MessageBox.Show("Няма реални корени.");
                }
                else if (kvD == 0)
                {
                    kvB *= (-1);
                    xOne = (kvB + Math.Sqrt(kvD)) / (2 * kvA);
                    xOne = Math.Round(xOne);
                    kvD = Math.Round(kvD);
                    panel1.Height = 90;
                    panel1.Show();
                    label5.Text = "D = " + kvD;
                    label6.Text = "x₁,₂ = " + xOne;
                }
                else
                {
                    kvB *= (-1);
                    xOne = (kvB + Math.Sqrt(kvD)) / (2 * kvA);
                    xTwo = (kvB - Math.Sqrt(kvD)) / (2 * kvA);
                    xOne = Math.Round(xOne);
                    xTwo = Math.Round(xTwo);
                    kvD = Math.Round(kvD);
                    panel1.Height = 126;
                    panel1.Show();
                    label5.Text = "D = " + kvD;
                    label6.Text = "x₁ = " + xOne;
                    label7.Text = "x₂ = " + xTwo;
                }

            }
            else
                MessageBox.Show("Пропуснали сте информация при попълването.");
        }

        private void textA_TextChanged(object sender, EventArgs e)
        {
            kvA = double.Parse(textA.Text);
        }

        private void textB_TextChanged(object sender, EventArgs e)
        {
            kvB = double.Parse(textB.Text);
        }

        private void textC_TextChanged(object sender, EventArgs e)
        {
            kvC = double.Parse(textC.Text);
        }

        private void textSinOr_TextChanged(object sender, EventArgs e)
        {
            sinOr = Double.Parse(textSinOr.Text);
        }
    }
}
