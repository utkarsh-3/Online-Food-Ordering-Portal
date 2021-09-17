using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EatFit.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EatFit.Data
{
    public class EatFitContext : IdentityDbContext<EatFitUser>
    {
        public EatFitContext(DbContextOptions<EatFitContext> options)
            : base(options)
        {
        }
       

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
        }
    }
}
