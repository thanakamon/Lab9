using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            GraphicsPath gp = new GraphicsPath();

            gp.AddCurve(new Point[] {
            new Point(100,50),new Point(105,40),new Point(120,40),new Point(130,65),new Point(100,100) },0.5f);

            gp.AddCurve(new Point[] {
            new Point(100,100),new Point(70,65),new Point(80,40),new Point(90,40),new Point(100,50) }, 0.5f);

            Queryable.DrawPath(new Pen(Color.Red, 3), gp);
            g.Dispose();
        }
    }
}
