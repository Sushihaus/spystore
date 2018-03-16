using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;


namespace WebApplication1.EF
{
    public class StoreContext : DbContext
    {
        public StoreContext()
        {
        }
        public StoreContext(DbContextOptions options) : base(options)
        {
        }
    }
}
