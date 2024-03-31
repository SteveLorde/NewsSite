using Microsoft.EntityFrameworkCore;
using NewsWebsiteServerApp.Data.Models;

namespace NewsWebsiteServerApp.Data;

public class DataContext : DbContext
{
    private readonly IConfiguration _config;

    public DataContext(IConfiguration config)
    {
        _config = config;
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(_config["DatabaseConnectionString"]);
    }
    
    
    public DbSet<NewsArticle> NewsArticles { get; set; }
    
    
}