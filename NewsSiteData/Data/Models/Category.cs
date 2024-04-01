using NewsWebsiteServerApp.Data.Models;

namespace NewsSiteData.Data.Models;

public class Category
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public List<NewsArticle> NewsArticles { get; set; }
}