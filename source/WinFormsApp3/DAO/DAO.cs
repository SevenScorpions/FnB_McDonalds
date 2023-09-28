using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInDemo.DAO
{
    public abstract class DAO<T>
    {
        public abstract void Insert(T t);
        public abstract void Delete(T t);
        public abstract void Update(T t);
        public abstract List<T> GetAll();
    }
}
