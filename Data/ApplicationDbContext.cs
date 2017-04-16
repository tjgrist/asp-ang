using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TutorialHub.Models;

namespace TutorialHub.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Post> Posts { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public static void Seed(IApplicationBuilder app) {
            using (var context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>()){
                if (context.Posts.Any()){
                    return;
                }
                context.AddRange(
                new Post { Body = "This is a story ", Created = DateTime.Now, Views = 5 },
                new Post { Body = "Some great tutorial", Created = DateTime.Now, Views = 7 },
                new Post { Body = "json to be sent to front end framework", Created = DateTime.Now, Views = 45 },
                new Post { Body = "full stack motherfucker", Created = DateTime.Now, Views = 89 }
                );
                context.SaveChangesAsync();
            }
        }
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}