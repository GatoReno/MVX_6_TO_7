using System;
using MvvmCross.ViewModels;
using MVXFC6v27v.CORE.VideModels;
using Xamarin.Forms;

namespace MVXFC6v27v.CORE
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();
            //demand a view mode for first page
            RegisterAppStart<FirstViewModel>();
        }
    }
}

