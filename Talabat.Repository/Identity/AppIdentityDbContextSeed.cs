
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entities.Identity;

namespace Talabat.Repository.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new AppUser()
                {
                    DisplayName = "Mohamed Shahin",
                    Email = "mohamed55shahin99@gmail.com",
                    UserName = "Mohamed.shahin",
                    Address = new Address()
                    {
                        FirstName = "Mohamed",
                        LastName = "Shahin",
                        Country = "Egypt",
                        City = "Giza",
                        Street = "10 Tahrir St."
                    }
                };
                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}
