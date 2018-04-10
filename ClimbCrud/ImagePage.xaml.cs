using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ClimbCrud
{
    public partial class ImagePage : ContentPage
    {
        public ImagePage()
        {
            InitializeComponent();

            image.Source = ImageSource.FromResource("/Users/btsui/Projects/ClimbCrud/ClimbCrud/Images/LauraHueco.png");   
      


        }
    }
}
