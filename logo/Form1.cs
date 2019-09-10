using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logo
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

            //my Graphics Objects
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font drawfont = new Font("Arial", 20, FontStyle.Bold);
            Pen drawPen = new Pen(Color.Red, 5);

            // code for my text
            g.DrawString("MCLAREN", drawfont, drawBrush, 300, 200);

            // code for shapes
            g.DrawArc(drawPen, 430, 190, 20, 20, 200, 215);
            g.DrawArc(drawPen, 432, 180, 24, 20, 177, 240);
            g.DrawArc(drawPen, 200, 100, 24, 38, 195, 240);
        }
    }
}
