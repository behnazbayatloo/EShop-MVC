using EShop.Domain.Core.CategoryAgg.Data;
using EShop.Domain.Core.CategoryAgg.DTOs;
using EShop.Domain.Core.CategoryAgg.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Services
{
    public class CategoryService (ICategoryRepository _catrepo):ICategoryService
    {
        public async Task<List<GetCategoryDTO>> GetAllCategory(CancellationToken ct) => await  _catrepo.GetCategories(ct);
    }
}
