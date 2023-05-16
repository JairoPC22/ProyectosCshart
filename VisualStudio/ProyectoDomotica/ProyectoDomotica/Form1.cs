using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDomotica
{
    public partial class Form1 : Form
    {
        System.IO.Ports.SerialPort casaDomotica;
        private int i;

        public Form1()
        {
            InitializeComponent();
            casaDomotica = new System.IO.Ports.SerialPort();
            casaDomotica.PortName = "COM5";
            casaDomotica.BaudRate = 9600;
            casaDomotica.Open();

            this.FormClosing += Form1_FormClosing;
            this.btnEncCocina.Click += BtnEncCocina_Click; //a
            this.bntApgCocina.Click += BntApgCocina_Click; //b
            this.btnEncComidar.Click += BtnEncComidar_Click; //c
            this.bntApgComedor.Click += BntApgComedor_Click; //d
            this.btnEncSala.Click += BtnEncSala_Click; //e
            this.bntApgSala.Click += BntApgSala_Click; //f 
            this.btnEncHabit1.Click += BtnEncHabit1_Click; //g
            this.bntApgHabit1.Click += BntApgHabit1_Click; //h
            this.btnEncHabit2.Click += BtnEncHabit2_Click; //l
            this.bntApgHabit2.Click += BntApgHabit2_Click; //m
            this.btnEncSanitario.Click += BtnEncSanitario_Click; //n
            this.bntApgSanitario.Click += BntApgSanitario_Click; //o
            this.BtnPresionar.Click += BtnPresionar_Click1; //2
        }

        private void BtnPresionar_Click1(object sender, EventArgs e)
        {
            casaDomotica.Write("2");
        }

        private void BntApgSanitario_Click(object sender, EventArgs e)
        {
            casaDomotica.Write("o");
        }

        private void BtnEncSanitario_Click(object sender, EventArgs e)
        {
            casaDomotica.Write("n");
        }

        private void BntApgHabit2_Click(object sender, EventArgs e)
        {
            casaDomotica.Write("m");
        }

        private void BtnEncHabit2_Click(object sender, EventArgs e)
        {
            casaDomotica.Write("l");

        }

        private void BntApgHabit1_Click(object sender, EventArgs e)
        {
            casaDomotica.Write("h");
        }

        private void BtnEncHabit1_Click(object sender, EventArgs e)
        {
            casaDomotica.Write("g");

        }

        private void BntApgSala_Click(object sender, EventArgs e)
        {
            casaDomotica.Write("f");

        }

        private void BtnEncSala_Click(object sender, EventArgs e)
        {
            casaDomotica.Write("e");

        }

        private void BntApgComedor_Click(object sender, EventArgs e)
        {

            casaDomotica.Write("d");
        }

        private void BtnEncComidar_Click(object sender, EventArgs e)
        {
            casaDomotica.Write("c");
        }

        private void BntApgCocina_Click(object sender, EventArgs e)
        {
            casaDomotica.Write("b");
        }

        private void BtnEncCocina_Click(object sender, EventArgs e)
        {
            casaDomotica.Write("a");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (casaDomotica.IsOpen) casaDomotica.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnPresionar_Click(object sender, EventArgs e)
        {
            i++;
            if (i == 1)
            {
                casaDomotica.Write("a");
                casaDomotica.Write("c");
                casaDomotica.Write("e");
                casaDomotica.Write("g");
                casaDomotica.Write("l");
                casaDomotica.Write("n");


            }
            else if (i == 2)
            {
                casaDomotica.Write("b");
                casaDomotica.Write("d");
                casaDomotica.Write("f");
                casaDomotica.Write("h");
                casaDomotica.Write("m");
                casaDomotica.Write("o");
                i = 0;


            }

        }
    }
}
