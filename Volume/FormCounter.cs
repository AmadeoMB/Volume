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
    public partial class FormCounter : Form
    {
        public FormCounter()
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
                ||
                number.Equals(',')
                )
            {
                return true;
            }
            return false;
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            txtT.Text = txtT.Text.Replace(".", ",");
            txtR.Text = txtR.Text.Replace(".", ",");
            txtS.Text = txtS.Text.Replace(".", ",");

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

            Double t = 0;
            Double r = 0;
            Double s = 0;

            if (txtS.TextLength == 0)
            {
                try
                {
                    t = Convert.ToDouble(txtT.Text);
                    r = Convert.ToDouble(txtR.Text);
                    s = Math.Sqrt(Math.Pow(r, 2) + Math.Pow(t, 2));
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
                    t = Convert.ToDouble(txtT.Text);
                    s = Convert.ToDouble(txtS.Text);
                    r = Math.Sqrt(Math.Pow(s, 2) - Math.Pow(t, 2));
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
                    r = Convert.ToDouble(txtR.Text);
                    s = Convert.ToDouble(txtS.Text);
                    t = Math.Sqrt(Math.Pow(s, 2) - Math.Pow(r, 2));
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
            Double volume = (Math.PI * Math.Pow(r, 2) * t) / 3;
            txtVolume.Text = volume.ToString("##.###");
        }

        private void btnCountCylinder_Click(object sender, EventArgs e)
        {
            if (txtRCylinder.TextLength < 1)
            {
                MessageBox.Show("Please input value r");
                return;
            }

            if (txtTCylinder.TextLength < 1)
            {
                MessageBox.Show("Please input value t");
                return;
            }

            txtTCylinder.Text = txtTCylinder.Text.Replace(".", ",");
            txtRCylinder.Text = txtRCylinder.Text.Replace(".", ",");

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

            Double t = Convert.ToDouble(txtTCylinder.Text);
            Double r = Convert.ToDouble(txtRCylinder.Text);

            Double surface = 2 * Math.PI * r * (r + t);
            txtSurfaceCylinder.Text = surface.ToString("##.###");
            Double volume = Math.PI * Math.Pow(r,2) * t;
            txtVolumeCylinder.Text = volume.ToString("##.###");
        }

        private void btnCountSphere_Click(object sender, EventArgs e)
        {
            if (txtRSphere.TextLength < 1)
            {
                MessageBox.Show("Please input value r");
                return;
            }
            
            txtRSphere.Text = txtRSphere.Text.Replace(".", ",");

            for (int i = 0; i < txtRSphere.TextLength; i++)
            {
                if (!checkNumber(txtRSphere.Text[i]))
                {
                    MessageBox.Show("Please input numbers on r");
                    return;
                }
            }

            Double r = Convert.ToDouble(txtRSphere.Text);

            Double surface = 4 * Math.PI * Math.Pow(r, 2);
            txtSurfaceSphere.Text = surface.ToString("##.###");
            Double volume = (4 * Math.PI * Math.Pow(r, 3))/3;
            txtVolumeSphere.Text = volume.ToString("##.###");
        }

        private void btnCountPyramid_Click(object sender, EventArgs e)
        {
            if (txtLengthPyramid.TextLength < 1)
            {
                MessageBox.Show("Please input value Length");
                return;
            }

            if (txtWidthPyramid.TextLength < 1)
            {
                MessageBox.Show("Please input value Width");
                return;
            }

            if (txtHeightPyramid.TextLength < 1)
            {
                MessageBox.Show("Please input value Height");
                return;
            }

            txtLengthPyramid.Text = txtLengthPyramid.Text.Replace(".", ",");
            txtWidthPyramid.Text = txtWidthPyramid.Text.Replace(".", ",");
            txtHeightPyramid.Text = txtHeightPyramid.Text.Replace(".", ",");

            for (int i = 0; i < txtLengthPyramid.TextLength; i++)
            {
                if (!checkNumber(txtLengthPyramid.Text[i]))
                {
                    MessageBox.Show("Please input numbers on Length");
                    return;
                }
            }

            for (int i = 0; i < txtWidthPyramid.TextLength; i++)
            {
                if (!checkNumber(txtWidthPyramid.Text[i]))
                {
                    MessageBox.Show("Please input numbers on Width");
                    return;
                }
            }

            for (int i = 0; i < txtHeightPyramid.TextLength; i++)
            {
                if (!checkNumber(txtHeightPyramid.Text[i]))
                {
                    MessageBox.Show("Please input numbers on Height");
                    return;
                }
            }

            Double length = Convert.ToDouble(txtLengthPyramid.Text);
            Double width = Convert.ToDouble(txtWidthPyramid.Text);
            Double height = Convert.ToDouble(txtHeightPyramid.Text);

            Double triagleHeight1 = Math.Sqrt(Math.Pow(length / 2, 2) + Math.Pow(height, 2));
            Double triagleHeight2 = Math.Sqrt(Math.Pow(width / 2, 2) + Math.Pow(height, 2));

            Double surface = (length * width) + (length * triagleHeight2) + (width * triagleHeight1);
            txtSurfacePyramid.Text = surface.ToString("##.###");
            Double volume = (length * width * height)/3;
            txtVolumePiramid.Text = volume.ToString("##.###");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtT.Text = "";
            txtR.Text = "";
            txtS.Text = "";
        }

        private void btnRefreshCylinder_Click(object sender, EventArgs e)
        {
            txtTCylinder.Text = "";
            txtRCylinder.Text = "";
        }

        private void btnRefreshSphere_Click(object sender, EventArgs e)
        {
            txtRSphere.Text = "";
        }

        private void btnRefreshPyramid_Click(object sender, EventArgs e)
        {
            txtLengthPyramid.Text = "";
            txtWidthPyramid.Text = "";
            txtHeightPyramid.Text = "";
        }
    }
}
