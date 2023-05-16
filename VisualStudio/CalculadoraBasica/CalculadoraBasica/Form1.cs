using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a, b;
        string c;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textResultado.Text == "")
            {
                textResultado.Text = "1";

            }
            else
            {
                textResultado.Text = textResultado.Text + "1";

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textResultado.Text == "")
            {
                textResultado.Text = "2";

            }
            else
            {
                textResultado.Text = textResultado.Text + "2";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textResultado.Text == "")
            {
                textResultado.Text = "3";

            }
            else
            {
                textResultado.Text = textResultado.Text + "3";

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textResultado.Text == "")
            {
                textResultado.Text = "4";

            }
            else
            {
                textResultado.Text = textResultado.Text + "4";

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textResultado.Text == "")
            {
                textResultado.Text = "5";

            }
            else
            {
                textResultado.Text = textResultado.Text + "5";

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textResultado.Text == "")
            {
                textResultado.Text = "6";

            }
            else
            {
                textResultado.Text = textResultado.Text + "6";

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textResultado.Text == "")
            {
                textResultado.Text = "7";

            }
            else
            {
                textResultado.Text = textResultado.Text + "7";

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textResultado.Text == "")
            {
                textResultado.Text = "8";

            }
            else
            {
                textResultado.Text = textResultado.Text + "8";

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textResultado.Text == "")
            {
                textResultado.Text = "9";

            }
            else
            {
                textResultado.Text = textResultado.Text + "9";

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textResultado.Text == "")
            {
                textResultado.Text = "0";

            }
            else
            {
                textResultado.Text = textResultado.Text + "0";

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.textResultado.Text.Contains('.') == false)
            {
                textResultado.Text = this.textResultado.Text + ".";

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textResultado.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(this.textResultado.Text);
            switch (c)
            {
                case "+":
                    this.textResultado.Text = Convert.ToString(b+a);
                    break;
                case "-":
                    this.textResultado.Text = Convert.ToString(a-b);
                    break;
                case "*":
                    this.textResultado.Text = Convert.ToString(b*a);
                    break;
                case "/":
                    this.textResultado.Text = Convert.ToString(a/b);
                    break;

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.textResultado.Text);
            c = "*";
            this.textResultado.Clear();
            this.textResultado.Focus();


        }

        private void button15_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.textResultado.Text);
            c = "+";
            this.textResultado.Clear();
            this.textResultado.Focus();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.textResultado.Text);
            c = "-";
            this.textResultado.Clear();
            this.textResultado.Focus();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            StreamWriter Archivo = new StreamWriter("C:\\Users\\thefl\\Documents\\Historia\\archivo.text");
            Archivo.WriteLine("Operaciones: " + a + c + b + "=" + this.textResultado.Text);
            Archivo.Flush();
            Archivo.Close();
            MessageBox.Show("Guardado con exito");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(this.textResultado.Text);
            c = "/";
            this.textResultado.Clear();
            this.textResultado.Focus();
            
        }
    }
}
