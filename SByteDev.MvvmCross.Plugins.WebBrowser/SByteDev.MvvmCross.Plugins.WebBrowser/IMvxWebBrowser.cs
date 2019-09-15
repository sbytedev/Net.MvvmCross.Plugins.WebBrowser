using System;
using System.Threading;
using System.Threading.Tasks;

namespace SByteDev.MvvmCross.Plugins.WebBrowser
{
    public interface IMvxWebBrowser
    {
        Task ShowWebPageAsync(Uri uri, CancellationToken cancellationToken);
    }
}