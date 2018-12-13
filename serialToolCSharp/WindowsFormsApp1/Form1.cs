using System;
using System.Collections.Generic;
 
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
 

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
 
 
        DateTime startt;
        double timet;

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtR.Text = "";
        }

        const int data_max_len = 1000;
        float[] froll = new float[data_max_len];
        float[] ftime = new float[data_max_len];
  

        private void ComDevice_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            byte[] ReDatas = new byte[ComDevice.BytesToRead];
            ComDevice.Read(ReDatas, 0, ReDatas.Length);//读取数据
            rcnt += ReDatas.Length;
            
            //foreach as in 
            foreach (byte a in ReDatas)
            {
                //state_machine(a);
             
                 this.txtR.Invoke(new Action(() =>
                   {
                lblSts.Text = "Tx:" + tcnt.ToString() + "; Rx:" + rcnt.ToString();
                  if(rb2.Checked)
                    txtR.Text += a.ToString("X2") + ' ';
                  else txtR.Text += "0x"+a.ToString("X2") + ", ";

                   }));
            }
            Thread.Sleep(5);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
            /*
            if(talk_status!=0xff)
            {
                bool raw = (datamask & 0x80) == 0 ? false : true;

                rbraw.Checked = raw;
                rbcali.Checked = !raw;


                cbq.Checked = (datamask & 0x01) != 0 ? true : false;
                cbmag.Checked = (datamask & 0x02) != 0 ? true : false;
                cbw.Checked = (datamask & 0x04) != 0 ? true : false;
                cbacc.Checked = (datamask & 0x08) != 0 ? true : false;

                cbeuler.Checked = (datamask & 0x10) != 0 ? true : false;
                cbnavw.Checked = (datamask & 0x20) != 0 ? true : false;
                cbother.Checked = (datamask & 0x40) != 0 ? true : false;

            }
            */

         
 
    
        }

   
        public Form1()
        {
            InitializeComponent();
            //  ComDevice =  new SerialPort();
 
            
 
            this.tabPage1.Text = "设置参数";

            lblSts.Text = "Tx:0"  + "; Rx:0" ;
            //清空缓冲区

            startt = DateTime.Now;// long timeStamp = (long)(DateTime.Now - startTime).TotalSeconds; // 相差毫秒数
            timet = (long)(DateTime.Now - startt).TotalMilliseconds;
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1)); // 当地时区
            long timeStamp = (long)(DateTime.Now - startTime).TotalSeconds; // 相差毫秒数
            string[] ports = SerialPort.GetPortNames();
            cbbComList.DataSource = ports;


        }

        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            if (ComDevice.IsOpen == false)
            {
                ComDevice.PortName = cbbComList.Text;// cbbComList.SelectedItem.ToString();
                ComDevice.BaudRate = Convert.ToInt32(cbbbaut.Text);

                if(ccbEO.Text=="无")
                ComDevice.Parity = Parity.None; //(Parity)Convert.ToInt32(cbbParity.SelectedIndex.ToString());
                else if (ccbEO.Text == "偶")
                    ComDevice.Parity = Parity.Even;
                else if (ccbEO.Text == "奇")
                    ComDevice.Parity = Parity.Odd;
                else if (ccbEO.Text == "0")
                    ComDevice.Parity = Parity.Space;
                else ComDevice.Parity = Parity.Mark;


                ComDevice.DataBits =Convert.ToInt16( ccbDb.Text);//Convert.ToInt32(cbbDataBits.SelectedItem.ToString());

                if (cbbStp.Text == "1")
                    ComDevice.StopBits = StopBits.One;// 1;//(StopBits)Convert.ToInt32(cbbStopBits.SelectedItem.ToString());
                else if (cbbStp.Text == "1.5")
                    ComDevice.StopBits = StopBits.OnePointFive;
                else if (cbbStp.Text == "2")
                    ComDevice.StopBits = StopBits.Two;
                else ComDevice.StopBits = StopBits.None;

                try
                {
                    ComDevice.Open();

                     btnSnd.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                btnOpen.Text = "关闭串口";
                // pictureBox1.BackgroundImage = Properties.Resources.green;
            }
            else
            {
                try
                {
                    ComDevice.Close();
                    btnSnd.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                btnOpen.Text = "打开串口";
                //pictureBox1.BackgroundImage = Properties.Resources.red;
            }
        }

   
 
        private void cbbComList_MouseClick_1(object sender, MouseEventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cbbComList.DataSource = ports;
        }
        int tcnt, rcnt;

        private void btnSnd_Click(object sender, EventArgs e)
        {
            String[] sd = txtT.Text.Split(' ');
            byte[] sb = new byte[sd.Length];
            int i = 0;
            foreach (String a in sd)
            {
                //state_machine(a);

                //  this.txtShowData.Invoke(new Action(() =>
                //   {
                try
                {
                      if(a.Trim().Length>0)
                                    sb[i++] =  Convert.ToByte(a,16);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            ComDevice.Write(sb, 0, i);
            tcnt += i;
            lblSts.Text = "Tx:" + tcnt.ToString()+"; Rx:"+rcnt.ToString();
        }
    }
}
