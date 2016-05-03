﻿

using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Inspections;

namespace DataAccessLayer.Convensions
{
    public class CustomManyToManyTableNameConvention : ManyToManyTableNameConvention
    {
        protected override string GetBiDirectionalTableName(IManyToManyCollectionInspector collection, IManyToManyCollectionInspector otherSide)
        {
            return collection.EntityType.Name + "" + otherSide.EntityType.Name;
        }

        protected override string GetUniDirectionalTableName(IManyToManyCollectionInspector collection)
        {
            return collection.EntityType.Name + "" + collection.ChildType.Name;
        }
    }
}
