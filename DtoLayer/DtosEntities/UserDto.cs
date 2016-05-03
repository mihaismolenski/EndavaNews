using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.DtosEntities
{
    public class UserDto
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual IList<ArticleDto> Articles { get; set; }

        public virtual UserCategoryDto UserCategory { get; set; }

        public UserDto()
        {
            Articles = new List<ArticleDto>();
            UserCategory = new UserCategoryDto();
        }
    }
}
