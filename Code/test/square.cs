using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class square : Form
    {
        public square()
        {
            InitializeComponent();
        }

        private void square_Load(object sender, EventArgs e)
        {
            rectanglePanel.Hide();
            parallelogramPanel.Hide();
        }

        private void squareBtn_Click(object sender, EventArgs e)
        {
            rectanglePanel.Hide();
            parallelogramPanel.Hide();
            paraAText.Text = "0";
            paraBText.Text = "0";
            paralAngelAText.Text = "0";
            paralAngelBText.Text = "0";
            paraLiceText.Text = "0";
            paraObikText.Text = "0";
            paraDiagAText.Text = "0";
            paraDiagBText.Text = "0";
            label18.Text = "β°";
            label35.Text = label36.Text = "β°÷2";
            label16.Text = "α°";
            label37.Text = label38.Text = "α°÷2";
            label45.Text = label44.Text = "b";
            label42.Text = label43.Text = "a";
            recDiag = 0; recA = 0; recB = 0; recLice = 0;
            recAText.Text = "0";
            recBText.Text = "0";
            recLiceText.Text = "0";
            recObikText.Text = "0";
            recDiagText.Text = "0";
            label25.Text = "α°";
            label24.Text = "β°";
            label21.Text = "β°÷2";
            label1945.Text = "α°÷2";
            label51.Text = "a";
            label52.Text = "b";
            squareSideText.Text = "0";
            squareDiagonalText.Text = "0";
            squarePText.Text = "0";
            squareLiceText.Text = "0";
            label49.Text = label50.Text = "a";
            sqA = 0; sqD = 0; sqP = 0; sqS = 0;
        }

        private void rectangleBtn_Click(object sender, EventArgs e)
        {
            rectanglePanel.Show();
            parallelogramPanel.Hide();
            paraAText.Text = "0";
            paraBText.Text = "0";
            paralAngelAText.Text = "0";
            paralAngelBText.Text = "0";
            paraLiceText.Text = "0";
            paraObikText.Text = "0";
            paraDiagAText.Text = "0";
            paraDiagBText.Text = "0";
            label18.Text = "β°";
            label35.Text = label36.Text = "β°÷2";
            label16.Text = "α°";
            label37.Text = label38.Text = "α°÷2";
            label45.Text = label44.Text = "b";
            label42.Text = label43.Text = "a";
            recDiag = 0; recA = 0; recB = 0; recLice = 0;
            recAText.Text = "0";
            recBText.Text = "0";
            recLiceText.Text = "0";
            recObikText.Text = "0";
            recDiagText.Text = "0";
            label25.Text = "α°";
            label24.Text = "β°";
            label21.Text = "β°÷2";
            label1945.Text = "α°÷2";
            label51.Text = "a";
            label52.Text = "b";
            squareSideText.Text = "0";
            squareDiagonalText.Text = "0";
            squarePText.Text = "0";
            squareLiceText.Text = "0";
            label49.Text = label50.Text = "a";
            sqA = 0; sqD = 0; sqP = 0; sqS = 0;
        }

        private void parallelogramBtn_Click(object sender, EventArgs e)
        {
            rectanglePanel.Hide();
            parallelogramPanel.Show();
            paraLiceText.Enabled= false;
            paraObikText.Enabled= false;
            paraDiagAText.Enabled = false;
            paraDiagBText.Enabled= false;
            paraAText.Text = "0";
            paraBText.Text = "0";
            paralAngelAText.Text = "0";
            paralAngelBText.Text = "0";
            paraLiceText.Text = "0";
            paraObikText.Text = "0";
            paraDiagAText.Text = "0";
            paraDiagBText.Text = "0";
            label18.Text = "β°";
            label35.Text = label36.Text = "β°÷2";
            label16.Text = "α°";
            label37.Text = label38.Text = "α°÷2";
            label45.Text = label44.Text = "b";
            label42.Text = label43.Text = "a";
            recDiag = 0; recA = 0; recB = 0; recLice = 0;
            recAText.Text = "0";
            recBText.Text = "0";
            recLiceText.Text = "0";
            recObikText.Text = "0";
            recDiagText.Text = "0";
            label25.Text = "α°";
            label24.Text = "β°";
            label21.Text = "β°÷2";
            label1945.Text = "α°÷2";
            label51.Text = "a";
            label52.Text = "b";
            squareSideText.Text = "0";
            squareDiagonalText.Text = "0";
            squarePText.Text = "0";
            squareLiceText.Text = "0";
            label49.Text = label50.Text = "a";
            sqA = 0; sqD = 0; sqP = 0; sqS = 0;
        }

        double sqS, sqA, sqD, sqP;

        private void squareCalculateBtn_Click(object sender, EventArgs e)
        {
            if (sqA<=0)
            {
                MessageBox.Show("Няма подадени данни.");
            }
            else
            {
            sqS = sqA * sqA;
            sqP = sqA * 4;
            sqD = sqA * Math.Sqrt(2);
            sqA = Math.Round(sqA, 2);
            sqS = Math.Round(sqS, 2);
            sqD = Math.Round(sqD, 2);
            sqP = Math.Round(sqP, 2);
            squareSideText.Text = sqA.ToString();
            squareDiagonalText.Text = sqD.ToString();
            squarePText.Text = sqP.ToString();
            squareLiceText.Text = sqS.ToString();
            label49.Text=label50.Text=sqA.ToString();
            }
        }

        private void squareSideText_TextChanged(object sender, EventArgs e)
        {
            sqA = double.Parse(squareSideText.Text);
        }

        private void squareDelBtn_Click(object sender, EventArgs e)
        {
            squareSideText.Text="0";
            squareDiagonalText.Text = "0";
            squarePText.Text = "0";
            squareLiceText.Text = "0";
            label49.Text = label50.Text="a";
            sqA = 0;sqD = 0;sqP = 0; sqS = 0;
        }
        double recDiag, recA, recB, recLice, recObik,recAngelA,recAngelB;

        private void recDelBtn_Click(object sender, EventArgs e)
        {
            recDiag = 0;recA = 0;recB = 0; recLice = 0;
            recAText.Text = "0";
            recBText.Text = "0";
            recLiceText.Text = "0";
            recObikText.Text = "0";  
            recDiagText.Text = "0";
            label25.Text = "α°";
            label24.Text = "β°";
            label21.Text = "β°÷2";
            label1945.Text = "α°÷2";
            label51.Text = "a";
            label52.Text = "b";
        }
        double paraA, paraB, paraLice, paraDiagA, paraObik, paraDiagB, paraAngelA,paraAngelB;
        private void parraCalculateBtn_Click(object sender, EventArgs e)
        {
                    if (paraAngelA <= 0)
                    {
                        paraAngelA = 180 - paraAngelB;
                    }
                    else
                    {
                        paraAngelB = 180 - paraAngelA;
                    }
                    paraLice = paraA * paraB * Math.Sin(paraAngelA * Math.PI / 180);
                    paraObik = paraA + paraA + paraB + paraB;
                    paraDiagB = (paraB * paraB) + (paraA * paraA) - 2 * paraA * paraB * Math.Cos(paraAngelB * Math.PI / 180);
                    paraDiagB = Math.Sqrt(paraDiagB);
                    paraDiagA =paraA*paraA+paraB*paraB-2*paraB*paraA*Math.Cos(paraAngelA*Math.PI/180);
                    paraDiagA =Math.Sqrt(paraDiagA);


            paraA=Math.Round(paraA,2);
            paraB = Math.Round(paraB, 2);
            paraAngelA = Math.Round(paraAngelA, 2);
            paraAngelB = Math.Round(paraAngelB, 2);
            paraLice = Math.Round(paraLice, 2);
            paraObik= Math.Round(paraObik, 2);
            paraDiagA = Math.Round(paraDiagA, 2);
            paraDiagB = Math.Round(paraDiagB, 2);

            if(paraA<=0||paraB<=0 ||paraAngelA<=0||paraAngelB<=0||paraLice<=0 ||paraObik<=0||paraDiagA<=0||paraDiagB<=0)
            {
                MessageBox.Show("Грешно подадени данни.");
            }
            else
            {
                paraAText.Text = paraA.ToString();
                paraBText.Text = paraB.ToString();
                paralAngelAText.Text = paraAngelA.ToString() ;
                paralAngelBText.Text = paraAngelB.ToString() ;
                paraLiceText.Text = paraLice.ToString() ;
                paraObikText.Text = paraObik.ToString();
                paraDiagAText.Text = paraDiagA.ToString();
                paraDiagBText.Text = paraDiagB.ToString();
                label18.Text =(paraAngelB + "°").ToString() ;
                label35.Text = label36.Text = (paraAngelB / 2)+"°".ToString();
                label16.Text = (paraAngelA + "°").ToString() ;
                label37.Text = label38.Text = (paraAngelA / 2)+"°".ToString();
                label45.Text = label44.Text = paraB.ToString();
                label42.Text = label43.Text = paraA.ToString();

            }
        }

        private void paraAText_TextChanged(object sender, EventArgs e)
        {
            paraA = double.Parse(paraAText.Text);
        }

        private void parallelogramPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void paralAngelBText_TextChanged(object sender, EventArgs e)
        {
            paraAngelB = double.Parse(paralAngelBText.Text);
        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void paraAText_KeyPress(object sender, KeyPressEventArgs e)
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

        private void paraBText_KeyPress(object sender, KeyPressEventArgs e)
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

        private void paralAngelAText_KeyPress(object sender, KeyPressEventArgs e)
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

        private void paralAngelBText_KeyPress(object sender, KeyPressEventArgs e)
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

        private void recAText_KeyPress(object sender, KeyPressEventArgs e)
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

        private void recBText_KeyPress(object sender, KeyPressEventArgs e)
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

        private void recLiceText_KeyPress(object sender, KeyPressEventArgs e)
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

        private void recObikText_KeyPress(object sender, KeyPressEventArgs e)
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

        private void recDiagText_KeyPress(object sender, KeyPressEventArgs e)
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

        private void squareSideText_KeyPress(object sender, KeyPressEventArgs e)
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

        private void squareDiagonalText_KeyPress(object sender, KeyPressEventArgs e)
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

        private void squarePText_KeyPress(object sender, KeyPressEventArgs e)
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

        private void squareLiceText_KeyPress(object sender, KeyPressEventArgs e)
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

        private void paralAngelAText_TextChanged(object sender, EventArgs e)
        {
            paraAngelA = double.Parse(paralAngelAText.Text);
        }

        private void parralDelBtn_Click(object sender, EventArgs e)
        {
            paraAText.Text = "0";
            paraBText.Text = "0";
            paralAngelAText.Text = "0";
            paralAngelBText.Text = "0";   
            paraLiceText.Text = "0";
            paraObikText.Text = "0";
            paraDiagAText.Text = "0";
            paraDiagBText.Text = "0";
            label18.Text = "β°";
            label35.Text = label36.Text = "β°÷2";
            label16.Text = "α°";
            label37.Text = label38.Text = "α°÷2";
            label45.Text = label44.Text = "b";
            label42.Text = label43.Text = "a";
        }


        private void paraBText_TextChanged(object sender, EventArgs e)
        {
            paraB = double.Parse(paraBText.Text);
        }

        private void paraLiceText_TextChanged(object sender, EventArgs e)
        {
            paraLice = double.Parse(paraLiceText.Text);
        }

        private void paraObikText_TextChanged(object sender, EventArgs e)
        {
            paraObik = double.Parse(paraObikText.Text);
        }

        private void paraDiagAText_TextChanged(object sender, EventArgs e)
        {
            paraDiagA = double.Parse(paraDiagAText.Text);
        }

        private void paraDiagBText_TextChanged(object sender, EventArgs e)
        {
            paraDiagB = double.Parse(paraDiagBText.Text);
        }

        private void recDiagText_TextChanged(object sender, EventArgs e)
        {
            recDiag = double.Parse(recDiagText.Text);
        }
        
        private void recCalculateBtn_Click(object sender, EventArgs e)
        {
            if (recA > 0 && recB > 0)
            {
                recLice = recA * recB;
                recObik = 2 * (recA + recB);
                recDiag = Math.Sqrt(recA * recA + recB * recB);
            }
            else if (recA > 0 || recB > 0)
            {
                double switchRec = 0;
                if (recB > recA)
                {
                    switchRec = 1;
                    recA = recB;
                }
                if (recLice > 0)
                {
                    recB = recLice / recA;
                }
                else if (recObik > 0)
                {
                    recB = (recObik - 2 * recA) / 2;
                }
                else if (recDiag > 0)
                {
                    recB = Math.Sqrt(recDiag * recDiag - recA * recA);
                }
                if (switchRec == 1)
                {
                    switchRec = recA;
                    recA = recB;
                    recB = switchRec;
                }
            }
            else if (recDiag > 0 && recLice > 0)
            {
                recA = Math.Sqrt((recDiag*recDiag+Math.Sqrt(recDiag * recDiag * recDiag * recDiag -4*(recLice*recLice)))/2);
                recB = recLice/recA;
            }
            else if (recDiag > 0 && recObik > 0)
            {
                recA = (recObik + Math.Sqrt(-recObik*recObik+8*(recDiag*recDiag)))/4;
                recB = (recObik - 2 * recA)/2;
            }
            else if (recLice > 0 && recObik > 0)
            {
                recA = (recObik + Math.Sqrt(recObik * recObik-16*recLice))/4;
                recB = recLice/recA;
            }
            if (recA > 0 && recB > 0)
            {
                recLice = recA * recB;
                recObik = 2 * (recA + recB);
                recDiag = Math.Sqrt(recA * recA + recB * recB);
                recAngelA = ((recDiag/2) * (recDiag / 2)) + ((recDiag / 2) * (recDiag / 2)) - (recA * recA);
                recAngelA /= (2 * (recDiag/2) * (recDiag/2));
                recAngelA = Math.Acos(recAngelA);
                recAngelA *= (180 / Math.PI);
                recAngelB = 180-recAngelA;
                recAngelA = Math.Round(recAngelA, 1);
                recAngelB = Math.Round(recAngelB, 1);
                recA = Math.Round(recA, 2);
                recB = Math.Round(recB, 2);
                recLice = Math.Round(recLice, 2);
                recObik = Math.Round(recObik, 2);
                recDiag = Math.Round(recDiag, 2);
            }

            if (recA <= 0 || recB <= 0 || recLice <= 0 || recObik <= 0 || recDiag <= 0)
            {
                MessageBox.Show("Грешно подадена информация или самият правоъгълник не е реален.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                recDiag = 0; recA = 0; recB = 0; recLice = 0;
                recAText.Text = "0";
                recBText.Text = "0";
                recLiceText.Text = "0";
                recObikText.Text = "0";
                recDiagText.Text = "0";
                label25.Text = "α°";
                label24.Text = "β°";
                label21.Text = "β°÷2";
                label1945.Text = "α°÷2";
            }
            else
            {
                recAText.Text = label51.Text = recA.ToString();
                recBText.Text = label52.Text = recB.ToString();
                recLiceText.Text = recLice.ToString();
                recObikText.Text = recObik.ToString();
                recDiagText.Text = recDiag.ToString();
                label25.Text = recAngelA.ToString() + "°";
                label24.Text = recAngelB.ToString() + "°";
                label21.Text = (recAngelB / 2).ToString() + "°";
                label1945.Text = (recAngelA / 2).ToString() + "°";
            }
        }

        private void recAText_TextChanged(object sender, EventArgs e)
        {
            recA = double.Parse(recAText.Text);
        }

        private void recBText_TextChanged(object sender, EventArgs e)
        {
            recB = double.Parse(recBText.Text);
        }

        private void recLiceText_TextChanged(object sender, EventArgs e)
        {
            recLice = double.Parse(recLiceText.Text);
        }

        private void recObikText_TextChanged(object sender, EventArgs e)
        {
            recObik = double.Parse(recObikText.Text);
        }

        private void squareDiagonalText_TextChanged(object sender, EventArgs e)
        {
            sqD = double.Parse(squareDiagonalText.Text);
            sqA = sqD / Math.Sqrt(2);
        }

        private void squarePText_TextChanged(object sender, EventArgs e)
        {
            sqP = double.Parse(squarePText.Text);
            sqA = sqP / 4;
        }

        private void squareLiceText_TextChanged(object sender, EventArgs e)
        {
            sqS = double.Parse(squareLiceText.Text);
            sqA = Math.Sqrt(sqS);
        }
    }
} 
