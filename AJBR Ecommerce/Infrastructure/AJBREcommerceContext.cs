using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AJBR_Ecommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace AJBR_Ecommerce.Infrastructure
{
    public class AJBREcommerceContext:DbContext
    {
        public AJBREcommerceContext(DbContextOptions<AJBREcommerceContext>options):base(options)
        {

        }

        public DbSet<Page> Pages { get; set; }
    }
}
