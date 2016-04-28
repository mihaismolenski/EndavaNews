using DataAccessLayer;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntitiesDao
{
    public class GenericEntityDao:IEntitiesDao.IEntitiesDao
    {
        protected ISession Session
        {
            get { return NHibernateConfig.Session; }
        }

        public void Delete<T>(T t)
        {
            using (ITransaction tx = Session.BeginTransaction())
            {
                Session.Delete(t);
                tx.Commit();
            }
        }

        public T Read<T>(int number)
        {
            return Session.Get<T>(number);
        }

        public void Save<T>(T t)
        {
            using (ITransaction tx = Session.BeginTransaction())
            {

                Session.Save(t);
                tx.Commit();
            }
        }

        public void Update<T>(T t)
        {

            using (ITransaction tx = Session.BeginTransaction())
            {
                Session.SaveOrUpdate(t);
                tx.Commit();
            }
        }
    }
}
