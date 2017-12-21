using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580061FinalA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            newButton.Clicked += NewButton_Clicked;

        }

        void NewButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ProductNewPage());


        }
    }
}
