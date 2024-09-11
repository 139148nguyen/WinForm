namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        float result;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {
            screenCALC.Text = screenCALC.Text + '1';
        }

        private void num2_Click(object sender, EventArgs e)
        {
            screenCALC.Text = screenCALC.Text + '2';
        }

        private void num3_Click(object sender, EventArgs e)
        {
            screenCALC.Text = screenCALC.Text + '3';

        }

        private void num4_Click(object sender, EventArgs e)
        {
            screenCALC.Text = screenCALC.Text + '4';

        }

        private void num5_Click(object sender, EventArgs e)
        {
            screenCALC.Text = screenCALC.Text + '5';

        }

        private void num6_Click(object sender, EventArgs e)
        {
            screenCALC.Text = screenCALC.Text + '6';

        }

        private void nm7_Click(object sender, EventArgs e)
        {
            screenCALC.Text = screenCALC.Text + '7';

        }

        private void num8_Click(object sender, EventArgs e)
        {
            screenCALC.Text = screenCALC.Text + '8';

        }

        private void num9_Click(object sender, EventArgs e)
        {
            screenCALC.Text = screenCALC.Text + '9';

        }

        private void num0_Click(object sender, EventArgs e)
        {
            screenCALC.Text = screenCALC.Text + '0';

        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (screenCALC.Text.Contains(".") == false)
            {
                //result = float.Parse(screenCALC.Text);
                screenCALC.Text += ".";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if( screenCALC.Text.Contains("+") == false)
            {
                screenCALC.Text += "+";
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (screenCALC.Text.Contains("-") == false)
            {
                screenCALC.Text += "-";
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (screenCALC.Text.Contains("*") == false)
            {
                screenCALC.Text += "*";
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (screenCALC.Text.Contains("/") == false)
            {
                screenCALC.Text += "/";
            }


        }

        private void button18_Click(object sender, EventArgs e)
        {
            screenCALC.Text = "";
        }
    }
}
