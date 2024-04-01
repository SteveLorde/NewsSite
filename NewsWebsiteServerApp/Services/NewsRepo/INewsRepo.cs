using NewsSiteData.Data.DTOs;

namespace NewsWebsiteServerApp.Services.NewsRepo;

public interface INewsRepo
{
    public Task GetAllNewS();
    public Task GetCategories();
    public Task GetCategoryNewsArticles(string categoryid);
    public Task GetNewsArticle(string articleid);
    public Task AddNewsArticle(AddNewsArticleRequestDTO newarticlerequest);
    
}