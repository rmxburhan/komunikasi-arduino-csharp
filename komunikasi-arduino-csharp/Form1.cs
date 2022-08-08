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

namespace komunikasi_arduino_csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ProgressBar1.Value = 0;
            btnDisconnect.Enabled = false;
            addPort();
            addBaudRate();
            if (cbxDaftarPort.Items.Count > 0)
            {
                cbxDaftarPort.SelectedIndex = 0;
            }
            cbxBaudRate.SelectedIndex = 0;
        }
        void addPort()
        {
            string[] ports = SerialPort.GetPortNames();
            if (ports.Length > 0)
            {
                cbxDaftarPort.Items.AddRange(ports);
            }
            else
            {
                cbxDaftarPort.Items.Clear();
            }
        }
        void addBaudRate()
        {
            int rate = 1200;
            for (int i = 0; i < 7; i++)
            {
                cbxBaudRate.Items.Add(rate);
                rate *= 2;
            }
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 537:
                    string[] ports = SerialPort.GetPortNames();
                    if (ports.Length > 0)
                    {
                        cbxDaftarPort.Items.AddRange(ports);
                    }
                    else
                    {
                        cbxDaftarPort.Items.Clear();
                    }
                    break;
            }
            base.WndProc(ref m);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxBaudRate.Text != "" && cbxDaftarPort.Text != "")
                {
                    serialPort1.PortName = cbxDaftarPort.SelectedItem.ToString();
                    serialPort1.BaudRate = int.Parse(cbxBaudRate.SelectedItem.ToString());
                    serialPort1.Open();
                    btnDisconnect.Enabled = true;
                    guna2ProgressBar1.Value = 100;
                    cbxDaftarPort.Enabled = false;
                    cbxBaudRate.Enabled = false;
                    btnConnect.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Lengkapi data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    btnDisconnect.Enabled = false;
                    guna2ProgressBar1.Value = 0;
                    cbxDaftarPort.Enabled = true;
                    cbxBaudRate.Enabled = true;
                    btnConnect.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }
        string dataReceived;
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataReceived = serialPort1.ReadExisting();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            richTextBox1.Text += dataReceived;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Write(txtSend.Text + "#");
            }
        }
    }
}
