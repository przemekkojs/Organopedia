using System.ComponentModel;
using System.Globalization;
using System.Resources;

namespace Organopedia3.Services
{
    public partial class LocalizationResourceManager : INotifyPropertyChanged
    {
        private static LocalizationResourceManager? _instance;

        public static LocalizationResourceManager Instance =>
            _instance ??= new LocalizationResourceManager(Resources.Resources.ResourceManager);

        private readonly ResourceManager _resourceManager;
        private CultureInfo _currentCulture = CultureInfo.CurrentUICulture;

        public event PropertyChangedEventHandler? PropertyChanged;

        private LocalizationResourceManager(ResourceManager resourceManager)
        {
            _resourceManager = resourceManager;
        }

        public string this[string text] => _resourceManager.GetString(text, _currentCulture) ?? "Undefined";

        public void SetCulture(string cultureName)
        {
            var cultureInfo = new CultureInfo(cultureName);
            SetCulture(cultureInfo);
        }

        public void SetCulture(CultureInfo culture)
        {
            Thread.CurrentThread.CurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;

            _currentCulture = culture;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(null));
        }

        public CultureInfo CurrentCulture => _currentCulture;
    }
}
