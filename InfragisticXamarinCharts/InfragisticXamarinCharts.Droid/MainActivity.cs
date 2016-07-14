using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace InfragisticXamarinCharts.Droid
{
    [Activity(Label = "InfragisticXamarinCharts", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            Infragistics.XF.Initializers.Barcodes.Init();
            Infragistics.XF.Initializers.Charts.Init();
            Infragistics.XF.Initializers.Gauges.Init();

            LoadApplication(new App());
        }
    }
}

