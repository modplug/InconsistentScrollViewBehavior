using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace InconsistentScrollView
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());
        }
    }
}
