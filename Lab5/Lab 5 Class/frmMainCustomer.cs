using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab5.Lab_5_Class
{
    public partial class frmMainCustomer : Form
    {
        private List<Customer> customers = null;

        public frmMainCustomer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddCustomer addCustomerForm = new frmAddCustomer();
            Customer customer = addCustomerForm.GetNewCustomer();

            if (customer != null)
            {
                customers.Add(customer);
                CustomerDB.SaveCustomers(customers);
                FillCustomerListBox();
            }
        }

        private void frmMainCustomer_Load(object sender, EventArgs e)
        {
            customers = CustomerDB.GetCustomers();
            FillCustomerListBox();
        }

        private void FillCustomerListBox()
        {
            lstCustomers.Items.Clear();
            foreach (Customer c in customers)
            {
                lstCustomers.Items.Add(c.GetDisplayText());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstCustomers.SelectedIndex;
            if (selectedIndex != -1)
            {
                customers.RemoveAt(selectedIndex);
                CustomerDB.SaveCustomers(customers);
                FillCustomerListBox();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
