using EShop.Domain.Core.CategoryAgg.Data;
using EShop.Domain.Core.CategoryAgg.DTOs;
using EShop.Infra.Db.Sql.DbCtx;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infra.Repository.CategoryRepoAgg
{
    public class CategoryRepository(AppDbContext _context):ICategoryRepository
    {
        public async Task<List<GetCategoryDTO>> GetCategories(CancellationToken ct)
        {
            return await _context.Categories.AsNoTracking().Where(c => c.IsDeleted == false)
                .Select(c => new GetCategoryDTO { Id = c.Id, Name = c.Name })
                .ToListAsync(ct);
        }
    }
}
