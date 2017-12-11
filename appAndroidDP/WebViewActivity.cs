using Android.App;
using Android.Widget;
using Android.OS;
using Android.Webkit;

namespace appAndroidDP
{
    [Activity(Label = "Digital Pages Project")]
    public class WebViewActivity : Activity
    {


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.WebView);
            Button btnFechar = FindViewById<Button>(Resource.Id.fechar);

            var id =MainActivity.guid;

            Toast.MakeText(ApplicationContext,"Id Único:" + id.ToString(), ToastLength.Long).Show();

            WebView webView = FindViewById<WebView>(Resource.Id.webPage);
           

            webView.Settings.JavaScriptEnabled = true;

            webView.LoadUrl("file:///android_asset/page.html");


            btnFechar.Click += (sender, args) =>
            {
                Finish();

            };


            }

    }
  
}

