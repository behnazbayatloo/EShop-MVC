using EShop.Domain.Core.UserAgg.Data;
using EShop.Infra.Db.Sql.DbCtx;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Infra.Repository.ApplicationUserRepoAgg
{
    public class ApplicationUserRepository(AppDbContext _context):IApplicationUserRepository
    {
        public async Task<double> GetBallance (int userId,CancellationToken ct)
        {
            return await _context.Users.Where(u=>u.Id==userId)
                .Select(u=>u.Balance)
                .FirstOrDefaultAsync(ct);
        }
        public async Task<bool> UpdateBallance(int userId, double amount,CancellationToken ct) 
        { await _context.Users.Where (u=>u.Id==userId)
                .ExecuteUpdateAsync(s=>s.SetProperty(u=>u.Balance, amount), ct);
            return true;
        }
    }
}
