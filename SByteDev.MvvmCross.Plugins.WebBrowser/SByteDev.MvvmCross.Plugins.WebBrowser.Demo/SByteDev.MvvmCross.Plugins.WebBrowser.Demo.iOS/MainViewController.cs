using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using UIKit;

namespace SByteDev.MvvmCross.Plugins.WebBrowser.Demo.iOS
{
    [MvxRootPresentation]
    public class MainViewController : MvxViewController<MainViewModel>
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var button = UIButton.FromType(UIButtonType.System);

            button.TranslatesAutoresizingMaskIntoConstraints = false;
            button.SetTitle("Show Web Page", UIControlState.Normal);

            View.BackgroundColor = UIColor.White;
            View.AddSubview(button);
            View.AddConstraints(new []
            {
                button.CenterXAnchor.ConstraintEqualTo(View.CenterXAnchor),
                button.CenterYAnchor.ConstraintEqualTo(View.CenterYAnchor)
            });

            var set = this.CreateBindingSet<MainViewController, MainViewModel>();
            set.Bind(button).To(vm => vm.ShowWebPageCommand);
            set.Apply();
        }
    }
}