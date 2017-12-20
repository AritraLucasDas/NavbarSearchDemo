using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace NavbarSearchDemo.Droid
{
    [Activity(Label = "SplashScreenActivity",
        MainLauncher = true,
        NoHistory = true,
        Theme = "@style/SplashStyle")]
    public class SplashStyle : AppCompatActivity

    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Task newTask= new Task(()=>{SimulateStartup();});
            newTask.Start();
        }
        async void SimulateStartup()
        {         
            await Task.Delay(2000);
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}