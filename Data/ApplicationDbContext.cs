using System;
using System.Collections.Generic;
using System.Text;
using demo_efcore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace demo_efcore.Data
{
   public class ApplicationDbContext : IdentityDbContext
   {
      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
      {

      }
   }
}
