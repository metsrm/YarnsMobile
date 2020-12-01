using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YarnsMobile.Models;

namespace YarnsMobile.Database
{
    public class YarnsMobileContext : IdentityDbContext<Member>
    {
        public YarnsMobileContext(DbContextOptions<YarnsMobileContext> options) : base(options) { }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<PurchasedBook> PurchasedBooks { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
