using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Calc : Form
    {
        bool isCalc;
        public Calc()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (isCalc)
            {
                screenCalc.Text += "1";
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (isCalc)
            {
                screenCalc.Text += "2";
            }
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (isCalc)
            {
                screenCalc.Text += "3";
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (isCalc)
            {
                screenCalc.Text += "4";
            }
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (isCalc)
            {
                screenCalc.Text += "5";
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (isCalc)
            {
                screenCalc.Text += "6";
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (isCalc)
            {
                screenCalc.Text += "7";
            }

        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (isCalc)
            {
                screenCalc.Text += "8";
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (isCalc)
            {
                screenCalc.Text += "9";
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (isCalc)
            {
                screenCalc.Text += "10";
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (Char.IsDigit(screenCalc.Text[screenCalc.Text.Length - 1]) && isCalc)
            {
                screenCalc.Text += "+";
            }
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            if (Char.IsDigit(screenCalc.Text[screenCalc.Text.Length - 1]) && isCalc)
            {
                screenCalc.Text += "-";
            }
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
            if (Char.IsDigit(screenCalc.Text[screenCalc.Text.Length - 1]) && isCalc)
            {
                screenCalc.Text += "*";
            }
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            if (Char.IsDigit(screenCalc.Text[screenCalc.Text.Length - 1]) && isCalc)
            {
                screenCalc.Text += "/";
            }
        }

        private void clean_Click(object sender, EventArgs e)
        {
            screenCalc.Text = "";
            isCalc = true;
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            if (Char.IsDigit(screenCalc.Text[screenCalc.Text.Length - 1]))
            {
                DataTable table = new DataTable();
                var result = table.Compute(screenCalc.Text, string.Empty);
                screenCalc.Text = result.ToString();
                isCalc = false;
            }

        }

        private void Calc_Load(object sender, EventArgs e)
        {
            screenCalc.Enabled = false;
            isCalc = true;
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            if()
        }
    }
}
