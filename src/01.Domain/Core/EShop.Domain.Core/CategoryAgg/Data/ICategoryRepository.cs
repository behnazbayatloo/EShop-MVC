using EShop.Domain.Core.CategoryAgg.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.CategoryAgg.Data
{
    public interface ICategoryRepository
    {
        Task<List<GetCategoryDTO>> GetCategories(CancellationToken ct);
    }
}
