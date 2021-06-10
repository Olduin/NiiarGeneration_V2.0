using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NiiarGeneration.Models;

namespace NiiarGeneration
{
    public partial class CustomerForm : Form
    {
        private CustomerEditContext customerEditContext;

        int currentCustomer;

        private BindingSource bindingSource;

        public List<Customer> Customers = new List<Customer>();

        public CustomerForm(CustomerEditContext customerEditContext)
        {
            this.customerEditContext = customerEditContext;
            InitializeComponent();

            //bindingSource = new BindingSource(customerEditContext, "Customers");
            //this.dgCustomers.DataSource = bindingSource;
            LoadData();
        }

        private void btCansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btAddItem_Click(object sender, EventArgs e)
        {
            customerEditContext.Customers.Add(new Customer());
            //customerEditContext.Customers.Add(new Customer());
            //bindingSource.ResetBindings(false);
            LoadData();
           
        }

       

        private void btDelete_Click(object sender, EventArgs e)
        {
            Customer customer = dgCustomers.CurrentRow.DataBoundItem as Customer;

            if(customer == null) return;

            if (!customerEditContext.repository.CustomerDelete(customer));
            {
                MessageBox.Show("Удалить заявителя не удалось! Данная запись имеет смежные связи", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            LoadData();
        }

        private void dgCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            Customer editCustomer = customerEditContext.Customers[e.RowIndex];


          
            CustomerEditForm customerEditForm = new CustomerEditForm { CustomerName = editCustomer.Name, 
                CustomerPhone = editCustomer.Phone, Responsible = editCustomer.Responsible };

            customerEditForm.ShowDialog();
            if (customerEditForm.DialogResult == DialogResult.OK)
            {
                editCustomer.Name = customerEditForm.CustomerName;
                editCustomer.Phone = customerEditForm.CustomerPhone;
                editCustomer.Responsible = customerEditForm.Responsible;

                customerEditContext.repository.CustomerSaveOrAdd(editCustomer);
            }
        }

        private void LoadData()
        {
            customerEditContext.ReloadCustomer();
            dgCustomers.DataSource = customerEditContext.Customers;
        }
    }
}
