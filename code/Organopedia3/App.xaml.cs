using Organopedia3.Resources.Styles;
using Organopedia3.Services;
using System.Diagnostics;

namespace Organopedia3
{
    public partial class App : Application
    {
        public static string CurrentTheme { get; set; } = "Light";

        public App()
        {
            //InitializeComponent();

            //string savedLang = Preferences.Get("AppLanguage", "pl");
            //LocalizationResourceManager.Instance.SetCulture(savedLang);
            //Current!.Resources["Loc"] = LocalizationResourceManager.Instance;
            //FontSizeService.LoadFontSize();

            //CurrentTheme = Preferences.Get("AppTheme", "Unspecified");
            //SetTheme(CurrentTheme);

            try
            {
                InitializeComponent();

                string savedLang = Preferences.Get("AppLanguage", "pl");
                LocalizationResourceManager.Instance.SetCulture(savedLang);
                Current!.Resources["Loc"] = LocalizationResourceManager.Instance;
                FontSizeService.LoadFontSize();

                CurrentTheme = Preferences.Get("AppTheme", "Unspecified");
                SetTheme(CurrentTheme);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Initialization error: {ex.Message}");
            }
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }

        public static void SetTheme(string theme)
        {
            ResourceDictionary themeDict = theme switch
            {
                "Dark" => new ColorsDark(),
                "HighContrast" => new ColorsHighContrast(),
                _ => new ColorsLight(),
            };

            CurrentTheme = theme;

            Preferences.Set("AppTheme", theme);
            Current!.Resources.MergedDictionaries.Clear();
            Current!.Resources.MergedDictionaries.Add(themeDict);
            Current!.Resources.MergedDictionaries.Add(new MainStyles());
        }
    }
}