using DataAccessLayer.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntitiesMapping
{
    public class PlaylistMap:ClassMap<Playlist>
    {
        public PlaylistMap()
        {
            Id(x => x.Id);
            Map(x => x.Priority);
            HasMany(x => x.Articles);
        }
    }
}
