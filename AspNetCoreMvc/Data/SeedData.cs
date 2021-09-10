using AspNetCoreMvc.Models.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreMvc.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AspNetCoreMvcContext(serviceProvider.GetRequiredService<DbContextOptions<AspNetCoreMvcContext>>()))
            {
                if (context.User.Any())
                {
                    return;
                }

                context.User.AddRange(
                    new User()
                    {
                        UserName = "admin",
                        Nickname = "管理员",
                        Password = "123456",
                        SecurityStamp = "202109102016",
                        Status = true,
                        Email = "admin@qq.com",
                    },
                    new User()
                    {
                        UserName = "normal",
                        Nickname = "普通用户",
                        Password = "123456",
                        SecurityStamp = "202109102018",
                        Status = true,
                        Email = "normal@qq.com"
                    });
                context.SaveChanges();
            }
        }
    }
}
