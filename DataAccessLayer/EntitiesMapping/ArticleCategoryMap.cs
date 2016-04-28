using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;

namespace DataAccessLayer.EntitiesMapping
{
   public class ArticleCategoryMap:ClassMap<ArticleCategory>
    {
        public ArticleCategoryMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            HasMany(x => x.Articles);
        }
    }
}
