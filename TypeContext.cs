using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NiiarGeneration.Models;

namespace NiiarGeneration
{
    public class TypeContext
    {
        public Repository repository { get; private set; }

        public List<TypeApplicat> Types{ get; set; }

        public TypeContext(Repository repository)
        {
            this.repository = repository;
        }

        public void ReloadType()
        {
            Types = repository.GetTypesList();
        }
        
    }


}
