using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Playlist
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual IList<Article> Articles { get; set; }

        public Playlist()
        {
            Articles = new List<Article>();
        }
    }
}
