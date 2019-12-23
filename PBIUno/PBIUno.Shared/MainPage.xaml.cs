using PBIUno.Shared.Services;
using PBIUno.Shared.ViewModels;
using PBIUno.Shared.Views;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PBIUno
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private INavigationService _navigationService;

        public MainPageViewModel ViewModel => DataContext as MainPageViewModel;

        public MainPage()
        {
            this.InitializeComponent();

            DataContext = IoC.Resolve<MainPageViewModel>();

            _navigationService = IoC.Resolve<INavigationService>();

            SetContentFramee();
        }

        private void SetContentFramee()
        {
            _navigationService.SetContentFrame(MyContentFrame);
        }

        private void MenuItem1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            _navigationService.Navigate<ViewAPage>();
        }

        private void MenuItem2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            _navigationService.Navigate<ViewBPage>();
        }
    }
}