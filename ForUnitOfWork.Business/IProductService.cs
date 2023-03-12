using ForUnitOfWork.DAL;
using ForUnitOfWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForUnitOfWork.Business
{
    public interface IProductService
    {
        string AddProduct(AddProductDto product, int categoryId);
    }
}
