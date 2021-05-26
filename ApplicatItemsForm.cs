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



            //this.dgApplicat.DataSource = applicatEditContext.Applicat.ApplicatItems;
            bindingSource = new BindingSource(applicatEditContext.Applicat, "ApplicatItems");
            this.dgApplicat.DataSource = bindingSource;
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
            //repository = new Repository();

            //     var  currentApplicat = repository.ApplicatGet(applicatEditContext.Applicat.Id);
            //var currentApplicatItem = 


            

                var valuesToFill = new Content(

                  new FieldContent("TypeApplicat", applicatEditContext.Applicat.Type.ToString()),
                  new FieldContent("date", applicatEditContext.Applicat.Date.ToString()),

                  new TableContent("ApplicateItems")

                    .AddRow(
                     new FieldContent("Id", applicatEditContext.Applicat.ApplicatItems[1].Id.ToString()),
                     new FieldContent("StateNumber", applicatEditContext.Applicat.ApplicatItems[1].Vehicle.state_Number.ToString()),
                     new FieldContent("Customer", applicatEditContext.Applicat.ApplicatItems[1].Customer.ToString()))                              
                );

                using (var outputDocument = new TemplateProcessor("Report.docx")
                    .SetRemoveContentControls(true))
                {
                    outputDocument.FillContent(valuesToFill);
                    outputDocument.SaveChanges();
                }
            }
        }
    }
}

//{

//}