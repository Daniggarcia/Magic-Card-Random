using Magic_Card_Random.Data.Models;
using Magic_Card_Random.Data.Services;
using Microsoft.Maui.Graphics;

namespace Magic_Card_Random;

public partial class MainPage : ContentPage
{
    private ApiService _apiService;

    public MainPage()
    {
        _apiService = new ApiService();
        InitializeComponent();
    }

    public MainPage(Card card)
    {
        InitializeComponent();
        BackBtn.IsVisible = true;
        RandomBtn.IsVisible = false;
        FavoriteCard(card);
    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        if (imgCard.Source == null)
        {
            await ImageCard();
        }
    }

    private async void RandomBtn_Clicked(object sender, EventArgs e)
    {
        await ImageCard();
    }

    private void FavoriteCard(Card card)
    {
        imgCard.Source = new UriImageSource
        {
            Uri = new Uri(card.image_uris.normal),
            CachingEnabled = true,
            CacheValidity = TimeSpan.FromDays(1)
        };
        lblNameCard.Text = card.nameCard;
        lblDescription.Text = card.flavor_text;
    }

    private async void BackBtn_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    private async Task ImageCard()
    {
        Card card = await _apiService.GetRandomCard();
        imgCard.Source = new UriImageSource
        {
            Uri = new Uri(card.image_uris.normal),
            CachingEnabled = true,
            CacheValidity = TimeSpan.FromDays(1)
        };
        lblNameCard.Text = $"{card.nameCard} {card.mana_cost}";
        lblDescription.Text = card.flavor_text;
    }
}

