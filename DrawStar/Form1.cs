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
        
            g.DrawLine(pen, (44 + x) * scale, (3 + y) * scale, (55 + x) * scale, (34 + y) * scale);
            g.DrawLine(pen, (55 + x) * scale, (34 + y) * scale, (88 + x) * scale, (34 + y) * scale);
            g.DrawLine(pen, (88 + x) * scale, (34 + y) * scale, (61 + x) * scale, (55 + y) * scale);
            g.DrawLine(pen, (61 + x) * scale, (55 + y) * scale, (71 + x) * scale, (85 + y) * scale);
            g.DrawLine(pen, (71 + x) * scale, (85 + y) * scale, (44 + x) * scale, (66 + y) * scale);
            g.DrawLine(pen, (44 + x) * scale, (66 + y) * scale, (18 + x) * scale, (85 + y) * scale);
            g.DrawLine(pen, (18 + x) * scale, (85 + y) * scale, (27 + x) * scale, (54 + y) * scale);
            g.DrawLine(pen, (27 + x) * scale, (54 + y) * scale, (1 + x) * scale, (34 + y) * scale);
            g.DrawLine(pen, (1 + x) * scale, (34 + y) * scale, (34 + x) * scale, (34 + y) * scale);
            g.DrawLine(pen, (34 + x) * scale, (34 + y) * scale, (44 + x) * scale, (3 + y) * scale);
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
