using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace NiiarGeneration.Models
{
    [Table ("Applicates")]    
   
    public class Applicat
    { 
        [Key]
        [DisplayName("№")]
        public int Id { get; set; }

        [DisplayName("Дата")] 
        [DataType("Date")]
        public DateTime Date{ get; set; }

        [DisplayName("Тип заявки")]
        public virtual TypeApplicat Type { get; set; }

        [DisplayName("Список")]
        public virtual List<ApplicatItem> ApplicatItems{ get; set; }

        public Applicat()
        {
            Date = DateTime.Now.Date;
            ApplicatItems = new List<ApplicatItem>();
        }

        public override string ToString()
        {
            return Id.ToString();
        }



    }   
}
