
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class MyDbContext : IdentityDbContext<User>
    {

        public MyDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
