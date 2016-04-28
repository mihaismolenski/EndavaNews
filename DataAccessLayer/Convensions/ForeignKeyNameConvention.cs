using FluentNHibernate.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate;

namespace DataAccessLayer.Convensions
{
    public class ForeignKeyNameConvention: ForeignKeyConvention
    {
        protected override string GetKeyName(Member property, Type type)
        {
            if (property == null)
            {
                // Relationship is many-to-many, one-to-many or join.
                if (type == null)
                    throw new ArgumentNullException("type");

                return type.Name + "Id";
            }

            // Relationship is many-to-one.
            return property.Name + "Id";
        }
    }
}
