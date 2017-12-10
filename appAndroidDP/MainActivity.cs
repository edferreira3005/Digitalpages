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

            ProgressDialog progress = new ProgressDialog(this);
            progress.Indeterminate = true;
            progress.SetProgressStyle(ProgressDialogStyle.Spinner);
            progress.SetMessage("Aguarde...");
            progress.SetCancelable(false);


            Button btnClickId = FindViewById<Button>(Resource.Id.btnClickId);

            btnClickId.Click += (sender, args) =>
            {
                RunOnUiThread(() =>
                {
                    progress.Show();
                    Thread.Sleep(5000);
                    progress.Dismiss();
                });
                guid = Guid.NewGuid();
                Toast.MakeText(ApplicationContext, guid.ToString(), 
                    ToastLength.Long).Show();

                StartActivity(typeof(WebViewActivity));




            };

        }

    }
}

