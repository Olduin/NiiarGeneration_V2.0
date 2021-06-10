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
    public partial class TypeForm : Form
    {
        private TypeContext typeContext;
     
        private BindingSource bindingSource;               

        private List<TypeApplicat> typeApplicats = new List<TypeApplicat>();

        public TypeForm(TypeContext typeContext)
        {
            this.typeContext = typeContext;
            InitializeComponent();

            //bindingSource = new BindingSource(this, "typeApplicats");
            //bindingSource = new BindingSource(typeContext, "Types");
            //dgType.DataSource = bindingSource;
            
         
            //dgType.DataBindings.Add(new BindingSource())
            LoadData();
           // typeContext.ReloadType();
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
            typeContext.Types.Add(new TypeApplicat());
            //bindingSource.ResetBindings(false);
            //LoadData();
        }

        private void LoadData()
        {
            //typeApplicats.AddRange(typeContext.repository.GetTypesList());
            //this.dgType.DataSource = typeContext.Types;
            
            typeContext.ReloadType();
            dgType.DataSource = typeContext.Types;
            //blTypeApplicats.RaiseListChangedEvents;
           

           //bindingSource.ResetBindings(true) ;
        }

        private void dgType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            TypeApplicat editTypeApplicate = typeContext.Types[e.RowIndex];
           

            //currentType = e.RowIndex;
            //TypeEditForm typeEditForm = new TypeEditForm(typeContext, currentType);

            TypeEditForm typeEditForm = new TypeEditForm { TypeApplicateName = editTypeApplicate.Name }; 
            typeEditForm.ShowDialog();
            if(typeEditForm.DialogResult == DialogResult.OK)
            {
                editTypeApplicate.Name = typeEditForm.TypeApplicateName;

                typeContext.repository.TypeApplicateSaveOrAdd(editTypeApplicate);
            }

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            TypeApplicat typeApplicat = dgType.CurrentRow.DataBoundItem as TypeApplicat;

            if (typeApplicat == null) return;

            if (!typeContext.repository.TypeApplicateDelete(typeApplicat))
            {
                MessageBox.Show("Удалить тип не удалось! Данная запись имеет смежные связи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // long delitedRowId = Convert.ToInt64(dgType.CurrentRow.Cells[0].Value);

            //TypeApplicat delitedTp = typeContext.Types.FirstOrDefault(tp => tp.Id == delitedRowId);

            // typeContext.Types.Remove(delitedTp);

            // dgType.DataSource = typeContext.Types;

            LoadData();
            //typeContext.ReloadType();
        }

       
        private void btSave_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
