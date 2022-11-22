using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionInvestigation
{
    internal class User  //  : Object no need to explicitly inherit, it will do so implicitly
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Boolean Active { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is User user &&
                   Id == user.Id &&
                   Name == user.Name &&
                   Email == user.Email &&
                   Active == user.Active;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Email, Active);
        }

        public override string? ToString()
        {
            return $"{Id}:{Name}, {Email} { (Active ? "Active" : "Inactive") }";
        }


    }
}
