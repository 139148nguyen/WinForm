using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void he_so_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_giai_Click(object sender, EventArgs e)
        {
            float a, b, c, x1, x2;
            a = int.Parse(he_so_a.Text);
            b = int.Parse(he_so_b.Text);
            c = int.Parse(he_so_c.Text);
            float delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                thong_bao.Text = "Phương trình vô nghiệm";
            }

            else
            {
                if (delta == 0)
                {
                    thong_bao.Text = "Phương trình có nghiệm kép!";
                    x1 = x2 = (-b / (2 * a));
                    nghiem_x1.Text = nghiem_x2.Text = x1.ToString();

                }

                else
                {
                    thong_bao.Text = "Phương trình có 2 nghiệm phân biệt!";
                    x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
                    x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
                    nghiem_x1.Text = x1.ToString();
                    nghiem_x2.Text = x2.ToString();


                }

            }

        }

        private void btn_lam_moi_Click(object sender, EventArgs e)
        {
            he_so_a.Text = "";
            he_so_b.Text = "";
            he_so_c.Text = "";
            thong_bao.Text = "";
            nghiem_x2.Text = "";
            nghiem_x1.Text = "";

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void thong_bao_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
