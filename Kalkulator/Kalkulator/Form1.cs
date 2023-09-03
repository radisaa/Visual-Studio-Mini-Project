using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        decimal bil1, bil2;
        int opr;
        Boolean opr_selesai = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNol_Click(object sender, EventArgs e)
        {
            if(TextDisplay.Text != "0")
            {
                TextDisplay.Text += "0";
            }

        }

        private void BtnSatu_Click(object sender, EventArgs e)
        {
            if (TextDisplay.Text == "0")
            {
                TextDisplay.Text = "1";
            }
            else
            {
                TextDisplay.Text += "1";
            }
        }

        private void BtnDua_Click(object sender, EventArgs e)
        {
            if (TextDisplay.Text == "0")
            {
                TextDisplay.Text = "2";
            }
            else
            {
                TextDisplay.Text += "2";
            }
        }

        private void BtnTiga_Click(object sender, EventArgs e)
        {
            if (TextDisplay.Text == "0")
            {
                TextDisplay.Text = "3";
            }
            else
            {
                TextDisplay.Text += "3";
            }
        }

        private void BtnEmpat_Click(object sender, EventArgs e)
        {
            if (TextDisplay.Text == "0")
            {
                TextDisplay.Text = "4";
            }
            else
            {
                TextDisplay.Text += "4";
            }
        }

        private void BtnLima_Click(object sender, EventArgs e)
        {
            if (TextDisplay.Text == "0")
            {
                TextDisplay.Text = "5";
            }
            else
            {
                TextDisplay.Text += "5";
            }
        }

        private void BtnEnam_Click(object sender, EventArgs e)
        {
            if (TextDisplay.Text == "0")
            {
                TextDisplay.Text = "6";
            }
            else
            {
                TextDisplay.Text += "6";
            }
        }

        private void BtnTujuh_Click(object sender, EventArgs e)
        {
            if (TextDisplay.Text == "0")
            {
                TextDisplay.Text = "7";
            }
            else
            {
                TextDisplay.Text += "7";
            }
        }

        private void BtnDelapan_Click(object sender, EventArgs e)
        {
            if (TextDisplay.Text == "0")
            {
                TextDisplay.Text = "8";
            }
            else
            {
                TextDisplay.Text += "8";
            }
        }

        private void BtnSembilan_Click(object sender, EventArgs e)
        {
            if (TextDisplay.Text == "0")
            {
                TextDisplay.Text = "9";
            }
            else
            {
                TextDisplay.Text += "9";
            }
        }

        private void BtnKali_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(TextDisplay.Text);
            TextDisplay2.Text = "x";
            TextDisplay.Text = "";
            opr = 1;
            opr_selesai = true;
        }

        private void BtnBagi_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(TextDisplay.Text);
            TextDisplay2.Text = "/";
            TextDisplay.Text = "";
            opr = 2;
            opr_selesai = true;
        }

        private void BtnKurang_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(TextDisplay.Text);
            TextDisplay2.Text = "-";
            TextDisplay.Text = "";
            opr = 3;
            opr_selesai = true;
        }

        private void BtnTambah_Click(object sender, EventArgs e)
        {
            bil1 = Convert.ToDecimal(TextDisplay.Text);
            TextDisplay2.Text = "+";
            TextDisplay.Text = "";
            opr = 4;
            opr_selesai = true;
        }

        private void BtnHasil_Click(object sender, EventArgs e)
        {
            if(opr_selesai == true)
                bil2 = Convert.ToDecimal(TextDisplay.Text);
            {
                switch (opr)
                {
                    case 1:
                        TextDisplay.Text = Convert.ToString(bil1 * bil2);
                        break;
                    case 2:
                        TextDisplay.Text = Convert.ToString(bil1 / bil2);
                        break;
                    case 3:
                        TextDisplay.Text = Convert.ToString(bil1 - bil2);
                        break;
                    case 4:
                        TextDisplay.Text = Convert.ToString(bil1 + bil2);
                        break;
                }
                opr_selesai = false;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            TextDisplay.Text = "0";
            bil1 = 0; 
            bil2 = 0;
            TextDisplay2.Text = "";
        }
    }
}
