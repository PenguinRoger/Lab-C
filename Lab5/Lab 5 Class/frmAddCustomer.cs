using System;
using System.Windows.Forms;

namespace Lab5.Lab_5_Class
{
    public partial class frmAddCustomer : Form
    {
        private Customer customer = null;

        public frmAddCustomer()
        {
            InitializeComponent();
        }

        public Customer GetNewCustomer()
        {
            this.ShowDialog();
            return customer;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                customer = new Customer(txtFirstName.Text, txtLastName.Text, txtEmail.Text);
                this.Close();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtFirstName) &&
                Validator.IsPresent(txtLastName) &&
                Validator.IsValidEmail(txtEmail);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
