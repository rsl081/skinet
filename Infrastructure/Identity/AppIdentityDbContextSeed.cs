using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Russel",
                    Email = "russel@test.com",
                    UserName = "russel@test.com",
                    Address = new Address
                    {
                        FirstName = "Russel",
                        LastName = "Rodriguez",
                        Street = "10 the street",
                        City = "San Rafael",
                        State = "SR",
                        ZipCode = "3008"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}