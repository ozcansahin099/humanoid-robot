using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class sol : Form
    {

        public void send(byte data)
        {
            if (serialPort1.IsOpen)
            {
                byte[] buffer = { 0 };
                buffer[0] = data;
                serialPort1.Write(buffer, 0, 1);
            }
            else
            {
                MessageBox.Show("Port açık değil");

            }

        }
        public sol()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = System.IO.Ports.SerialPort.GetPortNames();
            comboBox1.SelectedItem = 1;
        }

        private void bağlan_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = comboBox1.SelectedItem.ToString();
                serialPort1.Open();
            }
        }

        private void bağlantıyı_kopar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }




        //servo motor 1.kol kontrolü

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            send(200); //sira ilk servonun
            send(Byte.Parse(trackBar1.Value.ToString()));
        }

        private void trackBar2_MouseUp(object sender, MouseEventArgs e)
        {
            send(201); //sira ikinci servonun
            send(Byte.Parse(trackBar2.Value.ToString()));
        }

        private void trackBar3_MouseUp(object sender, MouseEventArgs e)
        {
            send(202); //sira ucuncu servonun
            send(Byte.Parse(trackBar3.Value.ToString()));

        }
        private void trackBar4_MouseUp(object sender, MouseEventArgs e)
        {
            send(203); //sira dorduncu servonun
            send(Byte.Parse(trackBar4.Value.ToString()));
        }
        private void trackBar5_MouseUp(object sender, MouseEventArgs e)
        {
            send(204); //sira besinci servonun
            send(Byte.Parse(trackBar5.Value.ToString()));
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label6.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label7.Text = trackBar3.Value.ToString();

        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label9.Text = trackBar4.Value.ToString();

        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            label11.Text = trackBar5.Value.ToString();

        }





        //servo motor 2.kol kontrolü


        private void trackBar6_MouseUp(object sender, MouseEventArgs e)
        {
            send(205); //sira besinci servonun
            send(Byte.Parse(trackBar6.Value.ToString()));
        }

        private void trackBar7_MouseUp(object sender, MouseEventArgs e)
        {
            send(206); //sira besinci servonun
            send(Byte.Parse(trackBar7.Value.ToString()));
        }

        private void trackBar8_MouseUp(object sender, MouseEventArgs e)
        {
            send(207); //sira besinci servonun
            send(Byte.Parse(trackBar8.Value.ToString()));
        }

        private void trackBar9_MouseUp(object sender, MouseEventArgs e)
        {
            send(208); //sira besinci servonun
            send(Byte.Parse(trackBar9.Value.ToString()));
        }

        private void trackBar10_MouseUp(object sender, MouseEventArgs e)
        {
            send(209); //sira besinci servonun
            send(Byte.Parse(trackBar10.Value.ToString()));
        }


        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            label17.Text = trackBar6.Value.ToString();
        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            label18.Text = trackBar7.Value.ToString();
        }

        private void trackBar8_Scroll(object sender, EventArgs e)
        {
            label19.Text = trackBar8.Value.ToString();
        }

        private void trackBar9_Scroll(object sender, EventArgs e)
        {
            label20.Text = trackBar9.Value.ToString();
        }

        private void trackBar10_Scroll(object sender, EventArgs e)
        {
            label21.Text = trackBar10.Value.ToString();
        }





       //1. bacak servoları
        private void trackBar11_MouseUp(object sender, MouseEventArgs e)
        {
            send(210); //sira birinci servonun
            send(Byte.Parse(trackBar11.Value.ToString()));
        }

        private void trackBar12_MouseUp(object sender, MouseEventArgs e)
        {
            send(211); //sira ikinci servonun
            send(Byte.Parse(trackBar12.Value.ToString()));
        }

        private void trackBar13_MouseUp(object sender, MouseEventArgs e)
        {
            send(212); //sira ucuncu servonun
            send(Byte.Parse(trackBar13.Value.ToString()));
        }

        private void trackBar11_Scroll(object sender, EventArgs e)
        {
            label25.Text = trackBar11.Value.ToString();
        }

        private void trackBar12_Scroll(object sender, EventArgs e)
        {
            label26.Text = trackBar12.Value.ToString();
        }

        private void trackBar13_Scroll(object sender, EventArgs e)
        {
            label27.Text = trackBar13.Value.ToString();
        }





        //2.bacak servoları
        private void trackBar14_MouseUp(object sender, MouseEventArgs e)
        {
            send(213); //sira birinci servonun
            send(Byte.Parse(trackBar14.Value.ToString()));
        }

        private void trackBar15_MouseUp(object sender, MouseEventArgs e)
        {
            send(214); //sira ikinci servonun
            send(Byte.Parse(trackBar15.Value.ToString()));
        }

        private void trackBar16_MouseUp(object sender, MouseEventArgs e)
        {
            send(215); //sira ucuncu servonun
            send(Byte.Parse(trackBar16.Value.ToString()));
        }

        private void trackBar14_Scroll(object sender, EventArgs e)
        {
            label31.Text = trackBar14.Value.ToString();
        }

        private void trackBar15_Scroll(object sender, EventArgs e)
        {
            label32.Text = trackBar15.Value.ToString();
        }

        private void trackBar16_Scroll(object sender, EventArgs e)
        {
            label33.Text = trackBar16.Value.ToString();
        }





       










    

       

        

        

            
    }
}
