using System;
using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace practica01
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btnAuth;
        EditText txtUsuario;
        EditText txtContrasenna;
        EditText editTextToken;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            btnAuth = FindViewById<Button>(Resource.Id.btnAuth);
            btnAuth.Click += DoAuthentication;
            txtUsuario = FindViewById<EditText>(Resource.Id.txtUsuario);
            txtContrasenna = FindViewById<EditText>(Resource.Id.txtContrasenna);
            editTextToken = FindViewById<EditText>(Resource.Id.editTextToken);
        }

        private void DoAuthentication(object sender, EventArgs e)
        {
            int a = 2;
            if (txtUsuario.Text.Equals("bichito") && txtContrasenna.Text.Equals("132456"))
            {
                Toast.MakeText(this,"usuario valido", ToastLength.Short).Show();
            }else
            {
                Toast.MakeText(this,"usuario invalido, este telefono se autodestruira", ToastLength.Short).Show();
            }

        }
        

    }
}

