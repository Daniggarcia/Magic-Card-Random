using Magic_Card_Random.Data.Models;
using Magic_Card_Random.Data.Services;
using System.Xml.Linq;

namespace Magic_Card_Random.Pages;

public partial class AboutMe : ContentPage
{
    private ApiService _apiService;

    public AboutMe()
    {
        _apiService = new ApiService();
        InitializeComponent();
    }

    private async void SocialsImageButton_Clicked(object sender, EventArgs e)
    {
        ImageButton ImgBtn = (ImageButton)sender;
        var socialImgBtn = ImgBtn.Source.ToString();
        Uri uri = null;

        switch (socialImgBtn)
        {

            case string a when a.Contains("linkedin"):
                uri = new Uri("https://www.linkedin.com/in/daniel-galvez-garcia/");
                break;
            case string a when a.Contains("github"):
                uri = new Uri("https://github.com/Daniggarcia");
                break;
            case string a when a.Contains("envelopesolid"):
                string subject = "Hello DMan!!";
                string body = "You're awesome DMan, I'm a Marton Stromgald fan too.";
                string[] recipients = new[] { "daniel.gg@zoho.com" };

                var message = new EmailMessage
                {
                    Subject = subject,
                    Body = body,
                    BodyFormat = EmailBodyFormat.PlainText,
                    To = new List<string>(recipients)
                };

                await Email.Default.ComposeAsync(message);
                break;


        }
        await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
    }

    private async void martonImage_Clicked(object sender, EventArgs e)
    {
        var nameCard = "MartonStromgald";
        Card card = await _apiService.GetCardByName(nameCard);
        await Navigation.PushModalAsync(new MainPage(card));
    }
}