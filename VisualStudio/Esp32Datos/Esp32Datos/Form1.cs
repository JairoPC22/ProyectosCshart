using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace Esp32Datos
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval= 1000;
            timer1.Start();

            serialPort= new SerialPort("COM5", 9600);
            try
            {
                serialPort.Open();
            }
            catch
            {
                Console.WriteLine("No se pudo abrir el puerto COM; verifique que no esté en uso");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool Medicion = false;
            string fuego = string.Empty;

            while (!Medicion)
            {
                fuego = serialPort.ReadLine();
                if (!string.IsNullOrEmpty(fuego))
                {
                    Medicion = true;
                }
            }
            if (Medicion)
            {
                textBox1.Text += "R=" + fuego + Environment.NewLine;
            }

        }
    }
}
