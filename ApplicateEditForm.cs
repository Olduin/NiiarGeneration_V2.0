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
    public partial class ApplicateEditForm : Form
    {
        
        private ApplicatEditContext applicationEditContext;

        public ApplicatItem applicatItem;
      
        public ApplicateEditForm(ApplicatEditContext applicationEditContext, int rowIndex)
        {
            this.applicationEditContext = applicationEditContext;
                        
            this.applicatItem = applicationEditContext.Applicat.ApplicatItems[rowIndex] ;
            InitializeComponent();

            LoadData();
        }

        public ApplicateEditForm(ApplicatEditContext applicationEditContext)
        {
            this.applicationEditContext = applicationEditContext;
            //this.applicatItem = applicationEditContext.Applicat.ApplicatItems.Add(new applicatItem);
            applicationEditContext.Applicat.ApplicatItems.Add(applicatItem);
            InitializeComponent();

            LoadData();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            SaveData();
            this.DialogResult = DialogResult.OK; 
        }

        private void btCansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LoadData()
        {
            tbIdItem.Text = applicatItem.Id.ToString();
                                       
            tbDeliveryAddress.Text = applicatItem.Delivery_Address;
           
            cbVehicle.SelectedText = applicatItem.Vehicle?.Name;                    
            cbVehicle.DisplayMember = "Name";
            cbVehicle.ValueMember = "id";
            cbVehicle.DataSource = applicationEditContext.Vehincles;

            cbCustomer.SelectedText = applicatItem.Customer?.Name;
            cbCustomer.DisplayMember = "Name";
            cbCustomer.ValueMember = "id";
            cbCustomer.DataSource = applicationEditContext.Customers;

            
            cbTypeWork.SelectedText = applicatItem.TypeWork?.Name;
            cbTypeWork.DisplayMember = "Name";
            cbTypeWork.ValueMember = "id";
            cbTypeWork.DataSource = applicationEditContext.TypeWorks;

            tbStateNumber.Text = applicatItem.Vehicle?.state_Number;


            if (applicatItem.Time_Of_Filing != null)
            {
                dtTime_Of_Filing.Value = (DateTime)applicatItem.Time_Of_Filing;
            }
            else
            {
                dtTime_Of_Filing.Value = DateTime.Now;
            }

        }

        private void SaveData()
        {
            applicatItem.Customer = cbCustomer.SelectedItem as Customer;
            applicatItem.TypeWork= cbTypeWork.SelectedItem as TypeWork;
            applicatItem.Vehicle = cbVehicle.SelectedItem as Vehicle;
            //applicatItem.Vehicle.state_Number 
            applicatItem.Time_Of_Filing = dtTime_Of_Filing.Value;
            applicatItem.End_time_of_work = dtEnd_time_of_work.Value;
            applicatItem.Delivery_Address = tbDeliveryAddress.Text;      
            applicatItem.Additional_description = tbAdditionalDescription.Text;
            
            applicatItem.Applicat = applicationEditContext.Applicat;
        }

        private void ApplicateEditForm_Load(object sender, EventArgs e)
        {

        }

        private void lbAditionalDeskription_Click(object sender, EventArgs e)
        {

        }

        private void cbTypeWork_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

