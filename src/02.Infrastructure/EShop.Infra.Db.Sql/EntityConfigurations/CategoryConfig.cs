using EShop.Domain.Core.CategoryAgg.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infra.Db.Sql.EntityConfigurations
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new List<Category>
                {
                new Category {Id=1 ,CreatedAt =new DateTime (2025, 12, 11, 14, 30, 0),Name="موبایل" ,CreatedByUserId=1},
                new Category{Id=2 ,CreatedAt =new DateTime (2025, 12, 11, 14, 30, 0),Name="لپ تاپ",CreatedByUserId=1},
                new Category{Id= 3,CreatedAt =new DateTime (2025, 12, 11, 14, 30, 0),Name="لوازم  خانه", CreatedByUserId = 1},
                new Category{Id=4 ,CreatedAt =new DateTime (2025, 12, 11, 14, 30, 0),Name="لوازم بهداشتی", CreatedByUserId = 1}

                });
        }
    }
}
