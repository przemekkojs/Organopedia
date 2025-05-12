namespace Organopedia3.Pages;

[QueryProperty(nameof(Source), "source")]
public partial class VideoPage : ContentPage
{
    public VideoPage()
    {
        InitializeComponent();
    }
    

    private string? source;
    public string Source
    {
        get => source!;
        set
        {
            source = $"file:///android_asset/{value}";
            videoPlayer.Source = source;
        }
    }

    private async void OnCloseTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}