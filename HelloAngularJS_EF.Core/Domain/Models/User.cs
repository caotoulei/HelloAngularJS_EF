using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloAngularJS_EF.Core.Domain.Models
{
    public class User
    {
        public Guid ID { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public virtual Name Name { get; set; }

    }
    public class Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
