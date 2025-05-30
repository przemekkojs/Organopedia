﻿using Android.App;
using Android.Content.PM;
using Android.Runtime;

namespace Organopedia3.Platforms.Android
{
    [Activity(
        Theme = "@style/Maui.SplashTheme",
        MainLauncher = true,
        LaunchMode = LaunchMode.SingleTask,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density,
        ResizeableActivity = true)]
    [Register("com.przemekkojs.organopedia.MainActivity")]
    public class MainActivity : MauiAppCompatActivity
    {
    }
}
