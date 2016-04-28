using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IEntitiesDao
{
    interface IEntitiesDao
    {
        void Delete<T>(T t);
        void Save<T>(T t);
        void Update<T>(T t);
        T Read<T>(int number);
    }
}
