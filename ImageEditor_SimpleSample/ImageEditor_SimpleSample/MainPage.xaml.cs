using Syncfusion.SfImageEditor.XForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImageEditor_SimpleSample
{
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();
            DependencyService.Get<ILocalize>().SetLocale("ja-JP");
            imageeditor.Source = ImageSource.FromResource("ImageEditor_SimpleSample.image3.png",GetType().GetTypeInfo().Assembly);
            ImageEditorResourceManager.Manager =
              new ResourceManager("ImageEditor_SimpleSample.Resources.Syncfusion.SfImageEditor.XForms", GetType().GetTypeInfo().Assembly);
        }
    }

    public interface ILocalize
    {
        void SetLocale(string language);
    }
   
}
