using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCore2MVC.IService;
using ASPNETCore2MVC.Models;
using ASPNETCore2MVC.Security;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCore2MVC.Service
{
    public class UserService: IUserService
    {
        private readonly EFContext _context;
        public UserService(EFContext context)
        {
            _context = context;
        }
        public async Task<User> ValidateUser(string userName, string password)
        {
            string passwordHash = Utilities.Encrypt(password);
            var model = await _context.User.Where(x => x.UserName == userName && x.Password == passwordHash).FirstOrDefaultAsync();
            return model;
        } 
        public async Task<User> GetUser(int id)
        {
            var result = await _context.User.Where(x => x.ID == id).FirstOrDefaultAsync();
            return result;
        }
    }
}
