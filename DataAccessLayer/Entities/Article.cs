using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Engine;

namespace DataAccessLayer.Entities
{
    public class Article
    {
        public virtual int Id { get; set; }

        public virtual string Title { get; set; }

        public virtual DateTime DateCreated { get; set; }

        public virtual DateTime LastModifiedDate { get; set; }

        public virtual DateTime StartDate { get; set; }

        public virtual DateTime EndDate { get; set; }

        public virtual string Data { get; set; }

        public virtual int Duration { get; set; }

        public virtual User User { get; set; }

        public virtual User LastModifiedBy { get; set; }

        public virtual ArticleCategory ArticleCategory { get; set; }

        public virtual ContentType ContentType { get; set; }

        public virtual ArticleStatus ArticleStatus { get; set; }

        public Article()
        {
            User = new User();
            LastModifiedBy = new User();
            ArticleCategory = new ArticleCategory();
            ContentType = new ContentType();
            ArticleStatus = new ArticleStatus();
        }
    }
}
