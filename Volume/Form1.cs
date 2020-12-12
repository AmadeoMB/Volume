using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Volume
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Boolean checkNumber(char number)
        {
            if (
                number.Equals('0')
                ||
                number.Equals('1')
                ||
                number.Equals('2')
                ||
                number.Equals('3')
                ||
                number.Equals('4')
                ||
                number.Equals('5')
                ||
                number.Equals('6')
                ||
                number.Equals('7')
                ||
                number.Equals('8')
                ||
                number.Equals('9')
                )
            {
                return true;
            }
            return false;
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < txtR.TextLength; i++)
            {
                if (!checkNumber(txtR.Text[i]))
                {
                    MessageBox.Show("Please input numbers on r");
                    return;
                }
            }

            for (int i = 0; i < txtT.TextLength; i++)
            {
                if (!checkNumber(txtT.Text[i]))
                {
                    MessageBox.Show("Please input numbers on t");
                    return;
                }
            }

            for (int i = 0; i < txtS.TextLength; i++)
            {
                if (!checkNumber(txtS.Text[i]))
                {
                    MessageBox.Show("Please input numbers on S");
                    return;
                }
            }

            Int32 t = 0;
            Int32 r = 0;
            Int32 s = 0;

            if (txtS.TextLength == 0)
            {
                try
                {
                    t = Convert.ToInt32(txtT.Text);
                    r = Convert.ToInt32(txtR.Text);
                    s = (r ^ 2 + t ^ 2) ^ (1 / 2);
                    txtS.Text = s.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please input at least t and r");
                    return;
                }
            }

            if (txtR.TextLength == 0)
            {
                try
                {
                    t = Convert.ToInt32(txtT.Text);
                    s = Convert.ToInt32(txtS.Text);
                    r = (s ^ 2 - t ^ 2) ^ (1 / 2);
                    txtR.Text = r.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please input at least t and S");
                    return;
                }
            }

            if (txtT.TextLength == 0)
            {
                try
                {
                    r = Convert.ToInt32(txtR.Text);
                    s = Convert.ToInt32(txtS.Text);
                    t = (s ^ 2 - r ^ 2) ^ (1 / 2);
                    txtT.Text = t.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please input at least S and r");
                    return;
                }
            }

            Double surface = Math.PI * r * (r + s);
            txtSurface.Text = surface.ToString("##.###");
            Double volume = (surface * t)/3;
            txtVolume.Text = volume.ToString("##.###");
        }

        private void btnCountCylinder_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < txtRCylinder.TextLength; i++)
            {
                if (!checkNumber(txtRCylinder.Text[i]))
                {
                    MessageBox.Show("Please input numbers on r");
                    return;
                }
            }

            for (int i = 0; i < txtTCylinder.TextLength; i++)
            {
                if (!checkNumber(txtTCylinder.Text[i]))
                {
                    MessageBox.Show("Please input numbers on t");
                    return;
                }
            }
        }
    }
}
