using Organopedia3.Data;
using Organopedia3.Services;

namespace Organopedia3.Pages;

[QueryProperty(nameof(TitleParam), "title")]
public partial class DetailPage : ContentPage
{
    private string? _titleParam;
    private bool isExpanded = true;

    public string TitleParam
    {
        get => _titleParam!;
        set
        {
            _titleParam = value;
            InitializePage();
        }
    }

    private readonly List<TileItem> stops = 
    [
        Items.LabialWoodenStops,
        Items.LabialMetalStops,
        Items.ReedStops
    ];

    private readonly List<TileItem> actions =
    [
        Items.TrackerAction,
        Items.PneumaticAction,
        Items.ElectricAction
    ];

    private readonly List<TileItem> bellows =
    [
        Items.WedgeBellows,
        Items.FloatBellows,
        Items.HorizontalBellows
    ];

    private readonly List<TileItem> windchests =
    [
        Items.ChestWindchest,
        Items.RegisterWindchest,
        Items.ToneWindchest
    ];

    private List<TileItem> tileData = [];

    public DetailPage()
	{
		InitializeComponent();
	}

    private void InitializePage()
    {
        if (string.IsNullOrWhiteSpace(TitleParam))
            return;

        titleLabel.Text = LocalizationResourceManager.Instance[TitleParam];
        descriptionLabel.Text = LocalizationResourceManager.Instance[$"{TitleParam}Description"];
        tileData = TilesListByTitle(TitleParam);

        Items.GenerateTiles(tileData, tilesContainer);
    }

    private List<TileItem> TilesListByTitle(string title)
    {
        return title.ToLowerInvariant() switch
        {
            "stops" => stops,
            "windchests" => windchests,
            "actions" => actions,
            "bellows" => bellows,
            _ => throw new ArgumentException("Invalid tile name")
        };
    }

    private void OnSearchBarTextChanged(object sender, TextChangedEventArgs e)
    {
        string searchText = e.NewTextValue?.ToLowerInvariant() ?? string.Empty;

        var filtered = tileData
            .Where(x => x.Title.Contains(searchText, StringComparison.InvariantCultureIgnoreCase))
            .ToList();

        Items.GenerateTiles(filtered, tilesContainer);
    }

    private async void OnDescriptionTapped(object sender, EventArgs e)
    {
        isExpanded = !isExpanded;
        var text = LocalizationResourceManager.Instance[$"{TitleParam}Description"];
        string preview = text.Length > 100 ? text[..100].Trim() + "... " + LocalizationResourceManager.Instance["More"].ToLower() : text;

        // Fade out
        await descriptionLabel.FadeTo(0, 150, Easing.CubicIn);

        // Change text
        descriptionLabel.Text = isExpanded ? text : preview;

        // Fade in
        await descriptionLabel.FadeTo(1, 150, Easing.CubicOut);
    }
}