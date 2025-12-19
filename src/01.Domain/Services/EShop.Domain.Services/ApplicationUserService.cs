using EShop.Domain.Core.UserAgg.Data;
using EShop.Domain.Core.UserAgg.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShop.Domain.Services
{
    public class ApplicationUserService(IApplicationUserRepository _userRepo):IApplicationUserService
    {
        public async Task<double>   GetBallance(int userId,CancellationToken ct)=>await _userRepo.GetBallance(userId, ct);
        public async Task<bool> UpdateBallance (int userId,double ballance,CancellationToken ct)=>await _userRepo.UpdateBallance(userId, ballance, ct);
    }
}
