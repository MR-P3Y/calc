using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Select();               
        }
        double number = 0;
        double number2 = 0;
        double back = 0;
        string chars = "";
        int cunt = 0;
        int btnuse = 0;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            if (textBox1.Text!="")
            {
                if (textBox1.Text[textBox1.Text.Length - 1] == '.')
                {
                    return;
                }
                if (cunt==0)
                {
                    back = number;
                    number = double.Parse(textBox1.Text);
                    textBox1.Text = number.ToString();
                }
                else if (cunt == 1)
                {
                    if (btnuse==0)
                    {
                        back = number2;
                        number2 = double.Parse(textBox1.Text);
                        textBox1.Text = number2.ToString();
                    }
                    else
                    {
                        back = 0;
                        textBox1.Text = (textBox1.Text[textBox1.Text.Length - 1]).ToString();
                        number2 = double.Parse(textBox1.Text);
                        btnuse = 0;
                    }
                }
            }
            if (cunt==2)
            {
                cunt = 1;
            }
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="0")
            {
                textBox1.Text += "1";
            }
            else
            {
                textBox1.Text = "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "2";
            }
            else
            {
                textBox1.Text = "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "3";
            }
            else
            {
                textBox1.Text = "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "4";
            }
            else
            {
                textBox1.Text = "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "5";
            }
            else
            {
                textBox1.Text = "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "6";
            }
            else
            {
                textBox1.Text = "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "7";
            }
            else
            {
                textBox1.Text = "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "8";
            }
            else
            {
                textBox1.Text = "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "9";
            }
            else
            {
                textBox1.Text = "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "0";
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            cunt = 0;
            number2 = 0;
            number = 0;
            chars = "";
            btnuse = 0;
        }
        public void execut(string cs)
        {
            try
            {
                switch (cs)
                {
                    case "+": number += number2;
                        break;
                    case "-": number -= number2;
                        break;
                    case "*": number *= number2;
                        break;
                    case "/": number /= number2;
                        break;
                }
                cunt = 2;
                textBox1.Text = number.ToString();
            }
            catch (Exception)
            {

                textBox1.Text = "erorr";
            }
            
        }
        private void btnmine_Click(object sender, EventArgs e)
        {
            if (cunt == 0)
            {
                cunt = 1;
                chars = "-";
                textBox1.Text = "0";
            }
            else
            {
                chars = "-";
                execut(chars);
                btnuse = 1;
            }
            
        }

        private void btnequ_Click(object sender, EventArgs e)
        {
            execut(chars);
            cunt = 0;
            btnuse = 0;
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            if (cunt == 0)
            {
                cunt = 1;
                chars = "+";
                textBox1.Text = "0";
            }
            else
            {
                chars = "+";
                execut(chars);
                btnuse = 1;
            }
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            if (cunt == 0)
            {
                cunt = 1;
                chars = "*";
                textBox1.Text = "0";
            }
            else
            {
                chars = "*";
                execut(chars);
                btnuse = 1;
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            if (cunt == 0)
            {
                cunt = 1;
                chars = "/";
                textBox1.Text = "0";
            }
            else
            {
                chars = "/";
                execut(chars);
                btnuse = 1;
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
           // textBox1.Text = back.ToString();
            string s="";
            for (int i = 0; i < textBox1.Text.Length-1; i++)
            {
                s+=(textBox1.Text[i]).ToString();
            }
            textBox1.Text = s;
            if (textBox1.Text=="")
            {
                textBox1.Text = "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains('.') == true)
            {
                return;
            }
            if (textBox1.Text != "0")
            {
                textBox1.Text += ".";
            }
            else
            {
                textBox1.Text = ".";
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //textBox1.Text = back.ToString();
            string s = "";
            for (int i = 0; i < textBox1.Text.Length - 1; i++)
            {
                s += (textBox1.Text[i]).ToString();
            }
            textBox1.Text = s;
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about a1 = new about();
            a1.pictureBox1.ImageLocation = Application.StartupPath + "\\1.jpg";
            a1.ShowDialog();
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about a1 = new about();
            a1.pictureBox1.ImageLocation = Application.StartupPath + "\\2.jpg";
            a1.ShowDialog();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar=='-')
            {
                if (cunt == 0)
                {
                    cunt = 1;
                    chars = "-";
                    textBox1.Text = "0";
                }
                else
                {
                    chars = "-";
                    execut(chars);
                    btnuse = 1;
                }
            }
            if (e.KeyChar == '+')
            {
                if (cunt == 0)
                {
                    cunt = 1;
                    chars = "+";
                    textBox1.Text = "0";
                }
                else
                {
                    chars = "+";
                    execut(chars);
                    btnuse = 1;
                }
            }
            if (e.KeyChar == '*')
            {
                if (cunt == 0)
                {
                    cunt = 1;
                    chars = "*";
                    textBox1.Text = "0";
                }
                else
                {
                    chars = "*";
                    execut(chars);
                    btnuse = 1;
                }
            }
            if (e.KeyChar == '/')
            {
                if (cunt == 0)
                {
                    cunt = 1;
                    chars = "/";
                    textBox1.Text = "0";
                }
                else
                {
                    chars = "/";
                    execut(chars);
                    btnuse = 1;
                }
            }


            //////////////   numbers
            if (e.KeyChar == '1')
            {
                if (textBox1.Text != "0")
                {
                    textBox1.Text += "1";
                }
                else
                {
                    textBox1.Text = "1";
                }
            }
            if (e.KeyChar=='2')
            {
                if (textBox1.Text != "0")
                {
                    textBox1.Text += "2";
                }
                else
                {
                    textBox1.Text = "2";
                }
            }
            if (e.KeyChar == '3')
            {
                if (textBox1.Text != "0")
                {
                    textBox1.Text += "3";
                }
                else
                {
                    textBox1.Text = "3";
                }
            }
            if (e.KeyChar == '4')
            {
                if (textBox1.Text != "0")
                {
                    textBox1.Text += "4";
                }
                else
                {
                    textBox1.Text = "4";
                }
            }
            if (e.KeyChar == '5')
            {
                if (textBox1.Text != "0")
                {
                    textBox1.Text += "5";
                }
                else
                {
                    textBox1.Text = "5";
                }
            }
            if (e.KeyChar=='6')
            {
                if (textBox1.Text != "0")
                {
                    textBox1.Text += "6";
                }
                else
                {
                    textBox1.Text = "6";
                }
            }
            if (e.KeyChar=='7')
            {
                if (textBox1.Text != "0")
                {
                    textBox1.Text += "7";
                }
                else
                {
                    textBox1.Text = "7";
                }
            }
            if (e.KeyChar=='8')
            {
                if (textBox1.Text != "0")
                {
                    textBox1.Text += "8";
                }
                else
                {
                    textBox1.Text = "8";
                }
            }
            if (e.KeyChar == '9')
            {
                if (textBox1.Text != "0")
                {
                    textBox1.Text += "9";
                }
                else
                {
                    textBox1.Text = "9";
                }
            }
            if (e.KeyChar == '0')
            {
                if (textBox1.Text != "0")
                {
                    textBox1.Text += "0";
                }
                else
                {
                    textBox1.Text = "0";
                }
            }
            if (e.KeyChar == '.')
            {
                if (textBox1.Text.Contains('.') == true)
                {
                    return;
                }
                if (textBox1.Text != "0")
                {
                    textBox1.Text += ".";
                }
                else
                {
                    textBox1.Text = ".";
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                execut(chars);
                cunt = 0;
                btnuse = 0;
            }
            if (e.KeyCode == Keys.Back)
            {
                //textBox1.Text = back.ToString();
                string s = "";
                for (int i = 0; i < textBox1.Text.Length - 1; i++)
                {
                    s += (textBox1.Text[i]).ToString();
                }
                textBox1.Text = s;
                if (textBox1.Text == "")
                {
                    textBox1.Text = "0";
                }
            }
            if (e.KeyCode == Keys.Delete)
            {
                textBox1.Text = "0";
                cunt = 0;
                number2 = 0;
                number = 0;
                chars = "";
                btnuse = 0;
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

       

    }
}
