using INANDout.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INANDout.Folder_1_Data
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext>options) : base(options)
        {

        }
        public DbSet<item> Items { get; set; }
    }
}
