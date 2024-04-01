using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NewsWebsiteServerApp.Data.Models;

namespace NewsSiteData.Data;

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