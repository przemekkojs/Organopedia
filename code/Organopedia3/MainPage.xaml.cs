using Microsoft.Maui.Controls.Shapes;
using Organopedia3.Data;
using Organopedia3.Pages;
using Organopedia3.Services;

namespace Organopedia3
{
    public partial class MainPage : SwipeEnablePage
    {
        private readonly List<TileItem> tileData =
        [
            Items.Stops,
            Items.Windchests,
            Items.Actions,
            Items.Bellows
        ];

        public MainPage()
        {
            InitializeComponent();
            Items.GenerateTiles(tileData, tilesContainer);
        }

        public void OnSearchBarTextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = e.NewTextValue?.ToLowerInvariant() ?? string.Empty;

            var filtered = tileData
                .Where(x => x.Title.Contains(searchText, StringComparison.InvariantCultureIgnoreCase))
                .ToList();

            Items.GenerateTiles(filtered, tilesContainer);
        }
    }
}
