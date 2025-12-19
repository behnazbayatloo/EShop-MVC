using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.UserAgg.Data
{
    public interface IApplicationUserRepository
    {
        Task<double> GetBallance(int userId, CancellationToken ct);
        Task<bool> UpdateBallance(int userId, double amount, CancellationToken ct);
    }
}
