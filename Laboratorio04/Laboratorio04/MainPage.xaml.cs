using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Laboratorio04
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Item1.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new Page1());
            };

            Item2.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new TabbedPage2());
            };

            Item3.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new CarouselPage1());
            };

            Item4.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ModalPage1());
            };

            Item5.Clicked += async (sender, e) =>
            {
                var answe = await DisplayAlert("Question?", 
                    "Would you like to play a game", "Yes", "No");
            };
        }
    }
}
