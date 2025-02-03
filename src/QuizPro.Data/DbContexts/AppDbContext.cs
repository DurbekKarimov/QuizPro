using Microsoft.EntityFrameworkCore;
using QuizPro.Domain.Entities;

namespace QuizPro.Data.DbContexts;

public  class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Answear> Answears { get; set; }
    public DbSet<Question> Questions { get; set; }  
    public DbSet<Result> Results { get; set; }
    public DbSet<Topic> Topics { get; set; }
}
