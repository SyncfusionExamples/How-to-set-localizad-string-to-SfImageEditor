using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Globalization;
using System.Threading;

[assembly: Xamarin.Forms.Dependency(typeof(ImageEditor_SimpleSample.Droid.LocalizationService))]
namespace ImageEditor_SimpleSample.Droid
{
    [Activity(Label = "ImageEditor_SimpleSample", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
    public class LocalizationService : ILocalize
    {
        public void SetLocale(string language)
        {
            var userSelectedCulture = new CultureInfo(language);
            Thread.CurrentThread.CurrentUICulture = userSelectedCulture;
        }
    }
}

