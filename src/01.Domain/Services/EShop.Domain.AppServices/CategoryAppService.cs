using EShop.Domain.Core.CategoryAgg.AppService;
using EShop.Domain.Core.CategoryAgg.DTOs;
using EShop.Domain.Core.CategoryAgg.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.AppServices
{
    public class CategoryAppService(ICategoryService _catsrv) :ICategoryAppService
    {
        public async Task<List<GetCategoryDTO>> GetAllCategories(CancellationToken ct) => await _catsrv.GetAllCategory(ct);
    }
}
