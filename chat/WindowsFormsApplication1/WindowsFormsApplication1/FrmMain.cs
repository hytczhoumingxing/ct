using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;
namespace WindowsFormsApplication1
{
    public partial class 聊天 : Form
    {
        public 聊天()
        {
            InitializeComponent();
        }
        private void listen()
        {
            UdpClient uc = new UdpClient(9527);
            while (true)
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 0);
                byte[] bmsg = uc.Receive(ref ipep);
                string msg = Encoding.Default.GetString(bmsg);
                string[] s= msg.Split('|');
                if(s[0]=="PUBLIC")
                {
                    this.txtHistory.Text += s[2] + s[1] + "\r\n";
                }
                if(s[0]=="INROOM")
                {
                    this.txtHistory.Text += s[2] + "上线啦"+ "\r\n";
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(new ThreadStart(listen));
            th.Start();
            UdpClient uc = new UdpClient();
            string ip = this.txtIp.Text;
            string msg = "INROOM" + "|" + this.txtMsg.Text + "|周星星";
            byte[] bmsg = Encoding.Default.GetBytes(msg);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), 9527);
            uc.Send(bmsg, bmsg.Length, ipep);
        }

        private void txtMsg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSend_Click(object sender, EventArgs e)
        {
            UdpClient uc=new UdpClient();
            string ip = this.txtIp.Text;
            string msg = "PUBLIC"+"|"+this.txtMsg.Text+"|周星星:";
            byte[] bmsg = Encoding.Default.GetBytes(msg);
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip),9527);
            uc.Send(bmsg, bmsg.Length,ipep);
        }

        private void txtIp_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
          
        }
    }
}
 