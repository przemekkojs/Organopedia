namespace Organopedia3.Pages;

[QueryProperty(nameof(Source), "source")]
public partial class ImagePage : ContentPage
{
    public ImagePage()
    {
        InitializeComponent();
    }

    private string? source;
    public string Source
    {
        get => source!;
        set
        {
            source = Uri.UnescapeDataString(value);
            imageView.Source = source;
        }
    }

    private void OnPinchUpdated(object sender, PinchGestureUpdatedEventArgs e)
    {
        var image = sender as Image;

        if (image != null)
        {
            if (e.Status == GestureStatus.Started)
                image.ScaleTo(image.Scale * e.Scale);
            else if (e.Status == GestureStatus.Running)
                image.Scale = image.Scale * e.Scale;
        }
    }

    private async void OnCloseTapped(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}