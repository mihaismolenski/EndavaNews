using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.DtosEntities
{
    public class ContentTypeDto
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual IList<ArticleDto> Articles { get; set; }

        public ContentTypeDto()
        {
            Articles = new List<ArticleDto>();
        }
    }
}
