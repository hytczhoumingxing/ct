using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace feigou
{
    public partial class UCfriend : UserControl
    {
        private feigou fg;
        public feigou Fg
        {
            get { return Fg; }
            set { fg = value; }
        }
        private Friend curFriend;

        public Friend CurFriend 
        {
            get { return CurFriend; }
            set 
            { 
                curFriend = value;
                this.lblNickName.Text = value.NickName;
                this.lblShuoshuo.Text = value.Shuoshuo;
                this.headerimage.Image = this.fg.ilHeadImages.Images[value.HeadImageIndex];
            }
        }
        public UCfriend()
        {
            InitializeComponent();
        }

        private void headerimage_Click(object sender, EventArgs e)
        {

        }
    }
}
