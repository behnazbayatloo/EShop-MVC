using EShop.Domain.Core.CategoryAgg.Entity;
using EShop.Domain.Core.ProductAgg.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infra.Db.Sql.EntityConfigurations
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new List<Product>
            { 
            new Product {Id =1 ,CreatedByUserId=1, CreatedAt= new DateTime (2025, 12, 11, 14, 30, 0),CategoryId=1, Title="iPhone 15 Pro",Description = "گوشی پرچمدار اپل با چیپ A17 Pro و دوربین قدرتمند",Price = 49999.0,
        Stock = 10,
        IsDeleted = false}
            ,new Product {Id =2 , CreatedByUserId=1, CreatedAt= new DateTime (2025, 12, 11, 14, 30, 0),CategoryId=1,Title = "Samsung Galaxy S24 Ultra",
        Description = "پرچمدار سامسونگ با دوربین 200 مگاپیکسل و نمایشگر Dynamic AMOLED",
        
        Price = 45999.0,
        Stock = 15,
        IsDeleted = false},
            new Product {Id =3 , CreatedByUserId=1, CreatedAt= new DateTime (2025, 12, 11, 14, 30, 0),CategoryId=1,Title = "Xiaomi 14 Pro",
        Description = "گوشی قدرتمند شیائومی با Snapdragon 8 Gen 3 و شارژ سریع 120 وات",
        
        Price = 28999.0,
        Stock = 20,
        IsDeleted = false}
            ,new Product{Id =4 , CreatedByUserId=1, CreatedAt= new DateTime (2025, 12, 11, 14, 30, 0),CategoryId=1 ,Title = "Google Pixel 9",
        Description = "گوشی گوگل با اندروید خالص و دوربین هوشمند مجهز به AI",
      
        Price = 37999.0,
        Stock = 12,
        IsDeleted = false},
            new Product {Id=5, CreatedByUserId=1, CreatedAt= new DateTime (2025, 12, 11, 14, 30, 0),CategoryId=1,Title = "OnePlus 12",
        Description = "گوشی سریع و سبک با OxygenOS و شارژ فوق سریع",
        
        Price = 32999.0,
        Stock = 18,
        IsDeleted = false}
            , new Product{Id=6, CreatedByUserId=1, CreatedAt= new DateTime (2025, 12, 11, 14, 30, 0),CategoryId=2,
        Title = "MacBook Pro 16 M3",
        Description = "لپ‌تاپ قدرتمند اپل با چیپ M3 Pro و نمایشگر Retina",
        Price = 89999.0,
        Stock = 8,
        IsDeleted = false },
            new Product {Id=7,CreatedByUserId=1, CreatedAt= new DateTime (2025, 12, 11, 14, 30, 0),CategoryId=2, Title = "Dell XPS 15",
        Description = "لپ‌تاپ حرفه‌ای دل با نمایشگر InfinityEdge و پردازنده Core i7 نسل 13",
        Price = 74999.0,
        Stock = 12,
        IsDeleted = false},
            new Product {Id=8,CreatedByUserId=1, CreatedAt= new DateTime (2025, 12, 11, 14, 30, 0),CategoryId=2,Title = "HP Spectre x360",
        Description = "لپ‌تاپ ۲ در ۱ با طراحی باریک، صفحه لمسی و عمر باتری طولانی",
        Price = 65999.0,
        Stock = 10,
        IsDeleted = false},
            new Product {Id=9,CreatedByUserId=1, CreatedAt= new DateTime (2025, 12, 11, 14, 30, 0),CategoryId=2,   Title = "Lenovo ThinkPad X1 Carbon",
        Description = "لپ‌تاپ سبک و مقاوم با کیبورد حرفه‌ای و امنیت بالا",
        Price = 69999.0,
        Stock = 15,
        IsDeleted = false},
            new Product{Id=10,CreatedByUserId=1, CreatedAt= new DateTime (2025, 12, 11, 14, 30, 0),CategoryId=2,Title = "Asus ROG Zephyrus G16",
        Description = "لپ‌تاپ گیمینگ ایسوس با کارت گرافیک RTX 4070 و خنک‌کننده پیشرفته",
        Price = 79999.0,
        Stock = 6,
        IsDeleted = false},
            new Product {Id =11,CreatedByUserId=1, CreatedAt= new DateTime (2025, 12, 11, 14, 30, 0),CategoryId=3,Title = "جاروبرقی هوشمند شیائومی",
        Description = "جاروبرقی رباتیک با قابلیت کنترل از طریق موبایل و برنامه‌ریزی روزانه",
        Price = 12999.0,
        Stock = 20,
        IsDeleted = false},
            new Product {Id =12,CreatedByUserId=1, CreatedAt= new DateTime (2025, 12, 11, 14, 30, 0),CategoryId=3, Title = "مایکروویو سامسونگ 32 لیتری",
        Description = "مایکروویو دیجیتال با برنامه‌های پخت متنوع و صفحه نمایش لمسی",
        Price = 8999.0,
        Stock = 15,
        IsDeleted = false},
            new Product {Id =13,CreatedByUserId=1, CreatedAt= new DateTime (2025, 12, 11, 14, 30, 0),CategoryId=3,Title = "یخچال فریزر دو قلو ال‌جی",
        Description = "یخچال فریزر بزرگ با سیستم خنک‌کننده هوشمند و مصرف انرژی پایین",
        Price = 45999.0,
        Stock = 8,
        IsDeleted = false},
            new Product {Id =14,CreatedByUserId=1, CreatedAt= new DateTime (2025, 12, 11, 14, 30, 0),CategoryId=3,Title = "ماشین لباسشویی بوش 9 کیلویی",
        Description = "لباسشویی اتوماتیک با برنامه‌های شستشوی سریع و موتور کم‌صدا",
        Price = 18999.0,
        Stock = 12,
        IsDeleted = false},
            new Product {Id =15,CreatedByUserId=1, CreatedAt= new DateTime (2025, 12, 11, 14, 30, 0),CategoryId=3, Title = "آبمیوه‌گیری فیلیپس",
        Description = "آبمیوه‌گیری حرفه‌ای با فیلتر استیل ضدزنگ و قابلیت شستشوی آسان",
        Price = 4999.0,
        Stock = 25,
        IsDeleted = false},
            new Product {Id =16,CreatedByUserId=1, CreatedAt= new DateTime (2025, 12, 11, 14, 30, 0),CategoryId=4, Title = "مخلوط‌کن فیلیپس",
        Description = "مخلوط‌کن حرفه‌ای با تیغه استیل ضدزنگ و قابلیت خرد کردن یخ",
        Price = 3499.0,
        Stock = 25,
        IsDeleted = false},
             new Product {Id =17,CreatedByUserId=1, CreatedAt= new DateTime (2025, 12, 11, 14, 30, 0),CategoryId=4, Title = "چای‌ساز بوش",
        Description = "چای‌ساز دیجیتال با قابلیت تنظیم دما و خاموشی خودکار",
        Price = 2799.0,
        Stock = 18,
        IsDeleted = false},
              new Product {Id =18,CreatedByUserId=1, CreatedAt= new DateTime (2025, 12, 11, 14, 30, 0),CategoryId=4,Title = "غذاساز کنوود",
        Description = "غذاساز چندکاره با دیسک‌های مختلف برای خرد کردن، رنده و ورز دادن خمیر",
        Price = 5999.0,
        Stock = 10,
        IsDeleted = false},
               new Product {Id =19,CreatedByUserId=1, CreatedAt= new DateTime (2025, 12, 11, 14, 30, 0),CategoryId=4,Title = "اجاق گاز رومیزی اسنوا",
        Description = "اجاق گاز ۵ شعله با طراحی شیشه‌ای و سیستم ایمنی ترموکوپل",
        Price = 12999.0,
        Stock = 7,
        IsDeleted = false},
                new Product {Id =20,CreatedByUserId=1, CreatedAt= new DateTime (2025, 12, 11, 14, 30, 0),CategoryId=4,Title = "توستر نان پاناسونیک",
        Description = "توستر دو خانه با قابلیت یخ‌زدایی و تنظیم درجه برشته شدن",
        Price = 1999.0,
        Stock = 20,
        IsDeleted = false}
            });
        }
    }
}
