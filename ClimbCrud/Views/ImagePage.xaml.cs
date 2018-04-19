using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ClimbCrud.Views
{
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            //btn.Image = (FileImageSource)ImageSource.FromFile(Device.OnPlatform(
            //    iOS: "clock.png",
            //    Android: "clock.png",
            //    WinPhone: "Images/clock.png"
            //));

            image.Source = ImageSource.FromResource("ClimbCrud.Images.LauraHueco.png");   
        }
    }
}
