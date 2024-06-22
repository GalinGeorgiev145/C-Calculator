using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            Form f = Form as Form;
            f.Show();
        }
        double num1;
        double num2;
        double num3;
        double num4;
        string symbol;
        String option;
        double result;

        private void button1_Click(object sender, EventArgs e)
        {
            if(notesCal.Text.Length>0)
            if (MessageBox.Show("Сигурни ли сте, че искате да изтриете бележките си?", "Изтриване", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                notesCal.Clear();
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDisplay.Text)) { }

            else if (int.Parse(textDisplay.Text) <= 0)
                textDisplay.Clear();
            textDisplay.Text = textDisplay.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDisplay.Text)) { }

            else if (int.Parse(textDisplay.Text) <= 0)
                textDisplay.Clear();
            textDisplay.Text = textDisplay.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDisplay.Text)) { }

            else if (int.Parse(textDisplay.Text) <= 0)
                textDisplay.Clear();
            textDisplay.Text = textDisplay.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDisplay.Text)) { }

            else if (int.Parse(textDisplay.Text) <= 0)
                textDisplay.Clear();
            textDisplay.Text = textDisplay.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDisplay.Text)) { }

            else if (int.Parse(textDisplay.Text) <= 0)
                textDisplay.Clear();
            textDisplay.Text = textDisplay.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDisplay.Text)) { }

            else if (int.Parse(textDisplay.Text) <= 0)
                textDisplay.Clear();
            textDisplay.Text = textDisplay.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDisplay.Text)) { }

            else if (int.Parse(textDisplay.Text) <= 0)
                textDisplay.Clear();
            textDisplay.Text = textDisplay.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDisplay.Text)) { }

            else if (int.Parse(textDisplay.Text) <= 0)
                textDisplay.Clear();
            textDisplay.Text = textDisplay.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDisplay.Text)) { }

            else if (int.Parse(textDisplay.Text) <= 0)
                textDisplay.Clear();
            textDisplay.Text = textDisplay.Text + "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textDisplay.Text)) { }

            else if (int.Parse(textDisplay.Text) <= 0)
                textDisplay.Clear();
            textDisplay.Text = textDisplay.Text + "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            
            option = symbol = "+";
            num1 =num3 = double.Parse(textDisplay.Text);
            textDisplay.Clear();
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {

            option = symbol = "-";
            num1 = num3 = double.Parse(textDisplay.Text);
            textDisplay.Clear();
        }

        private void buttonMutiply_Click(object sender, EventArgs e)
        {

            option = symbol = "*";
            num1 = num3 = double.Parse(textDisplay.Text);
            textDisplay.Clear();
        }

        private void buttonDevide_Click(object sender, EventArgs e)
        {

            option = symbol="/";
            num1 = num3 = double.Parse(textDisplay.Text);
            textDisplay.Clear();
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            num2=num4= double.Parse(textDisplay.Text);
            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;
            textDisplay.Text= Math.Round(result, 2) + "" ;

            if (string.IsNullOrEmpty(textDisplay.Text))
                return;
            //num3 + symbol + num4 + "= " + textDisplay.Text
            listBox1.Items.Add(num3 + symbol + num4 + "= " + Math.Round(result,2));

        }

        private void buttonBackSpace_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Length > 0)
                textDisplay.Text = textDisplay.Text.Remove(textDisplay.Text.Length - 1, 1);
        }

        private void buttonHis_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                if (MessageBox.Show("Сигурни ли сте, че искате да изтриете историята си?", "Изтриване", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    listBox1.Items.Clear();
                }
            }
            else
                return;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            if (panelCal.Visible == false)
            {
                panelCal.Visible = true;
            }
            else 
                panelCal.Visible = false;
                
        }
    }
}
