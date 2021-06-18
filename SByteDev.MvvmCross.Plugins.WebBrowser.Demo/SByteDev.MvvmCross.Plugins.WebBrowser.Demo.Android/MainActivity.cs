using Android.App;
using Android.OS;
using Android.Widget;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Android.Views;

namespace SByteDev.MvvmCross.Plugins.WebBrowser.Demo.Android
{
    [Activity(Theme = "@style/Theme.AppCompat.Light.NoActionBar")]
    public class MainActivity : MvxActivity<MainViewModel>
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