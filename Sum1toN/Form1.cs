namespace Sum1toN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int n, s = 0;
            string sumString = "";
            n = int.Parse(naturalNumber.Text);
            for (int i = 1; i < n; i++)
            {
                sumString = sumString + i.ToString() + "+";
                s = s + i;
            }

            sumString = sumString + n.ToString();
            s = s + n;
            sString.Text = sumString;
            sNumber.Text = s.ToString();


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            naturalNumber.Text = "";
            sString.Text = "";
            sNumber.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sString.Enabled = false;
            sNumber.Enabled = false;
        }
    }
}
