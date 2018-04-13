using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ClimbCrud.Views
{
    public partial class ImageGalleryPage : ContentPage
    {
        private int _currentImageId = 1;

        public ImageGalleryPage()
        {
            InitializeComponent();

            _currentImageId = 1;

            LoadImage();
        }

        private void LoadImage()
        {
            image.Source = new UriImageSource 
            { 
                Uri = new Uri(String.Format("http://lorempixel.com/1920/1080/city/{0}", _currentImageId)),
                CachingEnabled = false
            };

        }

        void Left_Clicked(object sender, System.EventArgs e)
        {
            _currentImageId--;

            if (_currentImageId == 0)
                _currentImageId = 10;
            LoadImage();
            
        }

        void Right_Clicked(object sender, System.EventArgs e)
        {
            _currentImageId++;
            if (_currentImageId == 11)
                _currentImageId = 1;
            LoadImage();
        }
    }
}
