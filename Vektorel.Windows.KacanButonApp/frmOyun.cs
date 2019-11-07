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
    {
        int sure = 0;
        int puan=0;
        int count = 0;
        

        
        public frmOyun()
        {
            InitializeComponent();
        }

        private void Button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random rnd = new Random();
            this.BackColor = Color.FromArgb(rnd.Next(256),rnd.Next(256),rnd.Next(256));
            puan++;
            if (puan%10==0)
            {
                this.Size = new Size(this.Width + 10, this.Height + 10);
            }

            btnKac.Text = puan.ToString();
            btnKac.Location = new Point(rnd.Next(this.ClientSize.Width-btnKac.Width),rnd.Next(this.ClientSize.Height-btnKac.Height));
            
            
            
        }

        private void BtnKac_Click(object sender, EventArgs e)
        {

        }

        private void TmrSure_Tick(object sender, EventArgs e)
        {
            
        }

        private void FrmOyun_Load(object sender, EventArgs e)
        {
            sure--;
            this.Text =sure.ToString();
            if (sure==0)
            {
                tmrSure.Stop();
                MessageBox.Show($"Süreniz doldu.Puanınız:(count)\nYeniden Oynamak istiyor musunuz?","Oyun Bitti",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (cvp == DialogResult.Yes)
                {
                    sure = 3;
                    count = 0;
                    tmrSure.Start();
                }
                else
                {
                    btnKac.Text = ":)";
                    btnKac.Enabled = false;
                }
            }


        }
    }
}
