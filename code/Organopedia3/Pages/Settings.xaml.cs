using Organopedia3.Services;

namespace Organopedia3.Pages;

public partial class Settings : ContentPage
{
	public Settings()
	{
		InitializeComponent();
	}

    private void OnLanguageChangeClicked(object sender, EventArgs e)
    {
        var current = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
        var next = current == "pl" ? "en" : "pl";

        LocalizationResourceManager.Instance.SetCulture(next);
        Preferences.Set("AppLanguage", next);

        Application.Current!.Windows[0].Page = new AppShell();
    }

    private async void OnPrivacyPolicyClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("PrivacyPolicy");
    }
}