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
using NiiarGeneration.Models;
using TemplateEngine.Docx;


namespace NiiarGeneration
{
    public partial class ApplicatItemsForm : Form
    {
        private ApplicatEditContext applicatEditContext;

        private Repository repository;

        //private BindingSource bindingSource;

        private BindingList<ApplicatItem> blApplicatItems;
                
        public ApplicatItemsForm(ApplicatEditContext applicatEditContext)
        {
            this.applicatEditContext = applicatEditContext;
            InitializeComponent();

            tbId.DataBindings.Add("Text", applicatEditContext.Applicat, "Id");
                      
            dtpDateApplicate.DataBindings.Add("Value", applicatEditContext.Applicat, "Date");
          
            cbTypeApplicate.DisplayMember = "Name";
            cbTypeApplicate.ValueMember = "Id";
            cbTypeApplicate.DataSource = applicatEditContext.Types;
            //cbTypeApplicate.SelectedItem = applicatEditContext.Applicat.Type;
                        
            dgApplicat.ContextMenuStrip = CmApplicatItems;
            

            btDelete.Enabled = false;
            
            if (applicatEditContext.Applicat.Type == null)
            {
                applicatEditContext.Applicat.Type = applicatEditContext.Types.FirstOrDefault();
               
            }
            cbTypeApplicate.SelectedValue = applicatEditContext.Applicat.Type.Id;


            var currentTypeIndex= cbTypeApplicate.Items.IndexOf(applicatEditContext.Applicat.Type);

            //bindingSource = new BindingSource(applicatEditContext.Applicat, "ApplicatItems");
            blApplicatItems = new BindingList<ApplicatItem>(applicatEditContext.Applicat.ApplicatItems);

            // BindingList<ApplicatItem> blApplicatItems = new BindingList<ApplicatItem>(applicatEditContext.Applicat.ApplicatItems);
            this.dgApplicat.DataSource = blApplicatItems;

            //this.dgApplicat.DataBindings.Add()

            //ApplicateItemsRefresh();
            

            cbTypeApplicate.SelectedIndexChanged += cbTypeApplicate_SelectedIndexChanged;
            
        }

        
        private void btSave_Click(object sender, EventArgs e)
        {
            //applicatEditContext.Applicat.Date = dtpDateApplicate.Value;
           
            this.DialogResult = DialogResult.OK;
            
        }

        private void btCansel_Click(object sender, EventArgs e)
        {
            Close();
        }      
      

        private void btAddItem_Click(object sender, EventArgs e)
        {
            AddRow();           
                       
        }

        private void cbTypeApplicate_SelectedIndexChanged(object sender, EventArgs e)
        {
            applicatEditContext.Applicat.Type = cbTypeApplicate.SelectedItem as TypeApplicat;
        }

        //private void btDelete_Click(object sender, EventArgs e, DataGridViewCellEventArgs d)
        //{
        //    /*DataGridViewRow row = dgApplicat.Rows[d.RowIndex];
        //    applicatEditContext.Applicat.ApplicatItems.Remove(applicatEditContext.Applicat.ApplicatItems[Convert.ToInt32(row.ToString())]);
        //    */
        //    bindingSource = new BindingSource(applicatEditContext.Applicat, "ApplicatItems");
        //    bindingSource.Remove(dgApplicat.Rows[d.RowIndex]);

        //}

        private void btDelete_Click(object sender, EventArgs e)
        {
            ApplicatItem applicatItem = dgApplicat.CurrentRow.DataBoundItem as ApplicatItem;
            if(applicatItem == null)
            {
                return;
            }
            blApplicatItems.Remove(applicatItem);

            applicatEditContext.DeleteItem(applicatItem);

            //ApplicateItemsRefresh();


            //DelitRow();
            //blApplicatItems.Remove(applicatItem);
            //dgApplicat.Refresh();
        }

        private void ApplicatItemsForm_Load(object sender, EventArgs e)
        {

        }

        private void dgApplicat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            ApplicateEditForm applicateEditForm = new ApplicateEditForm(applicatEditContext, e.RowIndex);
            applicateEditForm.ShowDialog();

            if (applicateEditForm.DialogResult == DialogResult.OK)
            {
                //applicatEditContext.Applicat.ApplicatItems.Add(applicateEditForm.applicatItem);
                //blApplicatItems.Add(applicateEditForm.applicatItem);
                dgApplicat.Refresh() ;
            }

            BtDelit_ChangeState();
            //bindingSource = new BindingSource(applicatEditContext.Applicat, "ApplicatItems");

            //blApplicatItems.ResetBindings();

           //dgApplicat.Refresh();
           //bindingSource.ResetBindings(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            TableContent tableContext = new TableContent("ApplicateItems");

            foreach (ApplicatItem applicatItem in applicatEditContext.Applicat.ApplicatItems)
            {
                tableContext.AddRow(
                    new FieldContent("Id", applicatItem.Id.ToString()),
                    new FieldContent("StateNumber", applicatItem.Vehicle.state_Number),
                    new FieldContent("Vehicle", applicatItem.Vehicle.Name),
                    new FieldContent("Customer", applicatItem.Customer.ToString()),
                    new FieldContent("Phone", applicatItem.Customer.Phone),
                    new FieldContent("TypeWork", applicatItem.TypeWork.Name),
                    new FieldContent("Additional_description", applicatItem.Additional_description == null  ? string.Empty : applicatItem.Additional_description),
                    new FieldContent("Time_Of_Filing", applicatItem.Time_Of_Filing.ToString()),
                    new FieldContent("End_time_of_work", applicatItem.End_time_of_work.ToString()),
                    new FieldContent("Delivery_Address", applicatItem.Delivery_Address)
                    ) ;
            }
                var valuesToFill = new Content(

                  new FieldContent("TypeApplicat", applicatEditContext.Applicat.Type.ToString()),
                  new FieldContent("Date", applicatEditContext.Applicat.Date.ToString("dd.MM.yyyy")),
                  
                  tableContext
                                   
                );
                        
            Stream myStream;
            
            SaveFileDialog saveReportDialog = new SaveFileDialog();

            saveReportDialog.Filter = "Word 2007 Documents (*.docx)|*.docx|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveReportDialog.Title = "Сохранение отчета";
            saveReportDialog.FilterIndex = 1;
            saveReportDialog.RestoreDirectory = true;
            saveReportDialog.FileName = applicatEditContext.Applicat.Type.ToString() + " " + applicatEditContext.Applicat.Date.ToString("dd.MM.yyyy");

            if (saveReportDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;   
            }

            //if ((myStream = saveReportDialog.OpenFile()) != null)
            //{
                try
                {
                    File.Delete(saveReportDialog.FileName);
                }
                catch
                {

                }

                File.Copy("TemplateReport.docx", saveReportDialog.FileName);

                using (var outputDocument = new TemplateProcessor(saveReportDialog.FileName)
                        .SetRemoveContentControls(true))
                {
                    outputDocument.FillContent(valuesToFill);
                    outputDocument.SaveChanges();
                   // myStream.Close();
                }

            //}
            
        }

        private void AddRow()
        {
            
            if (applicatEditContext.Applicat == null)
            {
                applicatEditContext.Applicat = new Applicat();
            }

            applicatEditContext.Applicat.ApplicatItems.Add(new ApplicatItem());

            //bindingSource.ResetBindings(false);
            blApplicatItems.ResetBindings();
        }

        //private void DelitRow()
        //{
        //    try
        //    {
        //        long delitedRowId = Convert.ToInt64(dgApplicat.CurrentRow.Cells[0].Value);

        //        ApplicatItem delitedAI = applicatEditContext.Applicat.ApplicatItems.FirstOrDefault(ai => ai.Id == delitedRowId);

        //        applicatEditContext.Applicat.ApplicatItems.Remove(delitedAI);
        //    }
        //    catch
        //    {
        //        MessageBox.Show(
        //            "Отсутсвует строка",
        //            "Сообщение об ошибке",
        //            MessageBoxButtons.OK,
        //            MessageBoxIcon.Error);
        //    }



        //    //dgApplicat.DataSource = applicatEditContext.Applicat.ApplicatItems;
        //    //dgApplicat.Refresh();

        //    BtDelit_ChangeState();
        //}

        private void BtDelit_ChangeState()
        {
            if (dgApplicat.SelectedCells == null)
            {
                btDelete.Enabled = false;
            }
            else
            {
                btDelete.Enabled = true;
            }
        }

        private void dgApplicat_Click(object sender, EventArgs e)
        {
            BtDelit_ChangeState();
        }

        private void DelApplicate_Click(object sender, EventArgs e)
        {
            //DelitRow();
        }

        private void addApplicate_Click(object sender, EventArgs e)
        {
            AddRow();
        }

        //private void ApplicateItemsRefresh()
        //{
        //    dgApplicat.DataSource = applicatEditContext.Applicat.ApplicatItems;
        //    dgApplicat.Refresh();
        //}
    }
}

