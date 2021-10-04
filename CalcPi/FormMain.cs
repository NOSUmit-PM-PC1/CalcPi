using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcPi
{
    public partial class FormMain : Form
    {
        Graphics gr;
        int n = 0;
        int n1 = 0;

        public FormMain()
        {
            InitializeComponent();
            this.ClientSize = new Size(600, 600);
            gr = this.CreateGraphics();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            gr.FillEllipse(Brushes.AliceBlue, 0, 0, 600, 600);
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            gr.FillEllipse(Brushes.Red, e.X, e.Y, 5, 5);
            n = n + 1;
            labelCountSquare.Text = n.ToString();
            double d = Math.Sqrt((300 - e.X) * (300 - e.X) + (300 - e.Y) * (300 - e.Y));
            if (d <= 300)
            {
                n1 = n1 + 1;
                labelCountCircle.Text = n1.ToString();
            }
            labelPi.Text = (4 * (double)n1 / n).ToString();
        }
    }
}
