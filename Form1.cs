namespace EMICalulator
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double emi;
            double p, r;
            int n;
            double totalPayment;

            p =double.Parse(amountTextBox.Text);
            r = double.Parse(rateTextBox.Text);
            n = decimal.ToInt32(termNumericUpDown.Value);

            emi = (p * r * (Math.Pow((1 + r), n))) / (Math.Pow((1 + r), n) - 1);
            totalPayment = emi * n;
            outputLabel.Text = emi+ "\r\nTotal payment is :  "+ totalPayment;
        }

        private void termNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            double emi;
            double p, r;
            int n;
            double totalPayment;


            p = double.Parse(amountTextBox.Text);
            r = double.Parse(rateTextBox.Text);
            n = decimal.ToInt32(termNumericUpDown.Value);

            emi = p * r * (Math.Pow((1+r),n)) / (Math.Pow((1+r), n) - 1);
            totalPayment = emi * n;
            outputLabel.Text = "Paymont / month is  : " + emi+ "\r\nTotal payment is  : " + totalPayment;
        }
    }
}
