using ForUnitOfWork.DAL.DbContexts;
using ForUnitOfWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForUnitOfWork.DAL.Repositories
{
    public class ProductRepository:GenericRepository<Product>,IProductRepository
    {
        public ProductRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
