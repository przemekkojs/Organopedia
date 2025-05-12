using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organopedia3.Pages
{
    public class SwipeEnablePage : ContentPage
    {
        public SwipeEnablePage()
        {
            var panGesture = new PanGestureRecognizer();
            double totalX = 0;

            panGesture.PanUpdated += (s, e) =>
            {
                switch (e.StatusType)
                {
                    case GestureStatus.Running:
                        totalX = e.TotalX;
                        break;

                    case GestureStatus.Completed:
                        if (totalX > 100)
                            Shell.Current.FlyoutIsPresented = true;
                        else if (totalX < -100)
                            Shell.Current.FlyoutIsPresented = false;

                        totalX = 0;
                        break;
                }
            };
        }
    }
}
