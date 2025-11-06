using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interface
{
    public interface IRepositories<T>
    {
        void Creare(T data);
        void Delete(int Id);
        List<T> GetAll(Predicate<T>? predicateq);
        T Get(Predicate<T> predicate);
        void Update(T data, int id);

    }
}
