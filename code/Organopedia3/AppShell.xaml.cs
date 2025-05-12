using Organopedia3.Pages;

namespace Organopedia3
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("DetailsItem", typeof(DetailPage));
            Routing.RegisterRoute("SubDetailPage", typeof(SubDetailPage));
            Routing.RegisterRoute("ImagePage", typeof(ImagePage));
            Routing.RegisterRoute("VideoPage", typeof(VideoPage));
            Routing.RegisterRoute("PrivacyPolicy", typeof(PrivacyPolicy));
        }
    }
}
