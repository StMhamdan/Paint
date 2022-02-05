using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint2
{
    public partial class PaintPr : Form
    {
        public PaintPr()
        {
            InitializeComponent();
            bm = new Bitmap(pictureBoxHome.Width, pictureBoxHome.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBoxHome.Image = bm;

        }

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int select;
        int x, y, sx, sy, cx, cy;

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            select = 3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxHome_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {
                if (select == 2)
                {
                    g.DrawEllipse(p, cx, cy, sx, sy);
                }
                if (select == 3)
                {
                    g.DrawRectangle(p, cx, cy, sx, sy);
                }
               

            }
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            select = 2;
        }

        private void pictureBoxHome_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
          
            cx = e.X;
            cy = e.Y;
        }

        private void pictureBoxHome_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (select == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (select == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
                pictureBoxHome.Refresh();
                x = e.X;
                y = e.Y;
                sx = e.X - cx;
                sy = e.Y - cy;
            }
        }

        private void pictureBoxHome_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sx = x - cx;
            sy = y - cy;
            if (select == 2)
            {
                g.DrawEllipse(p, cx, cy, sx, sy);
            }
            if (select == 3)
            {
                g.DrawRectangle(p, cx, cy, sx, sy);
            }
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            select = 1;
        }
    }
}
