using System;
using MvvmCross;
using System.Threading;
using System.Threading.Tasks;
using SByteDev.Xamarin.Plugins.WebBrowser;

namespace SByteDev.MvvmCross.Plugins.WebBrowser
{
    [Preserve(AllMembers = true)]
    internal sealed class MvxWebBrowser : IMvxWebBrowser
    {
        public Task ShowWebPageAsync(Uri uri, CancellationToken cancellationToken)
        {
            return WebBrowserPlugin.Instance.ShowWebPageAsync(uri, cancellationToken);
        }
    }
}