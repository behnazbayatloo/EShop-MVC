using EShop.Domain.Core.CategoryAgg.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.CategoryAgg.Service
{
    public interface ICategoryService
    {
        Task<List<GetCategoryDTO>> GetAllCategory(CancellationToken ct);
    }
}
