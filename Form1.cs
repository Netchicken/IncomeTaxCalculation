namespace IncomeTaxCalculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateTax_Click(object sender, EventArgs e)
        {
            Single income = 0, tax = 0;
            if (Single.TryParse(txtIncome.Text, out income))
            {
                Single.TryParse(txtIncome.Text, out income);
            }
            else
            {
                MessageBox.Show("Enter a valid income ");
            }

            if (income <= 10000)
            {
                tax = income * 0.10f;
            }
            else if (income <= 50000)
            {
                tax = income * 0.15f;
            }
            else if (income <= 100000)
            {
                tax = income * 0.25f;
            }
            else
            {
                tax = income * 0.30f;
            }
            lblOutput.Text = tax.ToString("C");
        }
    }
}
