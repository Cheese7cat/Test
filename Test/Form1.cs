using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            g.DrawLine(drawPen, 0, 0, 100, 100);
            g.DrawRectangle(drawPen, 30, 30, 100, 200);
            g.FillRectangle(drawBrush, 30, 30, 100, 200);
            g.DrawEllipse(drawPen, 30, 30, 100, 200);
           
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            // g.DrawArc(drawPen, 300, 20, 50, 50, 90, 300);
            g.DrawPie(drawPen, 300, 20, 50, 50, 330, 60);
        }

    }
}
