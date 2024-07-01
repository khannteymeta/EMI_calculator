namespace EMICalulator
{
    internal static class Program
    {
        public partial class MainForm : Form1
        {
            public MainForm()
            {
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                throw new NotImplementedException();
            }
            private TextBox amountTextBox;
            private TextBox rateTextBox;
            private NumericUpDown termNumericUpDown;
            private Label outputLabel;


            private void button1_Click(object sender, EventArgs e)
            {
                double emi;
                double p, r;
                int n;
                double totalPayment;

                p = double.Parse(amountTextBox.Text);
                r = double.Parse(rateTextBox.Text);
                n = decimal.ToInt32(termNumericUpDown.Value);

                emi = (p * r * (Math.Pow((1 + r), n))) / (Math.Pow((1 + r), n) - 1);
                totalPayment = emi * n;
                outputLabel.Text = emi + "\r\nTotal payment is :  " + totalPayment;
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

                emi = p * r * (Math.Pow((1 + r), n)) / (Math.Pow((1 + r), n) - 1);
                totalPayment = emi * n;
                outputLabel.Text = "Paymont / month is  : " + emi.ToString() + "\r\nTotal payment is  : " + totalPayment.ToString();
            }

            
            static void Main()
            {
                // To customize application configuration such as set high DPI settings or default font,
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }


        }

    }
}