using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
    public interface IRepository<T>
    {
        T Get(int id);
        void Add(T newItem);
        void Update(T newItem);
        void Delete(int id);
        IEnumerable<T> GetAll();
    }
}
