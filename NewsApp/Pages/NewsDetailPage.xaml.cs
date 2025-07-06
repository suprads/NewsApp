using NewsApp.Models;
using NewsApp.Services;

namespace NewsApp.Pages;

public partial class NewsDetailPage : ContentPage
{
    public NewsDetailPage(Article article)
	{
		InitializeComponent();
		LblArticleTitle.Text = article.Title;
		LblImage.Source = article.Image;
        LblDetails.Text = article.Content;
	}
}