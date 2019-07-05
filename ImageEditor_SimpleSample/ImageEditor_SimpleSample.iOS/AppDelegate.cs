using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Syncfusion.SfImageEditor.XForms.iOS;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(ImageEditor_SimpleSample.iOS.LocalizationService))]
namespace ImageEditor_SimpleSample.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());
            new SfImageEditorRenderer();
            return base.FinishedLaunching(app, options);
        }
    }
    public class LocalizationService : ILocalize
    {
        public void SetLocale(string language)
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);

        }
    }
}
