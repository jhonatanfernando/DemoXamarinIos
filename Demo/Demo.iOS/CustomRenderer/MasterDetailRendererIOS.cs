using System;
using Demo.CustomRenderer;
using Demo.iOS.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(MasterDetailRenderer), typeof(MasterDetailRendererIOS))]
namespace Demo.iOS.CustomRenderer
{
    public class MasterDetailRendererIOS : PhoneMasterDetailRenderer
    {
        public MasterDetailRendererIOS() : base()
        {

        }
    }
}
