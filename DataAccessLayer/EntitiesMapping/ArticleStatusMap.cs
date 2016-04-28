using DataAccessLayer.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntitiesMapping
{
    public class ArticleStatusMap:ClassMap<ArticleStatus>
    {
        public ArticleStatusMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            HasMany(x => x.Articles);
        }
    }
}
