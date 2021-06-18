using MvvmCross;
using MvvmCross.Plugin;

namespace SByteDev.MvvmCross.Plugins.WebBrowser
{
    [MvxPlugin]
    [Preserve(AllMembers = true)]
    public sealed class Plugin : IMvxPlugin
    {
        public void Load()
        {
            Mvx.IoCProvider.RegisterSingleton<IMvxWebBrowser>(new MvxWebBrowser());
        }
    }
}