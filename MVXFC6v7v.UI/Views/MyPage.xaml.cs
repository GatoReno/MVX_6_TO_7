using System;
using System.Collections.Generic;
using MvvmCross.Forms.Views;
using MVXFC6v27v.CORE.VideModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVXFC6v7v.UI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyPage : MvxContentPage<FirstViewModel>
    {
        public MyPage()
        {
            InitializeComponent();
        }
    }
}
