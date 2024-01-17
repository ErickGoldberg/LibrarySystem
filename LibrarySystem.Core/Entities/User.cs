using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string name, string mail) 
        {
            Name = name;
            Mail = mail;
        }

        public string Name { get; private set; }
        public string Mail { get; private set; }    
    }
}
