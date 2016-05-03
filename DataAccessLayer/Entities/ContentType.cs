using DtoLayer.DtosEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class ContentType
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual IList<Article> Articles { get; set; }

        public ContentType()
        {
            Articles = new List<Article>();
        }

        public ContentType(ContentTypeDto contentTypeDto)
        {
            Id = contentTypeDto.Id;
            Name = contentTypeDto.Name;
            Articles = contentTypeDto.Articles;
        }
    }
}
