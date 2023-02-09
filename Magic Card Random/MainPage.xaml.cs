using Magic_Card_Random.Data.Models;
using Magic_Card_Random.Data.Services;
using System.Text.RegularExpressions;

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
        FillInfoCard(card);
        GenerateImageManaCard(card);
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

        FillInfoCard(card);
        GenerateImageManaCard(card);
    }

    #region Private Methods

    private void GenerateImageManaCard(Card card)
    {
        var manasCard = new Regex(@"{([A-Za-z0-9\-]+)}")
        .Matches(card.mana_cost)
        .Cast<Match>()
        .Select(m => m.Groups[0].Value)
        .ToList();
        foreach (var mana in manasCard)
        {
            Image Mana = new Image
            {
                HeightRequest = 18,
                Margin = 2,
                Source = GetImageMana(mana)
            };
            hslMana.Children.Add(Mana);
        }

    }

    private string GetImageMana(string mana)
    {
        var manaValue = string.Empty;

        switch (mana)
        {
            case string a when a.Contains("G"):
                manaValue = "green.svg";
                return manaValue;
            case string a when a.Contains("W"):
                manaValue = "white.svg";
                return manaValue;
            case string a when a.Contains("U"):
                manaValue = "blue.svg";
                return manaValue;
            case string a when a.Contains("B"):
                manaValue = "black.svg";
                return manaValue;
            case string a when a.Contains("R"):
                manaValue = "red.svg";
                return manaValue;
            case string a when a.Contains("0"):
                manaValue = "red.svg";
                return manaValue;
            case string a when a.Contains("1"):
                manaValue = "one.svg";
                return manaValue;
            case string a when a.Contains("2"):
                manaValue = "two.svg";
                return manaValue;
            case string a when a.Contains("3"):
                manaValue = "three.svg";
                return manaValue;
            case string a when a.Contains("4"):
                manaValue = "four.svg";
                return manaValue;
            case string a when a.Contains("5"):
                manaValue = "five.svg";
                return manaValue;
            case string a when a.Contains("6"):
                manaValue = "six.svg";
                return manaValue;
            case string a when a.Contains("7"):
                manaValue = "seven.svg";
                return manaValue;
            case string a when a.Contains("8"):
                manaValue = "eight.svg";
                return manaValue;
            case string a when a.Contains("9"):
                manaValue = "nine.svg";
                return manaValue;
            case string a when a.Contains("X"):
                manaValue = "xx.svg";
                return manaValue;
            case string a when a.Contains("W/U"):
                manaValue = "wu.svg";
                return manaValue;
            case string a when a.Contains("W/B"):
                manaValue = "wb.svg";
                return manaValue;
            case string a when a.Contains("B/R"):
                manaValue = "br.svg";
                return manaValue;
            case string a when a.Contains("B/G"):
                manaValue = "bg.svg";
                return manaValue;
            case string a when a.Contains("U/B"):
                manaValue = "ub.svg";
                return manaValue;
            case string a when a.Contains("U/R"):
                manaValue = "ur.svg";
                return manaValue;
            case string a when a.Contains("R/G"):
                manaValue = "rg.svg";
                return manaValue;
            case string a when a.Contains("R/W"):
                manaValue = "rw.svg";
                return manaValue;
            case string a when a.Contains("G/W"):
                manaValue = "gw.svg";
                return manaValue;
            case string a when a.Contains("B/G/P"):
                manaValue = "bgp.svg";
                return manaValue;
            case string a when a.Contains("B/R/P"):
                manaValue = "brp.svg";
                return manaValue;
            case string a when a.Contains("G/U/P"):
                manaValue = "gup.svg";
                return manaValue;
            case string a when a.Contains("G/W/P"):
                manaValue = "gwp.svg";
                return manaValue;
            case string a when a.Contains("R/G/P"):
                manaValue = "rgp.svg";
                return manaValue;
            case string a when a.Contains("R/W/P"):
                manaValue = "rwp.svg";
                return manaValue;
            case string a when a.Contains("U/B/P"):
                manaValue = "ubp.svg";
                return manaValue;
            case string a when a.Contains("U/R/P"):
                manaValue = "urp.svg";
                return manaValue;
            case string a when a.Contains("W/B/P"):
                manaValue = "wbp.svg";
                return manaValue;
            case string a when a.Contains("W/U/P"):
                manaValue = "wup.svg";
                return manaValue;
            case string a when a.Contains("2/W"):
                manaValue = "ww.svg";
                return manaValue;
            case string a when a.Contains("2/U"):
                manaValue = "uu.svg";
                return manaValue;
            case string a when a.Contains("2/B"):
                manaValue = "bb.svg";
                return manaValue;
            case string a when a.Contains("2/R"):
                manaValue = "rr.svg";
                return manaValue;
            case string a when a.Contains("2/G"):
                manaValue = "gg.svg";
                return manaValue;
            case string a when a.Contains("W/P"):
                manaValue = "wp.svg";
                return manaValue;
            case string a when a.Contains("U/P"):
                manaValue = "up.svg";
                return manaValue;
            case string a when a.Contains("B/P"):
                manaValue = "bp.svg";
                return manaValue;
            case string a when a.Contains("R/P"):
                manaValue = "rp.svg";
                return manaValue;
            case string a when a.Contains("G/P"):
                manaValue = "gp.svg";
                return manaValue;
            default:
                manaValue = mana;
                return manaValue;

        }
    }

    private void FillInfoCard(Card card)
    {
        lblNameCard.Text = card.nameCard;
        if (!string.IsNullOrEmpty(card.flavor_text))
        {
            lblDescription.IsVisible = true;
            lblDescription.Text = card.flavor_text;
        }
        else
        {
            lblDescription.Text = string.Empty;
        }

        lblTypeCard.Text = card.type_line;
        lblHabilityCard.Text = card.oracle_text;
        lblNameCardPrice.Text = card.nameCard;
        if (!string.IsNullOrEmpty(card.prices.usd))
        {
            lblPriceUsd.Text = card.prices.usd;
            lblPriceUsd.IsEnabled = true;
            lblPriceUsd.IsVisible = true;
        }
        else
        {
            lblPriceUsd.Text = string.Empty;
            lblPriceUsd.IsEnabled = false;
            lblPriceUsd.IsVisible = false;
        }
        if (!string.IsNullOrEmpty(card.prices.eur))
        {
            lblPriceEu.Text = card.prices.eur;
            lblPriceEu.IsEnabled = true;
            lblPriceEu.IsVisible = true;
        }
        else
        {
            lblPriceEu.Text = string.Empty;
            lblPriceEu.IsEnabled = false;
            lblPriceEu.IsVisible = false;
        }
        if (!string.IsNullOrEmpty(card.prices.tix))
        {
            lblPriceTix.Text = card.prices.tix;
            lblPriceTix.IsEnabled = true;
            lblPriceTix.IsVisible = true;
        }
        else
        {
            lblPriceTix.Text = string.Empty;
            lblPriceTix.IsEnabled = false;
            lblPriceTix.IsVisible = false;
        }
        hslMana.Children.Clear();
    }

    private async void lblPrice_Clicked(object sender, EventArgs e)
    {
        try
        {
            Card card = await _apiService.GetCardByName(lblNameCard.Text);
            Button btnPrice = (Button)sender;
            Uri uri = null;

            switch (btnPrice.StyleClass[0].ToString())
            {
                case string a when a.Contains("lblPriceUsd"):
                    uri = new Uri(card.purchase_uris.tcgplayer);
                    break;
                case string a when a.Contains("lblPriceEu"):
                    uri = new Uri(card.purchase_uris.cardmarket);
                    break;
                case string a when a.Contains("lblPriceTix"):
                    uri = new Uri(card.purchase_uris.cardhoarder);
                    break;
                default:
                    break;
            }
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        catch (Exception)
        {
            throw;
        }
    }

    #endregion
}

