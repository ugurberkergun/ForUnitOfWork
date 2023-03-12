using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ForUnitOfWork.DAL.Repositories
{
    public interface IGenericRepository<T> where T : class, new()
    {
        void Add(T entity);
        void Delete(T entity);
    }

}
