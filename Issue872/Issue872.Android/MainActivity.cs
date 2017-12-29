using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using FFImageLoading.Forms;
using FFImageLoading;
using FFImageLoading.Forms.Droid;

namespace Issue872.Droid
{
    [Activity(Label = "Issue872", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            CachedImageRenderer.Init(false);
            ImageService.Instance.Initialize();
            ImageService.Instance.InvalidateCacheAsync(FFImageLoading.Cache.CacheType.All).Wait(); // clear cache to make testing more convenient
            LoadApplication(new App());
        }
    }
}

