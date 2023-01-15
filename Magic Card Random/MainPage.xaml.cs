using Magic_Card_Random.Data.Models;
using Magic_Card_Random.Data.Services;

namespace Magic_Card_Random;

public partial class MainPage : ContentPage
{
    private ApiService _apiService;

    public MainPage()
    {
        _apiService = new ApiService();
        InitializeComponent();
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        if (imgCard.Source == null)
        {
            Card card = await _apiService.GetRandomCard();
            imgCard.Source = new UriImageSource
            {
                Uri = new Uri(card.image_uris.normal),
                CachingEnabled = true,
                CacheValidity = TimeSpan.FromDays(1)
            };
        }
    }

    private async void CounterBtn_Clicked(object sender, EventArgs e)
    {
        Card card = await _apiService.GetRandomCard();
        imgCard.Source = new UriImageSource
        {
            Uri = new Uri(card.image_uris.normal),
            CachingEnabled = true,
            CacheValidity = TimeSpan.FromDays(1)
        };
        lblNameCard.Text = card.nameCard;
        lblDescription.Text = card.flavor_text;
    }
}

