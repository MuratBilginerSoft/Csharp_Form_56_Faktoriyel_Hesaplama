using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_Faktöriyel_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnFaktöriyel_Click(object sender, EventArgs e)
        {
            int factorial = 1, n = 0, i = 1;

            n = Convert.ToInt32(TextDeger.Text);

            if (n == 0 || n == 1)
            {
                factorial = 1;
            }

            else
            {
                while (i <= n)
                {
                    factorial *= i;
                    i++;
                }
            }

            LblSonuc.Text = n + "!=";
            TextSonuc.Text = factorial.ToString();
        }
    }
}
