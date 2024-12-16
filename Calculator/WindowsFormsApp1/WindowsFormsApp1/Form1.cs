using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        float num1 = 0;
        float num2 = 0;
        float answer = 0;
        string ans = "";
        string memory = "";
        bool oppress = false;
        string op = "";
        bool dotpress = false;


        public Calculator()
        {
            InitializeComponent();
        }

        private void TXTdisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void BTN7_Click(object sender, EventArgs e)
        {
            if (TXTdisplay.Text == "0")
            {
                TXTdisplay.Clear();
                TXTdisplay.SelectedText = "7";
                oppress = false;
            }
            else
            {
                TXTdisplay.SelectedText = "7";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Made By Bill Barg 2020");
        }

        private void BTNclear_Click(object sender, EventArgs e)
        {
            TXTdisplay.Clear();
        }

        private void BTN8_Click(object sender, EventArgs e)
        {
            if (TXTdisplay.Text == "0" | oppress == true)
            {
                TXTdisplay.Clear();
                TXTdisplay.SelectedText = "8";
                oppress = false;
            }
            else
            {
                TXTdisplay.SelectedText = "8";
            }
        }

        private void BTN9_Click(object sender, EventArgs e)
        {
            if (TXTdisplay.Text == "0"|oppress == true)
            {
                TXTdisplay.Clear();
                TXTdisplay.SelectedText = "9";
                oppress = false;
            }
            else
            {
                TXTdisplay.SelectedText = "9";
            }
        }

        private void BTN4_Click(object sender, EventArgs e)
        {
            if (TXTdisplay.Text == "0" | oppress == true)
            {
                TXTdisplay.Clear();
                TXTdisplay.SelectedText = "4";
                oppress = false;
            }
            else
            {
                TXTdisplay.SelectedText = "4";
            }
        }

        private void BTN5_Click(object sender, EventArgs e)
        {
            if (TXTdisplay.Text == "0" | oppress == true)
            {
                TXTdisplay.Clear();
                TXTdisplay.SelectedText = "5";
                oppress = false;
            }
            else
            {
                TXTdisplay.SelectedText = "5";
            }
        }

        private void BTN6_Click(object sender, EventArgs e)
        {
            if (TXTdisplay.Text == "0" | oppress == true)
            {
                TXTdisplay.Clear();
                TXTdisplay.SelectedText = "6";
                oppress = false;
            }
            else
            {
                TXTdisplay.SelectedText = "6";
            }
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            if (TXTdisplay.Text == "0" | oppress == true)
            {
                TXTdisplay.Clear();
                TXTdisplay.SelectedText = "1";
                oppress = false;
            }
            else
            {
                TXTdisplay.SelectedText = "1";
            }
        }

        private void BTN2_Click(object sender, EventArgs e)
        {
            if (TXTdisplay.Text == "0" | oppress == true)
            {
                TXTdisplay.Clear();
                TXTdisplay.SelectedText = "2";
                oppress = false;
            }
            else
            {
                TXTdisplay.SelectedText = "2";
            }
        }

        private void BTN3_Click(object sender, EventArgs e)
        {
            if (TXTdisplay.Text == "0" | oppress == true)
            {
                TXTdisplay.Clear();
                TXTdisplay.SelectedText = "3";
                oppress = false;
            }
            else
            {
                TXTdisplay.SelectedText = "3";
            }
        }

        private void BTN0_Click(object sender, EventArgs e)
        {
            if (TXTdisplay.Text == "0" | oppress == true)
            {
                TXTdisplay.Clear();
                TXTdisplay.SelectedText = "0";
                oppress = false;
            }
            else
            {
                TXTdisplay.SelectedText = "0";
            }
        }

        private void BTNpoint_Click(object sender, EventArgs e)
        {
            if (dotpress == false)
            {
                TXTdisplay.SelectedText = (".");
                dotpress = true;
            }
            else
            {
                return;
            }

        }

        private void BTNplus_Click(object sender, EventArgs e)
        {
            dotpress = false;
            num1 = float.Parse(TXTdisplay.Text);
            op = "+";
            TXTdisplay.SelectedText = (op);
            oppress = true;
        }

        private void BTNmultiply_Click(object sender, EventArgs e)
        {
            dotpress = false;
            num1 = float.Parse(TXTdisplay.Text);
            op = "x";
            TXTdisplay.SelectedText = (op);
            oppress = true;
        }

        private void BTNdivide_Click(object sender, EventArgs e)
        {
            dotpress = false;
            num1 = float.Parse(TXTdisplay.Text);
            op = "÷";
            TXTdisplay.SelectedText = (op);
            oppress = true;
        }

        private void BTNminus_Click(object sender, EventArgs e)
        {
            dotpress = false;
            num1 = float.Parse(TXTdisplay.Text);
            op = "-";
            TXTdisplay.SelectedText = (op);
            oppress = true;
        }

        private void BTNequals_Click(object sender, EventArgs e)
        {
            //only working with one number 
            switch (op)
            {
                case "^2":
                    answer = num1 * num1;
                    TXTdisplay.Text = answer.ToString();
                    break;
                case "/2":
                    answer = num1 / 2;
                    TXTdisplay.Text = answer.ToString();
                    break;
                case "/-":
                    answer = num1 - (num1 * 2);
                    TXTdisplay.Text = answer.ToString();
                    break;
                case "√":
                    TXTdisplay.Text = Convert.ToString(Math.Sqrt(num1));
                    answer = num1;
                    break;
                case "^3":
                    TXTdisplay.Text = Convert.ToString(num1 * num1 * num1);
                    answer = num1;
                    break;
                case "Sin(":
                    TXTdisplay.Text = Convert.ToString(Math.Sin(num1));
                    answer = num1;
                    break;
                case "Tan(":
                    TXTdisplay.Text = Convert.ToString(Math.Tan(num1));
                    answer = num1;
                    break;
                case "Cos(":
                    TXTdisplay.Text = Convert.ToString(Math.Cos(num1));
                    answer = num1;
                    break;
                case "↑↓":
                    TXTdisplay.Text = Convert.ToString(Math.Round(num1));
                    answer = num1;
                    break;
                
            }

            //working with 2 numbers
            num2 = float.Parse(TXTdisplay.Text);
            dotpress = false;
            switch (op)
            {
                case "+":
                    num2 = float.Parse(TXTdisplay.Text);
                    answer = num1 + num2;
                    TXTdisplay.Text = answer.ToString();
                    break;
                case "-":
                    num2 = float.Parse(TXTdisplay.Text);
                    answer = num1 - num2;
                    TXTdisplay.Text = answer.ToString();
                    break;
                case "÷":
                    num2 = float.Parse(TXTdisplay.Text);
                    answer = num1 / num2;
                    TXTdisplay.Text = answer.ToString();
                    break;
                case "x":
                    num2 = float.Parse(TXTdisplay.Text);
                    answer = num1 * num2;
                    TXTdisplay.Text = answer.ToString();
                    break;

            }

            ans = Convert.ToString(answer);

                

        }

        private void BTNans_Click(object sender, EventArgs e)
        {
            TXTdisplay.Text = (ans);
        }

        private void BTNexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void BTNmemplsus_Click(object sender, EventArgs e)
        {
            memory = TXTdisplay.Text;
        }

        private void BTNmemrecall_Click(object sender, EventArgs e)
        {
            if (TXTdisplay.Text == "0" | oppress == true)
            {
                TXTdisplay.Clear();
                oppress = false;
                TXTdisplay.SelectedText = memory;
            }
            else
            {
                TXTdisplay.SelectedText = memory;
            }
        }

        private void BTNmemminus_Click(object sender, EventArgs e)
        {
            memory = "";

        }

        private void BTNce_Click(object sender, EventArgs e)
        {
            TXTdisplay.Clear();
            memory = "";
            ans = "";
            MessageBox.Show("cache cleared!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TXTdisplay.Text = TXTdisplay.Text.Substring(0, TXTdisplay.Text.Length - 1);
        }

        private void BTNsquare_Click(object sender, EventArgs e)
        {
            dotpress = false;
            num1 = float.Parse(TXTdisplay.Text);
            op = "^2";
            TXTdisplay.SelectedText = (op);
            oppress = true;
        }

        private void BTNhlaf_Click(object sender, EventArgs e)
        {
            dotpress = false;
            num1 = float.Parse(TXTdisplay.Text);
            op = "/2";
            TXTdisplay.SelectedText = (op);
            oppress = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dotpress = false;
            num1 = float.Parse(TXTdisplay.Text);
            op = "/-";
            TXTdisplay.SelectedText = (op);
            oppress = true;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            TXTdisplay.Text = Convert.ToString(trackBar1.Value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dotpress = false;
            num1 = float.Parse(TXTdisplay.Text);
            op = "√";
            TXTdisplay.SelectedText = (op);
            oppress = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dotpress = false;
            num1 = float.Parse(TXTdisplay.Text);
            op = "^3";
            TXTdisplay.SelectedText = (op);
            oppress = true;
        }

        private void BTNsin_Click(object sender, EventArgs e)
        {
            dotpress = false;
            num1 = float.Parse(TXTdisplay.Text);
            op = "Sin(";
            TXTdisplay.SelectedText = (op);
            oppress = true;
        }

        private void BTNcos_Click(object sender, EventArgs e)
        {
            dotpress = false;
            num1 = float.Parse(TXTdisplay.Text);
            op = "Cos(";
            TXTdisplay.SelectedText = (op);
            oppress = true;
        }

        private void BTNtan_Click(object sender, EventArgs e)
        {
            dotpress = false;
            num1 = float.Parse(TXTdisplay.Text);
            op = "Tan(";
            TXTdisplay.SelectedText = (op);
            oppress = true;
        }

        private void BTNround_Click(object sender, EventArgs e)
        {
            dotpress = false;
            num1 = float.Parse(TXTdisplay.Text);
            op = "↑↓";
            TXTdisplay.SelectedText = (op);
            oppress = true;
        }
    }
}
