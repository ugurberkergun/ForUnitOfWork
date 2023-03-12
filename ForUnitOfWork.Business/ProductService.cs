using ForUnitOfWork.DAL;
using ForUnitOfWork.DAL.Repositories;
using ForUnitOfWork.DAL.UnitOfWork;
using ForUnitOfWork.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForUnitOfWork.Business
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductCategoryMatchRepository _productCategoryMatchRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IProductCategoryMatchRepository productCategoryMatchRepository, IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            _productCategoryMatchRepository = productCategoryMatchRepository;
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public string AddProduct(AddProductDto productDto, int categoryId)
        {
            try
            {
                Product newProduct = new()
                {
                    Name = productDto.Name,
                    
                };
                

                _productRepository.Add(newProduct);


                ProductCategoryMatch productCategoryMatch = new()
                {
                    Product = newProduct,
                    CategoryId = categoryId,
                };

                _productCategoryMatchRepository.Add(productCategoryMatch);


                _unitOfWork.Commit();

                return "İşlem Başarılı";

            }
            catch (Exception)
            {
                return "Başarısız";
            }
			
        }
    }
}
