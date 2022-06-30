using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0630
{
    public partial class Form1 : Form
    {
        int vx = rand.Next(-10, 11),vx1 = rand.Next(-10,11),vx2 = rand.Next(-10,11)
          , vy = rand.Next(-10,11),vy1 = rand.Next(-10,11),vy2 = rand.Next(-10,11);
        //静的=最初に決めておく <> 動的=実行時に変更可能
        static Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            label1.Left = rand.Next(0,ClientSize.Width-label1.Width);
            label1.Top = rand.Next(0,ClientSize.Height-label1.Height);
            label3.Left = rand.Next(0, ClientSize.Width - label1.Width);
            label3.Top = rand.Next(0, ClientSize.Height - label1.Height);
            label4.Left = rand.Next(0, ClientSize.Width - label1.Width);
            label4.Top = rand.Next(0, ClientSize.Height - label1.Height);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point spos = MousePosition;
            Point fpos = PointToClient(spos);
            label2.Left = fpos.X-label2.Width/2;
            label2.Top = fpos.Y-label2.Height/2;
            label1.Left += vx;
            label1.Top += vy;
            label3.Left += vx1;
            label3.Top += vy1;
            label4.Left += vx2;
            label4.Top += vy2;

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }
            if((label1.Left <= fpos.X)&&(label1.Right>fpos.X)&&(label1.Top<=fpos.Y)&&(label1.Bottom>fpos.Y))
            {
                timer1.Enabled = false;
            }

            if (label3.Left < 0)
            {
                vx1 = Math.Abs(vx);
            }
            if (label3.Right > ClientSize.Width)
            {
                vx1 = -Math.Abs(vx);
            }
            if (label3.Top < 0)
            {
                vy1 = Math.Abs(vy);
            }
            if (label3.Bottom > ClientSize.Height)
            {
                vy1 = -Math.Abs(vy);
            }
            if ((label3.Left <= fpos.X) && (label3.Right > fpos.X) && (label3.Top <= fpos.Y) && (label3.Bottom > fpos.Y))
            {
                timer1.Enabled = false;
            }

            if (label4.Left < 0)
            {
                vx2 = Math.Abs(vx);
            }
            if (label4.Right > ClientSize.Width)
            {
                vx2 = -Math.Abs(vx);
            }
            if (label4.Top < 0)
            {
                vy2 = Math.Abs(vy);
            }
            if (label4.Bottom > ClientSize.Height)
            {
                vy2 = -Math.Abs(vy);
            }
            if ((label4.Left <= fpos.X) && (label4.Right > fpos.X) && (label4.Top <= fpos.Y) && (label4.Bottom > fpos.Y))
            {
                timer1.Enabled = false;
            }
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
