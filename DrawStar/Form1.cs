using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawStar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pen pen;

        public void DrawStar(Pen pen, float x, float y, float size)
        {
            Graphics g = this.CreateGraphics();
           float scale = size / 88;
        
            g.DrawLine(pen, 44 * scale + x, 3 * scale + y, 55 * scale + x, 34 * scale + y);
            g.DrawLine(pen, 55  * scale + x, 34 * scale + y, 88 * scale + x, 34 * scale + y);
            g.DrawLine(pen, 88 * scale + x, 34 * scale + y, 61 * scale + x, 55 * scale + y);
            g.DrawLine(pen, 61 * scale + x, 55 * scale + y, 71 * scale + x, 85 * scale + y);
            g.DrawLine(pen, 71 * scale + x, 85 * scale + y, 44 * scale + x, 66 * scale + y);
            g.DrawLine(pen, 44 * scale + x, 66 * scale + y, 18 * scale + x, 85 * scale + y);
            g.DrawLine(pen, 18 * scale + x, 85 * scale + y, 27 * scale + x, 54 * scale + y);
            g.DrawLine(pen, 27 * scale + x, 54 * scale + y, 1 * scale + x, 34 * scale + y);
            g.DrawLine(pen, 1 * scale + x, 34 * scale + y, 34 * scale + x, 34 * scale + y);
            g.DrawLine(pen, 34 * scale + x, 34 * scale + y, 44 * scale + x, 3 * scale + y);
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            pen = new Pen(Color.Black);

            float x = Convert.ToSingle(xInput.Text);
            float y = Convert.ToSingle(yInput.Text);
            float size = Convert.ToSingle(sizeInput.Text);

            DrawStar(pen, x, y, size);
        }
    }
}
