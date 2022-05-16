using System;

using Xamarin.Forms;

namespace MVXFC6v27v.CORE.VideModels
{
    public class FirstViewModel : ContentPage
    {
        public FirstViewModel()
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

