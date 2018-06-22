using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNETCore2MVC.Security;
using Microsoft.Extensions.DependencyInjection;

namespace ASPNETCore2MVC.Models
{
    public static class SeedData
    {
        public static void Initialize(EFContext context)
        {
            context.Database.EnsureCreated();
            if (!context.User.Any())
            {
                context.User.Add(new User() { FullName = "Tuan Nguyen", JoingDate = DateTime.Now.AddDays(-4), Password = Utilities.Encrypt("123456"), UserName="tuan", Role="BA" });
                context.User.Add(new User() { FullName = "Steven Nguyen", JoingDate = DateTime.Now.AddYears(-1), Password = Utilities.Encrypt("123456"), UserName = "steven", Role = "AD" });
                context.SaveChanges(); 
            }
        }
    }
}
