using Microsoft.EntityFrameworkCore;

namespace QuizPro.Data.DbContexts;

public  class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

}
