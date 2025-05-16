namespace Organopedia3.Services
{
    public static class FontSizeService
    {
        public const string FontSizeKey = "App_FontSize";

        public static void SetFontSize(double size)
        {
            Application.Current!.Resources["TextFontSize"] = size;
            Preferences.Set(FontSizeKey, size);
        }

        public static void LoadFontSize()
        {
            double savedSize = Preferences.Get(FontSizeKey, 16);
            Application.Current!.Resources["TextFontSize"] = savedSize;
        }
    }
}
