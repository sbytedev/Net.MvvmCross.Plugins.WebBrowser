using Android.App;
using Android.OS;
using Android.Widget;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Droid.Support.V7.AppCompat;

namespace SByteDev.MvvmCross.Plugins.WebBrowser.Demo.Android
{
    [Activity(Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : MvxAppCompatActivity<MainViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var button = new Button(this) {Text = "Show Web Page"};

            SetContentView(button);

            var set = this.CreateBindingSet<MainActivity, MainViewModel>();
            set.Bind(button).To(vm => vm.ShowWebPageCommand);
            set.Apply();
        }
    }
}