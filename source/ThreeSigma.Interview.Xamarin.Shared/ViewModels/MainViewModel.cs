using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeSigma.Interview.Xamarin.Shared.ViewModels
{
    public class MainViewModel
    {
        private readonly string message;

        public MainViewModel(string message)
        {
            this.message = message;
        }

        public string Message => message;
    }
}