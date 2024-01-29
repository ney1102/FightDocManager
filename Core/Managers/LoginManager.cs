using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using Model.Context;
using Model.Entity.User;

namespace Core.Managers
{
    
    public class LoginManager : ILoginManager
    {
        private readonly AppDbContext _appDbContext;
        public LoginManager(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<bool> LoginAsync(string email, string password)
        {
            var user = await _appDbContext.Users.FirstOrDefaultAsync(u => u.email == email && u.password == password);
            return user != null;
        }

        public Task<bool> LogoutAsync()
        {
            throw new NotImplementedException();
        }
    }
}
