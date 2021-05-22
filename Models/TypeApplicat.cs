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
    [Table("TypeApplicates")]

    public class TypeApplicat
    {
        [Key]
        public long Id { get; set; }

        [MaxLength(30)]
        [DisplayName("Наименование типа")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
