using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Airlex
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
            faceV.Source = ImageSource.FromResource("Airlex.image.face.png");

        }
    }
}
