﻿using DtoLayer.DtosEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class ArticleStatus
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual IList<Article> Articles { get; set; }

        public ArticleStatus()
        {
            Articles = new List<Article>();
        }

        public ArticleStatus(ArticleStatusDto articleStatusDto)
        {
            Id = articleStatusDto.Id;
            Name = articleStatusDto.Name;
            Articles = articleStatusDto.Articles;
        }
    }
}
