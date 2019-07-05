using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

[assembly: Xamarin.Forms.Dependency(typeof(ImageEditor_SimpleSample.UWP.LocalizationService))]
namespace ImageEditor_SimpleSample.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new ImageEditor_SimpleSample.App());
        }
    }
    public class LocalizationService : ILocalize
    {
        public void SetLocale(string language)
        {
            CultureInfo.CurrentUICulture = new CultureInfo(language);
            CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo(language);
        }
    }
}
