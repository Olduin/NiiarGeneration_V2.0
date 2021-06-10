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
    public partial class CustomerEditForm : Form
    {
        //private CustomerEditContext customerEditContext;

        //private Customer customer;

        public string CustomerName { get; set; }

        public string Responsible { get; set; }

        public string CustomerPhone { get; set; }

        public CustomerEditForm()
        {
            
            InitializeComponent();

            tbName.DataBindings.Add("Text", this, "CustomerName");

            tbResponsible.DataBindings.Add("Text", this, "Responsible");

            tbPhone.DataBindings.Add("Text", this, "CustomerPhone");

        }

        private void btCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void LoadData()
        //{
        //    tbName.Text = customer.Name;
        //    tbResponsible.Text = customer.Responsible;
        //    tbPhone.Text = customer.Phone;
        //}

        private void btSave_Click(object sender, EventArgs e)
        {
            //SaveData();
            this.DialogResult = DialogResult.OK;
        }

        private void btCansel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btSave_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        //private void SaveData()
        //{
        //    customer.Name = tbName.Text;
        //    customer.Responsible = tbResponsible.Text;
        //    customer.Phone = tbPhone.Text;

        //}
    }
}
