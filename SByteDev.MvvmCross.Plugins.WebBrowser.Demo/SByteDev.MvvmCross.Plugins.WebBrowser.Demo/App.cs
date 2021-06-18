using MvvmCross.ViewModels;

namespace SByteDev.MvvmCross.Plugins.WebBrowser.Demo
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            RegisterAppStart<MainViewModel>();
        }
    }
}