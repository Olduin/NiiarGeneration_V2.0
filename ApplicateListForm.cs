﻿using NiiarGeneration.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiiarGeneration
{
    public partial class ApplicateListForm : Form
    {
        private Repository repository;
        

        public ApplicateListForm(Repository repository)
        {
            this.repository = repository;
            

            InitializeComponent();
            this.dgApplications.DataSource = repository.ApplicatGetList();

            LoadCbTypes();
           

        }

        
        private void dgApplications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dgApplications.Rows[e.RowIndex];

            long id = Convert.ToInt64(row.Cells[0].Value.ToString());

            ApplicatEditContext applicationEditContext = new ApplicatEditContext(repository);
            
            applicationEditContext.Applicat = repository.ApplicatGet(id);

            using (ApplicatItemsForm editApplicatForm = new ApplicatItemsForm(applicationEditContext))
            {
                editApplicatForm.ShowDialog();

                if (editApplicatForm.DialogResult == DialogResult.OK)
                {
                    repository.ApplicateSave(applicationEditContext.Applicat);
                    dgApplications.DataSource = repository.ApplicatGetList();
                }
            }

        }

        private void btAddApplicat_Click_1(object sender, EventArgs e)
        {
            ApplicatEditContext applicatEditContext = new ApplicatEditContext(repository);

            applicatEditContext.Applicat = new Applicat();
                                   
            using (ApplicatItemsForm ApplicatItemsForm = new ApplicatItemsForm(applicatEditContext))
            {
                ApplicatItemsForm.ShowDialog();

                if (ApplicatItemsForm.DialogResult == DialogResult.OK)
                {
                    repository.ApplicateAdd(applicatEditContext.Applicat);
                }
            }
        }

        private void btVehicles_Click(object sender, EventArgs e)
        {
            VehicleEditContext vehicleEditContext = new VehicleEditContext(repository);

            vehicleEditContext.Vehincles = repository.VehicleGetList();

            using (VehicleForm vehicleForm = new VehicleForm(vehicleEditContext))
            {
                vehicleForm.ShowDialog();

                /* if (vehicleForm.DialogResult == DialogResult.OK)
                {
                    repository.VehicleSave(vehicleEditContext.Vehincle);
                }*/
            }
        }

        private void LoadCbTypes()
        {
           ApplicatEditContext applicationEditContext = new ApplicatEditContext(repository);
           
           CbType.ComboBox.DisplayMember = "Name";
           CbType.ComboBox.ValueMember = "Id";
           CbType.ComboBox.DataSource = applicationEditContext.Types;
           CbType.SelectedIndex = -1;
        }

        
        private void cbType_Click(object sender, EventArgs e)
        {
            ApplicatEditContext applicationEditContext = new ApplicatEditContext(repository);
            //repository.ApplicatGet();
        }

        private void btType_Click(object sender, EventArgs e)
        {
            TypeContext typeContext = new TypeContext(repository);
            typeContext.Types = repository.GetTypesList();

            using (TypeForm typeForm = new TypeForm(typeContext))
            {
                typeForm.ShowDialog();

                if(typeForm.DialogResult == DialogResult.OK)
                {
                   // repository.ty
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Help.ShowHelp(helpProvider1, "help.html");
            
            System.Diagnostics.Process.Start("file:///C:/Users/oldui/source/repos/NiiarGeneration/Myhelp.html");

        }

          
        private void btTypeWork_Click(object sender, EventArgs e)
        {
            TypeWorkContext typeWorkContext = new TypeWorkContext(repository);
            typeWorkContext.TypeWorks = repository.TypeWorkGetList();

            using (TypeWorkForm typeWorkForm = new TypeWorkForm(typeWorkContext))
            {
                typeWorkForm.ShowDialog();

                if (typeWorkForm.DialogResult == DialogResult.OK)
                {
                    // repository.ty
                }
            }
        }

        private void btCustomer_Click(object sender, EventArgs e)
        {
            CustomerEditContext customerEditContext = new CustomerEditContext(repository);
            customerEditContext.Customers = repository.CustomerGetList();

            using (CustomerForm customerForm = new CustomerForm(customerEditContext))
            {
                customerForm.ShowDialog();

                if (customerForm.DialogResult == DialogResult.OK)
                {
                    // repository.ty
                }
            }
        }


        private void CbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbType.SelectedIndex == -1)
            {
                this.dgApplications.DataSource = repository.ApplicatGetList();
                return;
            }

            
            
            ApplicatEditContext applicationEditContext = new ApplicatEditContext(repository);
            TypeApplicat typeApplicat = CbType.SelectedItem as TypeApplicat;
            this.dgApplications.DataSource = repository.ApplicatGetTypes(typeApplicat);
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CbType.SelectedIndex = -1;
        }

        //private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ApplicatEditContext applicationEditContext = new ApplicatEditContext(repository);
        //    long nType = CbType.SelectedIndex;
        //    this.dgApplications.DataSource = repository.ApplicatsGet(nType) ;
        //}
    }
}

