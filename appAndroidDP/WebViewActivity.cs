using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Java.Lang;
using System.Threading.Tasks;
using Android.Webkit;
using Android.Opengl;
using Java.IO;
using System.IO;

namespace appAndroidDP
{
    [Activity(Label = "WbView")]
    public class WebViewActivity : Activity
    {


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.WebView);
            Button btnFechar = FindViewById<Button>(Resource.Id.fechar);

            Guid id =MainActivity.guid;
           

            WebView webView = FindViewById<WebView>(Resource.Id.webPage);
    
            webView.Settings.JavaScriptEnabled = true;
            webView.LoadUrl(string.Format("javascript: codeAddress({0})", id));
            webView.LoadUrl("file:///android_asset/page.html");
            


            btnFechar.Click += (sender, args) =>
            {
                Finish();

            };


            }

    }
  
}

