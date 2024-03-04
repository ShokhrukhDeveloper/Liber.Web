using Liber.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Liber.Api.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Session> Sessions { get; set; }
    public DbSet<Password>Passwords{get;set;}
    public DbSet<Category> Categories { get; set; }
    public DbSet<SubCategory> Subjects { get; set; }
    
}