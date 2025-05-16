using Organopedia3.Services;

namespace Organopedia3.Data
{
    public static class Items
    {
        // + MainPage -
        public static readonly TileItem Stops = new()
        {
            Title = "Stops",
            Description = "StopsDescription",
            ImagePath = "engler.png",
            Route = "DetailsItem",
            Param = "Stops"
        };

        public static readonly TileItem Windchests = new()
        {
            Title = "Windchests",
            Description = "WindchestsDescription",
            ImagePath = "wiatrownicastoz.png",
            Route = "DetailsItem",
            Param = "Windchests"
        };

        public static readonly TileItem Bellows = new()
        {
            Title = "Bellows",
            Description = "BellowsDescription",
            ImagePath = "miechklinowy.png",
            Route = "DetailsItem",
            Param = "Bellows"
        };

        public static readonly TileItem Actions = new()
        {
            Title = "Actions",
            Description = "ActionsDescription",
            ImagePath = "amkl.png",
            Route = "DetailsItem",
            Param = "Actions"
        };
        // - MainPage +

        // + DetailsPage +
        public static readonly TileItem LabialWoodenStops = new()
        {
            Title = "LabialWooden",
            Description = "LabialWoodenDescription",
            ImagePath = "piszczalkidrew.png",
            Route = "SubDetailPage",
            Param = "LabialWooden"
        };

        public static readonly TileItem LabialMetalStops = new()
        {
            Title = "LabialMetal",
            Description = "LabialMetalDescription",
            ImagePath = "prospekta.png",
            Route = "SubDetailPage",
            Param = "LabialMetal"
        };

        public static readonly TileItem ReedStops = new()
        {
            Title = "Reed",
            Description = "ReedDescription",
            ImagePath = "jezykib.png",
            Route = "SubDetailPage",
            Param = "Reed"
        };

        public static readonly TileItem ChestWindchest = new()
        {
            Title = "ChestWindchest",
            Description = "ChestWindchestDescription",
            ImagePath = "wip.png",
            Route = "SubDetailPage",
            Param = "ChestWindchest"
        };

        public static readonly TileItem ToneWindchest = new()
        {
            Title = "ToneWindchest",
            Description = "ToneWindchestDescription",
            ImagePath = "wiatrownicastoz.png",
            Route = "SubDetailPage",
            Param = "ToneWindchest"
        };

        public static readonly TileItem RegisterWindchest = new()
        {
            Title = "RegisterWindchest",
            Description = "RegisterWindchestDescription",
            ImagePath = "wip.png",
            Route = "SubDetailPage",
            Param = "RegisterWindchest"
        };

        public static readonly TileItem WedgeBellows = new() // Miech klinowy (OLESZNA)
        {
            Title = "WedgeBellows",
            Description = "WedgeBellowsDescription",
            ImagePath = "miechklinowy.png",
            Route = "SubDetailPage",
            Param = "WedgeBellows"
        };

        public static readonly TileItem HorizontalBellows = new() // Miech poziomy (AMKL)
        {
            Title = "HorizontalBellows",
            Description = "HorizontalBellowsDescription",
            ImagePath = "wip.png",
            Route = "SubDetailPage",
            Param = "HorizontalBellows"
        };

        public static readonly TileItem FloatBellows = new() // Miech pływakowy
        {
            Title = "FloatBellows",
            Description = "FloatBellowsDescription",
            ImagePath = "miechplywak.png",
            Route = "SubDetailPage",
            Param = "FloatBellows"
        };

        public static readonly TileItem TrackerAction = new()
        {
            Title = "TrackerAction",
            Description = "TrackerActionDescription",
            ImagePath = "trakturamecha.png",
            Route = "SubDetailPage",
            Param = "TrackerAction"
        };

        public static readonly TileItem PneumaticAction = new()
        {
            Title = "PneumaticAction",
            Description = "PneumaticActionDescription",
            ImagePath = "trakturapneua.png",
            Route = "SubDetailPage",
            Param = "PneumaticAction"
        };

        public static readonly TileItem ElectricAction = new()
        {
            Title = "ElectricAction",
            Description = "ElectricActionDescription",
            ImagePath = "trakturaelektra.png",
            Route = "SubDetailPage",
            Param = "ElectricAction"
        };
        // - DetailsPage -

        // + SubDetailsPage +
        public static readonly SubDetailsItem LabialWoodenDetail = new()
        {
            Title = "LabialWooden",
            Description = "LabialWoodenDescription",
            MediaItems =
            [
                new MediaItem() { Source = "piszczalkidrew.png", IsVideo = false },
                new MediaItem() { Source = "piszczalkidrewb.png", IsVideo = false },
                new MediaItem() { Source = "piszczalkidrewc.png", IsVideo = false },
                new MediaItem() { Source = "piszczalkidrewd.png", IsVideo = false }
            ]
        };

        public static readonly SubDetailsItem LabialMetalDetail = new()
        {
            Title = "LabialMetal",
            Description = "LabialMetalDescription",
            MediaItems =
            [
                new MediaItem() { Source = "prospekta.png", IsVideo = false },
                new MediaItem() { Source = "prospektb.png", IsVideo = false },
                new MediaItem() { Source = "prospektc.png", IsVideo = false },
                new MediaItem() { Source = "prospektd.png", IsVideo = false },
                new MediaItem() { Source = "engler.png", IsVideo = false }
            ]
        };

        public static readonly SubDetailsItem ReedDetail = new()
        {
            Title = "Reed",
            Description = "ReedDescription",
            MediaItems =
            [
                new MediaItem() { Source = "jezyki.png", IsVideo = false },
                new MediaItem() { Source = "jezykib.png", IsVideo = false },
                new MediaItem() { Source = "jezykic.png", IsVideo = false }
            ]
        };

        public static readonly SubDetailsItem ChestWindchestDetail = new()
        {
            Title = "ChestWindchest",
            Description = "ChestWindchestDescription",
            MediaItems =
            [
                new MediaItem() { Source = "logo_transparent.png", IsVideo = false }
            ]
        };

        public static readonly SubDetailsItem ToneWindchestDetail = new()
        {
            Title = "ToneWindchest",
            Description = "ToneWindchestDescription",
            MediaItems =
            [
                new MediaItem() { Source = "wiatrownicastoz.png", IsVideo = false },
                new MediaItem() { Source = "trakturapneuc.png", IsVideo = false }
            ]
        };

        public static readonly SubDetailsItem RegisterWindchestDetail = new()
        {
            Title = "RegisterWindchest",
            Description = "RegisterWindchestDescription",
            MediaItems =
            [
                new MediaItem() { Source = "logo_transparent.png", IsVideo = false }
            ]
        };

        public static readonly SubDetailsItem TrackerActionDetail = new()
        {
            Title = "TrackerAction",
            Description = "TrackerActionDescription",
            MediaItems =
            [
                new MediaItem() { Source = "amkl.png", IsVideo = false },
                new MediaItem() { Source = "trakturamecha.png", IsVideo = false },
                new MediaItem() { Source = "trakturamechb.png", IsVideo = false },
                new MediaItem() { Source = "trakturamechc.png", IsVideo = false },
                new MediaItem() { Source = "trakturamechd.png", IsVideo = false },
                new MediaItem() { Source = "trakturameche.png", IsVideo = false },
                new MediaItem() { Source = "trakturamechf.png", IsVideo = false },
                new MediaItem() { Source = "trakturamechg.png", IsVideo = false },
                new MediaItem() { Source = "trakturamechh.png", IsVideo = false }
            ]
        };

        public static readonly SubDetailsItem PneumaticActionDetail = new()
        {
            Title = "PneumaticAction",
            Description = "PneumaticActionDescription",
            MediaItems =
            [
                new MediaItem() { Source = "trakturapneua.png", IsVideo = false },
                new MediaItem() { Source = "trakturapneub.png", IsVideo = false },
                new MediaItem() { Source = "trakturapneuc.png", IsVideo = false },
                new MediaItem() { Source = "trakturapneud.png", IsVideo = false },
                new MediaItem() { Source = "trakturapneue.png", IsVideo = false },
                new MediaItem() { Source = "trakturapneuf.png", IsVideo = false }
            ]
        };

        public static readonly SubDetailsItem ElectricActionDetail = new()
        {
            Title = "ElectricAction",
            Description = "ElectricActionDescription",
            MediaItems =
            [
                new MediaItem() { Source = "trakturaelektra.png", IsVideo = false },
                new MediaItem() { Source = "trakturaelektrb.png", IsVideo = false },
                new MediaItem() { Source = "trakturaelektrc.png", IsVideo = false },
                new MediaItem() { Source = "trakturaelektrd.png", IsVideo = false }
            ]
        };

        public static readonly SubDetailsItem FloatBellowsDetail = new()
        {
            Title = "FloatBellows",
            Description = "FloatBellowsDescription",
            MediaItems =
            [
                new MediaItem() { Source = "miechplywak.png", IsVideo = false },
                new MediaItem() { Source = "miechplywakb.png", IsVideo = false },
                new MediaItem() { Source = "miechplywakc.png", IsVideo = false }
            ]
        };

        public static readonly SubDetailsItem HorizontalBellowsDetail = new()
        {
            Title = "HorizontalBellows",
            Description = "HorizontalBellowsDescription",
            MediaItems =
            [
                new MediaItem() { Source = "logo_transparent.png", IsVideo = false }
            ]
        };

        public static readonly SubDetailsItem WedgeBellowsDetail = new()
        {
            Title = "WedgeBellows",
            Description = "WedgeBellowsDescription",
            MediaItems =
            [
                new MediaItem() { Source = "miechklinowy.png", IsVideo = false },
                new MediaItem() { Source = "miechklinowyb.png", IsVideo = false }
            ]
        };
        // - SubDetailsPage -

        public static void GenerateTiles(List<TileItem> tiles, VerticalStackLayout tilesContainer)
        {
            tilesContainer.Children.Clear();

            foreach (var item in tiles)
            {
                tilesContainer.Children.Add(CreateTile(item));
            }
        }

        public static Border CreateTile(TileItem item)
        {
            var title = new Label
            {
                Text = LocalizationResourceManager.Instance[item.Title],
                FontAttributes = FontAttributes.Bold,
                Margin = 0,
                Padding = new Thickness(10, 5),
                TextColor = (Color)Application.Current!.Resources["AccentColor"],
                Shadow = new Shadow()
                {
                    Offset = new Point(1, 1),
                    Radius = 0,
                    Brush = new SolidColorBrush((Color)Application.Current!.Resources["TextColor"])
                }
            };

            var desc = new Label
            {
                Text = LocalizationResourceManager.Instance[item.Description],
                LineBreakMode = LineBreakMode.WordWrap,
                MaxLines = 4,
                Margin = 0,
                Padding = new Thickness(10, 5)
            };

            var content = new StackLayout
            {
                Children = { title, desc },
                VerticalOptions = LayoutOptions.Start,
                Margin = 0,
                Padding = 0,
                BackgroundColor = (Color)Application.Current!.Resources["AddBackgroundColor"]
            };

            var imagePath = item.ImagePath.Equals(string.Empty) ? "engler.png" :
                            item.ImagePath.Equals("logo.png") ? "engler.png" :
                            item.ImagePath.Equals("wip.png") ? "engler.png" : item.ImagePath;

            var background = new Image
            {
                Source = imagePath,
                Aspect = Aspect.AspectFill,
                HeightRequest = 250
            };

            var grid = new Grid();
            grid.Children.Add(background);
            grid.Children.Add(content);

            var border = new Border
            {
                Content = grid,
                AutomationId = LocalizationResourceManager.Instance[item.Title]
            };

            // Dla wymuszenia AutomationId
            SemanticProperties.SetDescription(border, "Tile");
            border.IsEnabled = true;

            var tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped += (s, e) => OnTileTapped(item);
            border.GestureRecognizers.Add(tapGesture);

            return border;
        }

        public static async void OnTileTapped(TileItem item)
        {
            await Shell.Current.GoToAsync($"{item.Route}?title={item.Param}");
        }
    }
}
