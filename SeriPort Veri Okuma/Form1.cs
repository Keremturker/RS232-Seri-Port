using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace SeriPort_Veri_Okuma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static SerialPort serialPort;
        string PortName="";
        int BaudRate=0;
        int DataBit=0;
        Parity Parity=Parity.None;
        StopBits StopBits=StopBits.One;

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            if (comboPortAdi.Items.Count == 0)
            {

                comboPortAdi.Text = "";
                MessageBox.Show("Portlarınızı kontrol ediniz.");
            }
            else {

                PortName = comboPortAdi.SelectedItem.ToString();

                switch (comboBaudRate.SelectedIndex)
                {
                    case 0:
                        BaudRate = 75;
                        break;
                    case 1:
                        BaudRate = 110;
                        break;
                    case 2:
                        BaudRate = 300;
                        break;
                    case 3:
                        BaudRate = 1200;
                        break;
                    case 4:
                        BaudRate = 2400;
                        break;
                    case 5:
                        BaudRate = 4800;
                        break;
                    case 6:
                        BaudRate = 9600;
                        break;
                    case 7:
                        BaudRate = 19200;
                        break;
                    case 8:
                        BaudRate = 38400;
                        break;
                    case 9:
                        BaudRate = 57600;
                        break;
                    case 10:
                        BaudRate = 115200;
                        break;
                    default:
                        BaudRate = 9600;
                        break;
                }
                
                switch (comboDataBit.SelectedIndex)
                {
                    case 0:
                        DataBit = 5;
                        break;
                    case 1:
                        DataBit = 6;
                        break;
                    case 2:
                        DataBit = 7;
                        break;
                    case 3:
                        DataBit = 8;
                        break;
                    default:
                        DataBit = 8;
                        break;
                }
               

                switch (comboParity.SelectedIndex)
                {
                    case 0:
                        Parity = Parity.None;
                        break;
                    case 1:
                        Parity = Parity.Odd;
                        break;
                    case 2:
                        Parity = Parity.Even;
                        break;
                    case 3:
                        Parity = Parity.Mark;
                        break;
                    case 4:
                        Parity = Parity.Space;
                        break;
                    default:
                        Parity = Parity.None;
                        break;
                } 
                switch (comboStopBiti.SelectedIndex)
                {
                    case 0:
                        StopBits = StopBits.None;
                        break;
                    case 1:
                        StopBits = StopBits.One;
                        break;
                    case 2:
                        StopBits = StopBits.Two;
                        break;
                    case 3:
                        StopBits = StopBits.OnePointFive;
                        break;
                    default:
                        StopBits = StopBits.One;
                        break;
                }


                serialPort = new SerialPort(PortName, BaudRate, Parity, DataBit, StopBits);
                 //Seri port bağlantısının açılmasını sağlar
                if (!serialPort.IsOpen)
                serialPort.Open();

                serialPort.DtrEnable = true;
                serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           String veri= serialPort.ReadExisting();


           String[] satir = new String[] { veri };

            ListViewItem itm = new ListViewItem(satir);

             


            listView1.Items.Add(itm);
            listView1.Items[listView1.Items.Count - 1].EnsureVisible();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            #region Açık portları listeleme

            string[] portlar = SerialPort.GetPortNames();
            comboPortAdi.Items.Clear();
            foreach (string prt in portlar)
            {
                comboPortAdi.Items.Add(prt);
            }

            if (comboPortAdi.Items.Count == 0)
            {

                comboPortAdi.Text = "";
                MessageBox.Show("Portlarınızı kontrol ediniz.");
            }
            else
            {
                comboPortAdi.SelectedIndex = 0;
            }

            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }
    }
}
