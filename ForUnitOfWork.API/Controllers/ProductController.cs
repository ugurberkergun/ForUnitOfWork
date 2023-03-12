using ForUnitOfWork.Business;
using ForUnitOfWork.DAL;
using ForUnitOfWork.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ForUnitOfWork.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController:ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public JsonResult AddNewProduct([FromQuery]AddProductDto product,int categoryId)
        {
            var result = _productService.AddProduct(product, categoryId);
            return new JsonResult(new { message = result });

        }
    }
}
