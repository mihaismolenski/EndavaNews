using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.DtosEntities
{
   public class UserCategoryDto
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual IList<UserDto> Users { get; set; }

        public UserCategoryDto()
        {
            Users = new List<UserDto>();
        }
    }
}
