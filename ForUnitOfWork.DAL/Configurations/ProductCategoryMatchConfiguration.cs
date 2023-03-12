using ForUnitOfWork.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForUnitOfWork.DAL.Configurations
{
    public class ProductCategoryMatchConfiguration : IEntityTypeConfiguration<ProductCategoryMatch>
    {
        public void Configure(EntityTypeBuilder<ProductCategoryMatch> builder)
        {
            builder.Property(x => x.ProductId).IsRequired();
            builder.Property(x => x.CategoryId).IsRequired();
        }
    }
}
