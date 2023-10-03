using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._17
{
    public partial class lblBlue : Form
    {
        public lblBlue()
        {
            InitializeComponent();
        }

        private void tbRed_Scroll(object sender, EventArgs e)
        {
            int r, g, b;
            r= tbRed.Value;
            g= tbGreen.Value;
            b= tbBlue.Value;
            
            lblRed.Text = r.ToString();

            this.BackColor = System.Drawing.Color.FromArgb(r, g, b);
        }

        private void tbGreen_Scroll(object sender, EventArgs e)
        {
            int r, g, b;
            r = tbRed.Value;
            g = tbGreen.Value;
            b = tbBlue.Value;

            lblGreen.Text = g.ToString();

            this.BackColor = System.Drawing.Color.FromArgb(r, g, b);
        }

        private void tbBlue_Scroll(object sender, EventArgs e)
        {
            int r, g, b;
            r = tbRed.Value;
            g = tbGreen.Value;
            b = tbBlue.Value;

            label3.Text = b.ToString();

            this.BackColor = System.Drawing.Color.FromArgb(r, g, b);
        }
    }
}
