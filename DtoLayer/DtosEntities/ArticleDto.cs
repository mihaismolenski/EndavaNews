using DtoLayer.DtosEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.DtosEntities
{
    public class ArticleDto
    {
        public virtual int Id { get; set; }

        public virtual string Title { get; set; }

        public virtual DateTime DateCreated { get; set; }

        public virtual DateTime LastModifiedDate { get; set; }

        public virtual DateTime StartDate { get; set; }

        public virtual DateTime EndDate { get; set; }

        public virtual string Data { get; set; }

        public virtual int Duration { get; set; }

        public virtual UserDto User { get; set; }

        public virtual UserDto LastModifiedBy { get; set; }

        public virtual ArticleCategoryDto ArticleCategory { get; set; }

        public virtual ContentTypeDto ContentType { get; set; }

        public virtual ArticleStatusDto ArticleStatus { get; set; }

        public virtual IList<PlaylistDto> Playlists { get; set; }

        public ArticleDto()
        {
            User = new UserDto();
            LastModifiedBy = new UserDto();
            ArticleCategory = new ArticleCategoryDto();
            ContentType = new ContentTypeDto();
            ArticleStatus = new ArticleStatusDto();
            Playlists = new List<PlaylistDto>();
        }
    }
}
