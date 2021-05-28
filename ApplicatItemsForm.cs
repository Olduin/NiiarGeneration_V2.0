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

        private BindingSource bindingSource;
                
        public ApplicatItemsForm(ApplicatEditContext applicatEditContext)
        {
            this.applicatEditContext = applicatEditContext;
            InitializeComponent();

            tbId.DataBindings.Add("Text", applicatEditContext.Applicat, "Id");

            mkApplicate.DataBindings.Add("Text", applicatEditContext.Applicat, "Date");

            
            cbTypeApplicate.DisplayMember = "Name";
            cbTypeApplicate.ValueMember = "Id";
            cbTypeApplicate.DataSource = applicatEditContext.Types;
            //cbTypeApplicate.SelectedItem = applicatEditContext.Applicat.Type;
            cbTypeApplicate.SelectedValue = applicatEditContext.Applicat.Type.Id;


            var currentTypeIndex= cbTypeApplicate.Items.IndexOf(applicatEditContext.Applicat.Type);
            //cbTypeApplicate.SelectedItem = cbTypeApplicate.Items[currentTypeIndex];
            //cbTypeApplicate.SelectedIndex = currentTypeIndex;

            //this.dgApplicat.DataSource = applicatEditContext.Applicat.ApplicatItems;
            bindingSource = new BindingSource(applicatEditContext.Applicat, "ApplicatItems");
            this.dgApplicat.DataSource = bindingSource;

            cbTypeApplicate.SelectedIndexChanged += cbTypeApplicate_SelectedIndexChanged;
        }

        
        private void btSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btCansel_Click(object sender, EventArgs e)
        {
            Close();
        }

        
      

        private void btAddItem_Click(object sender, EventArgs e)
        {
         
            /*ApplicatItem applicatItem = new ApplicatItem();
                        ApplicateEditForm applicateEditForm = new ApplicateEditForm(applicatEditContext);
                        applicateEditForm.ShowDialog();
                        */
            if(applicatEditContext.Applicat == null)
            {
                applicatEditContext.Applicat = new Applicat();
            }

            applicatEditContext.Applicat.ApplicatItems.Add(new ApplicatItem());

           // dgApplicat.DataSource = applicatEditContext.Applicat.ApplicatItems;
            bindingSource.ResetBindings(false);
                       
        }

        private void cbTypeApplicate_SelectedIndexChanged(object sender, EventArgs e)
        {
            applicatEditContext.Applicat.Type = cbTypeApplicate.SelectedItem as TypeApplicat;
        }

        private void btDelete_Click(object sender, EventArgs e, DataGridViewCellEventArgs d)
        {
            /*DataGridViewRow row = dgApplicat.Rows[d.RowIndex];
            applicatEditContext.Applicat.ApplicatItems.Remove(applicatEditContext.Applicat.ApplicatItems[Convert.ToInt32(row.ToString())]);
            */
            bindingSource = new BindingSource(applicatEditContext.Applicat, "ApplicatItems");
            bindingSource.Remove(dgApplicat.Rows[d.RowIndex]);

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            long delitedRowId = Convert.ToInt64(dgApplicat.CurrentRow.Cells[0].Value);

            
            ApplicatItem delitedAI = applicatEditContext.Applicat.ApplicatItems.FirstOrDefault(ai => ai.Id == delitedRowId);

            applicatEditContext.Applicat.ApplicatItems.Remove(delitedAI);

            dgApplicat.DataSource = applicatEditContext.Applicat.ApplicatItems;
            dgApplicat.Refresh();
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            TableContent tableContext = new TableContent("ApplicateItems");

            foreach (ApplicatItem applicatItem in applicatEditContext.Applicat.ApplicatItems)
            {
                tableContext.AddRow(
                    new FieldContent("Id", applicatItem.Id.ToString()),
                    new FieldContent("StateNumber", applicatItem.Vehicle.state_Number.ToString()),
                    new FieldContent("Vehicle", applicatItem.Vehicle.Name.ToString()),
                    new FieldContent("Customer", applicatItem.Customer.ToString()),
                    new FieldContent("TypeWork", applicatItem.TypeWork.Name.ToString()),
                    //new FieldContent("Additional_description", applicatItem.Additional_description.ToString()),
                    new FieldContent("Time_Of_Filing", applicatItem.Time_Of_Filing.ToString()),
                    new FieldContent("End_time_of_work", applicatItem.End_time_of_work.ToString()),
                    new FieldContent("Delivery_Address", applicatItem.Delivery_Address.ToString())
                    );
            }
                var valuesToFill = new Content(

                  new FieldContent("TypeApplicat", applicatEditContext.Applicat.Type.ToString()),
                  new FieldContent("Date", applicatEditContext.Applicat.Date.ToString("dd.MM.yyyy")),

                  tableContext

                  //new TableContent("ApplicateItems")

                  //  .AddRow(
                  //   new FieldContent("Id", applicatEditContext.Applicat.ApplicatItems[1].Id.ToString()),
                  //   new FieldContent("StateNumber", applicatEditContext.Applicat.ApplicatItems[1].Vehicle.state_Number.ToString()),
                  //   new FieldContent("Customer", applicatEditContext.Applicat.ApplicatItems[1].Customer.ToString()))                              
                );

            //SaveFileDialog //найти
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
    }
}

//{

//}