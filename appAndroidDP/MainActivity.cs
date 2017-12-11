using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Java.Lang;
using System.Threading.Tasks;
using Android.Webkit;

namespace appAndroidDP
{
    [Activity(Label = "Digital Pages Project", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        public static Guid guid;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);




            Button btnClickId = FindViewById<Button>(Resource.Id.btnClickId);

            btnClickId.Click += async (sender, args) =>
            {
             var    progress = new Android.App.ProgressDialog(this);
                progress.Indeterminate = true;
                progress.SetProgressStyle(Android.App.ProgressDialogStyle.Spinner);
                progress.SetMessage("Aguarde...");
                progress.SetCancelable(false);
                progress.Show();

                await Task.Delay(5000);

                guid = Guid.NewGuid();
                progress.Dismiss();

                StartActivity(typeof(WebViewActivity));
               
               
            };

        }

    }
}

