using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspNetCoreMvc.Models.System;

namespace AspNetCoreMvc.Data
{
    public class AspNetCoreMvcContext : DbContext
    {
        public AspNetCoreMvcContext (DbContextOptions<AspNetCoreMvcContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
    }
}
