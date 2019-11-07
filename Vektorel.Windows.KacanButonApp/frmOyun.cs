using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vektorel.Windows.KacanButonApp
{
    public partial class frmOyun : Form
    {    int puan=0;
        
        public frmOyun()
        {
            InitializeComponent();
        }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            btnKac.Location = new Point(rnd.Next(this.ClientSize.Width-btnKac.Width),rnd.Next(this.ClientSize.Height-btnKac.Height));
            puan++;
            btnKac.Text = puan.ToString();
            if (puan%10==0)
            {
                this.Size = new Size(this.Width + 10, this.Height + 10);
            }
            puan = 10 * puan;
        }

        private void BtnKac_Click(object sender, EventArgs e)
        {

        }
    }
}
