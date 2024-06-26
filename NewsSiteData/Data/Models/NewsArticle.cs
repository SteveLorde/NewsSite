﻿using NewsSiteData.Data.Models;

namespace NewsWebsiteServerApp.Data.Models;

public class NewsArticle
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public DateTime Createdon { get; set; } = DateTime.Now;
    public Guid CategoryId { get; set; }
    public Category Category { get; set; }
}