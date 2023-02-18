using Magic_Card_Random.Data.Models;
using Magic_Card_Random.Data.Services;

namespace Magic_Card_Random.Pages;

public partial class Search : ContentPage
{
    private ApiService _apiService;

    public Search()
    {
        _apiService = new ApiService();
        InitializeComponent();
    }

    private async void searchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        string searchText = searchBar.Text;

        Card card = await _apiService.GetCardByName(searchText);

        if (string.IsNullOrEmpty(card.idCard))
        {
            lblNotFound.IsVisible = true;
        }
        else
        {
            await Navigation.PushAsync(new MainPage(card));
            searchBar.Unfocus();
            lblNotFound.IsVisible = false;
        }
    }
}