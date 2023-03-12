using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForUnitOfWork.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ProductCategoryMatch> ProductCategoryMatch { get; set; }
    }
}
