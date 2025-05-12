using Organopedia3.Services;

namespace Organopedia3.Pages;

public partial class Accessibility : ContentPage
{
	public Accessibility()
	{
		InitializeComponent();

        FontSizePicker.SelectedIndex = 1;
	}

    private void OnContrastToggleClicked(object sender, EventArgs e)
    {
        var nextTheme = App.CurrentTheme switch
        {
            "Light" => "Dark",
            "Dark" => "HighContrast",
            "HighContrast" => "Light",
            _ => "Light"
        };

        App.SetTheme(nextTheme);
        Application.Current!.Windows[0].Page = new AppShell();
    }

    private void FontSizePicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        var selected = FontSizePicker.SelectedItem?.ToString();

        if (selected == Organopedia3.Resources.Resources.Small)
            FontSizeService.SetFontSize(14);
        else if (selected == Organopedia3.Resources.Resources.Medium)
            FontSizeService.SetFontSize(16);
        else if (selected == Organopedia3.Resources.Resources.Large)
            FontSizeService.SetFontSize(20);
    }
}