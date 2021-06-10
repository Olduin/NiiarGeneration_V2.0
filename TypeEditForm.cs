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
    public partial class TypeEditForm : Form
    {
        //private TypeContext typeContext;
        //private TypeApplicat typeApplicat;

        public string TypeApplicateName { get; set; }


        //public TypeEditForm(TypeContext typeContext, int rowIndex)
        //{
        //    //this.typeContext = typeContext;
        //    //this.typeApplicat = typeContext.Types[rowIndex];
        //    InitializeComponent();
        //    //LoadData();
        //}

        public TypeEditForm()
        {
            InitializeComponent();
            
            tbName.DataBindings.Add(new Binding("Text", this, "TypeApplicateName"));
        }

        private void btCansel_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btSave_Click(object sender, EventArgs e)
        {
            //SaveData();
            this.DialogResult = DialogResult.OK;
        }

        //private void LoadData()
        //{
        //    tbName.Text = typeApplicat.Name;
        //}

        //private void SaveData()
        //{
        //    typeApplicat.Name = tbName.Text;
        //}
    }
}
