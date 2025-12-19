using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Core.UserAgg.Service
{
    public interface IApplicationUserService
    {
        Task<double> GetBallance(int userId, CancellationToken ct);
        Task<bool> UpdateBallance(int userId, double ballance, CancellationToken ct);
    }
}
