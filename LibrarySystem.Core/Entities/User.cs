using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Core.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Mail { get; set; }    
    }
}
