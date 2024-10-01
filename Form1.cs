using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncenderLed
{
    public partial class Form1 : Form
    {
        public SerialPort ArduinoPort { get; }
        public Form1()
        {
            InitializeComponent();

            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM4";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();

            this.FormClosing += CerrandoForm1;
            this.Apagar.Click += Apagar_Click;
            this.Encender.Click += button2_Click;

        }
        private void CerrandoForm1(object sender, EventArgs e)
        {
            if (ArduinoPort.IsOpen) ArduinoPort.Close();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");
        }

        private void Apagar_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
        }
        private void Cerrandoform1(object sender, EventArgs e)
        {
            if (ArduinoPort.IsOpen) ArduinoPort.Close();
        }

    }
}
