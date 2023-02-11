using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_17_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //--------------------------------------------------------
        Timer timer1 = new Timer();
        int x, y, w, h;
        //--------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            x = this.Width / 2 - 50;
            y = this.Height / 2 - 50;
            w = 100;
            h = 100;
            timer1.Interval = 30;
            timer1.Enabled = true;
            timer1.Tick += new EventHandler(timer1_Tick);
        }
        //--------------------------------------------------------
        void timer1_Tick(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath g = new System.Drawing.Drawing2D.GraphicsPath();
            g.AddEllipse(new Rectangle(x, y, w, h));
            this.Region = new Region(g);
            x -= 10;
            y -= 10;
            w += 20;
            h += 20;
            if (x <-200)//end show
            {
                this.Region = null;
                timer1.Enabled = false;
            }
        }
    }
}
