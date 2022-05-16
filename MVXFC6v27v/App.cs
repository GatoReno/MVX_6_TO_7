using System;

using Xamarin.Forms;

namespace MVXFC6v27v.CORE
{
    public class App : ContentPage
    {
        public App()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

