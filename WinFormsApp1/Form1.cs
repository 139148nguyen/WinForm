namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_sum_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = int.Parse(tbox1.Text);
            b = int.Parse(tbox2.Text);
            c = a + b;
            tbox3.Text = c.ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
