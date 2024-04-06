using GenericRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newsletter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newsletter.Infrastucture.Context;
internal sealed class ApplicationDbContext : IdentityDbContext<AppUser, IdentityRole<Guid>, Guid>,IUnitOfWork
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Blog> Blogs { get; set; }  
    public DbSet<Subscribe>Subscribe {  get; set; } 
}
