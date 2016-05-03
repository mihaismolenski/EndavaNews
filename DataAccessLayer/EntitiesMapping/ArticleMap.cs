using DataAccessLayer.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntitiesMapping
{
    public class ArticleMap : ClassMap<Article>
    {
        public ArticleMap()
        {
            Id(x => x.Id);
            Map(x => x.DateCreated);
            Map(x => x.EndDate);
            Map(x => x.Duration);
            Map(x => x.LastModifiedDate);
            Map(x => x.StartDate);
            Map(x => x.Title);
            Map(x => x.Data);
            References(x => x.User);
            References(x => x.ContentType);
            References(x => x.ArticleCategory);
            References(x => x.LastModifiedBy, "LastModifiedBy");
            References(x => x.ArticleStatus);
            HasManyToMany(x=>x.Playlists).Cascade.All().Inverse();
        }
    }
}
