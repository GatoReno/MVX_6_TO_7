using System;
using MvvmCross.ViewModels;
using Xamarin.Forms;

namespace MVXFC6v27v.CORE.VideModels
{
    public class FirstViewModel : MvxViewModel
    {
        public FirstViewModel()
        {
            //init service injection
        }

        public string MyProp { get; } = "HELLO MVX";
    }
}

