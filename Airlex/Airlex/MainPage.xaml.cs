using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Windows;


namespace Airlex
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Double FS = 0;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    FS = 14;
                    break;
                case Device.Android:
                    FS = 12;
                    break;
            }

            kiyakuB.FontSize = FS;
            privacyB.FontSize = FS;


        }

       

    }
}
