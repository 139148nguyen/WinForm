namespace FindMaxNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            float a, b, c, min, max;

            a = float.Parse(numberA.Text);
            b = float.Parse(numberB.Text);
            c = float.Parse(numberC.Text);

            if (a > b)
            {
                if (a > c)
                {
                    max = a;
                    maxNumber.Text = a.ToString();

                    if (b > c)
                    {
                        min = c;
                        minNumber.Text = c.ToString();
                    }

                    else
                    {
                        min = b;
                        minNumber.Text = b.ToString();
                    }
                }

                else
                {
                    max = c;
                    maxNumber.Text = c.ToString();

                    min = b;
                    minNumber.Text = b.ToString();
                }


            }

            else
            {
                if (b > c)
                {
                    max = b;
                    maxNumber.Text = b.ToString();

                    if (a > c)
                    {
                        min = c;
                        minNumber.Text = c.ToString();
                    }

                    else
                    {
                        min = a;
                        minNumber.Text = a.ToString();
                    }
                }

                else
                {
                    max = c;
                    maxNumber.Text = c.ToString();
                    min = a;
                    minNumber.Text = a.ToString();
                }


            }


        }

        private void maxNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maxNumber.Enabled = false;
            minNumber.Enabled = false;
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            numberA.Text = numberB.Text = numberC.Text = minNumber.Text = maxNumber.Text = "";
        }
    }
}
