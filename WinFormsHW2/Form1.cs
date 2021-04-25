using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHW2
{
    public partial class Form1 : Form
    {
        bool isStoped = true;
        uint score = 0;
        bool leftOrRight = true; // true - right
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.leftbtn.Visible = false;
            this.rightbtn.Visible = false;
            this.upbtn.Visible = false;
            this.money.Visible = false;
            this.money_timer.Stop();
        }
        private void InitMoney()
        {
            
            while (this.money.Top!=this.Height-100)
            {
                this.money.Top++;
            }
        }
        private void startbtn_Click(object sender, EventArgs e)
        {
            this.money.Visible = true;
            this.leftbtn.Visible = true;
            this.rightbtn.Visible = true;
            this.upbtn.Visible = true;
            this.money_timer.Start();
            isStoped = false;
            this.startbtn.Enabled = false;
            this.stopbtn.Enabled = true;
        }

        private void rightbtn_Click(object sender, EventArgs e)
        {

            if (player.Right>=this.Width || isStoped)
            {
                return;
            }
            player.Left+=65 ;
            if (!leftOrRight)
            {
                Image img = player.Image;
                img.RotateFlip(RotateFlipType.RotateNoneFlipX);
                this.player.Image = img;
                this.leftOrRight = true;
            }
            
        }

        private void upbtn_Click(object sender, EventArgs e)
        {
            if (isStoped)
            {
                return;
            }
            this.player.Top -= 135;
            System.Threading.Thread.Sleep(500);
            this.player.Top += 135;

        }
        private void GenereteMoneyLocation()
        {
            Random rnd = new Random();
            if (money.Top > this.Height - money.Size.Width - money.Width)
            {
                money.Top = 0;
                money.Left = rnd.Next(0, this.Width - money.Width);
            }
        }
        private void leftbtn_Click(object sender, EventArgs e)
        {
            if (player.Left <= 0 || isStoped)
            {
                return;
            }
            if (leftOrRight)
            {
                Image img = player.Image;
                img.RotateFlip(RotateFlipType.RotateNoneFlipX);
                this.player.Image = img;
                this.leftOrRight = false;
            }
            
           
            this.player.Left -= 65;
        }

        private void money_timer_Tick(object sender, EventArgs e)
        {
            
            this.money.Top += 50;

            if (this.player.Bounds.IntersectsWith(money.Bounds))
            {
                this.scorelbl.Text = $"Score: {++score}";
                GenereteMoneyLocation();
                return;
            }

            if (this.money.Top > this.Height - money.Width)
            {
                GenereteMoneyLocation();
            }
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            this.startbtn.Enabled = true;
            this.stopbtn.Enabled = false;
            isStoped = true;
            this.money_timer.Stop();
        }

        private void money_LocationChanged(object sender, EventArgs e)
        {
            
        }
    }
}
