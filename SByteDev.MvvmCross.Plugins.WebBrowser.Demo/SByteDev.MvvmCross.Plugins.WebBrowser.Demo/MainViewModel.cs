using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.ViewModels;

namespace SByteDev.MvvmCross.Plugins.WebBrowser.Demo
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IMvxWebBrowser _webBrowser;

        public ICommand ShowWebPageCommand { get; }

        public MainViewModel(IMvxWebBrowser webBrowser)
        {
            _webBrowser = webBrowser;

            ShowWebPageCommand = new MvxAsyncCommand(ShowWebPageAsync);
        }

        private Task ShowWebPageAsync(CancellationToken cancellationToken)
        {
            return _webBrowser.ShowWebPageAsync(new Uri("https://github.com"), cancellationToken);
        }
    }
}