using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class UserCategory
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual IList<User> Users { get; set; }

        public UserCategory()
        {
            Users = new List<User>();
        } 
    }
}
