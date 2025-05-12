using Organopedia3.Data;
using Organopedia3.Services;

namespace Organopedia3.Pages;

[QueryProperty(nameof(TitleParam), "title")]
public partial class SubDetailPage : ContentPage
{
    private string? _titleParam;
    private SubDetailsItem tileData = new();

    public string TitleParam
    {
        get => _titleParam!;
        set
        {
            _titleParam = value;
            InitializePage();
        }
    }

    public SubDetailPage()
	{
		InitializeComponent();
	}

    private void InitializePage()
    {
        if (string.IsNullOrWhiteSpace(TitleParam))
            return;

        titleLabel.Text = LocalizationResourceManager.Instance[TitleParam];
        descriptionLabel.Text = LocalizationResourceManager.Instance[$"{TitleParam}Description"];
        tileData = TitleToItem(TitleParam);
        GenerateMedia();
    }

    private void GenerateMedia()
    {
        mediaGallery.Children.Clear();

        foreach (var item in tileData.MediaItems)
        {
            View mediaView = new Image
            {
                Source = item.IsVideo ? "logo_transparent.png" : item.Source,
                WidthRequest = 100,
                HeightRequest = 100,
                Margin = 0,
                Aspect = Aspect.AspectFill
            };

            var tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped += (s, e) =>
            {
                OpenFullscreen(item);
            };
            mediaView.GestureRecognizers.Add(tapGesture);

            var border = new Border
            {
                Background = Colors.Transparent,
                Content = mediaView
            };

            mediaGallery.Children.Add(border);
        }
    }

    private static async void OpenFullscreen(MediaItem item)
    {
        if (item.IsVideo)
        {
            await Shell.Current.GoToAsync($"VideoPage?source={item.Source}");
        }
        else
        {
            await Shell.Current.GoToAsync($"ImagePage?source={Uri.EscapeDataString(item.Source)}");
        }
    }

    private static SubDetailsItem TitleToItem(string title)
    {
        return title.ToLowerInvariant() switch
        {
            "labialwooden" => Items.LabialWoodenDetail,
            "labialmetal" => Items.LabialMetalDetail,
            "reed" => Items.ReedDetail,

            "chestwindchest" => Items.ChestWindchestDetail,
            "tonewindchest" => Items.ToneWindchestDetail,
            "registerwindchest" => Items.RegisterWindchestDetail,

            "trackeraction" => Items.TrackerActionDetail,
            "pneumaticaction" => Items.PneumaticActionDetail,
            "electricaction" => Items.ElectricActionDetail,

            "floatbellows" => Items.FloatBellowsDetail,
            "horizontalbellows" => Items.HorizontalBellowsDetail,
            "wedgebellows" => Items.WedgeBellowsDetail,

            _ => throw new ArgumentException($"Nieznany tytu³: {title}")
        };
    }
}