﻿using DtoLayer.DtosEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class ArticleCategory
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual IList<Article> Articles { get; set; }

        public ArticleCategory()
        {
            Articles = new List<Article>();
        }

        public ArticleCategory(ArticleCategoryDto articleCategoryDto)
        {
            Id = articleCategoryDto.Id;
            Name = articleCategoryDto.Name;
            Articles = articleCategoryDto.Articles;
        }
    }
}
