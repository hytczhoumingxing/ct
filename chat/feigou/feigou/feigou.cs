using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
namespace feigou
{
    public partial class feigou : Form
    {
        public delegate void delAddFriend(Friend friend);
        public feigou()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //侦听
            Thread th = new Thread(new ThreadStart(listen));
            Thread.Sleep(100);
            th.Start();
            
            
        }
        public void addUcf(Friend f) 
        {
            UCfriend ucf = new UCfriend();
            ucf.Fg = this;
            ucf.CurFriend = f;
            ucf.Top = this.pnFriendsList.Controls.Count * ucf.Height;
            this.pnFriendsList.Controls.Add(ucf);
        }
        private void listen() 
        {
            UdpClient uc = new UdpClient(9527);//udp协议添加端口号
            while (true) 
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Any,0);//将网络端点转化为ip地址 和端口号
                byte[] bmsg = uc.Receive(ref ipep);//返回有远程主机发出的udp数据报
                string msg = Encoding.Default.GetString(bmsg);//将字节转化为文本
                string[] s = msg.Split('|');//元素分隔
                if(s.Length != 4)
                {
                    continue;
                }
                if(s[0]=="LOGIN")
                  {
                      Friend friend=new Friend();
                      int curIndex = Convert.ToInt32(s[2]);
                      if (curIndex<0 || curIndex>=this.ilHeadImages.Images.Count)
                         {
                             curIndex = 0;
                         }
                      friend.HeadImageIndex =curIndex;
                      friend.NickName = s[1];
                      friend.Shuoshuo=s[3];
                      object[] pars=new object[1];
                      pars[0]=friend;
                      this.Invoke(new delAddFriend(this.addUcf),pars[0]);
                  }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //发广播
            UdpClient uc = new UdpClient();
            string txtName=this.txtName.Text;
            string msg = "LOGIN|" + "你的益达" + "|45|今天天气很好";
            byte[] bmsg = Encoding.Default.GetBytes(msg);
            uc.Send(bmsg,bmsg.Length,new IPEndPoint(IPAddress.Parse("255.255.255.255"),9527));
        }

        private void pnFriendsList_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
