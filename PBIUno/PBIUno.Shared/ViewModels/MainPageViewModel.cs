using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBIUno.Shared.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public string Title { get; set; }

        public MainPageViewModel()
        {
            Title = "Home Page";
        }
    }
}