using DataAccessLayer.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntitiesMapping
{
   public class UserMap:ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            References(x => x.UserCategory);
            HasMany(x => x.Articles).Cascade.AllDeleteOrphan();
        }
    }
}
