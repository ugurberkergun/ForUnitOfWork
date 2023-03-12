using ForUnitOfWork.DAL.DbContexts;
using ForUnitOfWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForUnitOfWork.DAL.Repositories
{
    public class ProductCategoryMactRepository:GenericRepository<ProductCategoryMatch>,IProductCategoryMatchRepository
    {
        public ProductCategoryMactRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
