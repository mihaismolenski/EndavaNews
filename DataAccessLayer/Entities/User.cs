using DtoLayer.DtosEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class User
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual IList<Article> Articles { get; set; }
        
        public virtual UserCategory UserCategory { get; set; }

        public User()
        {
            Articles = new List<Article>();
            UserCategory = new UserCategory();
        }
        public User(UserDto userDto)
        {
            Id = userDto.Id;
            Name = userDto.Name;
            Articles = userDto.Articles;
            UserCategory = userDto.UserCategory;
        }
    }
}
