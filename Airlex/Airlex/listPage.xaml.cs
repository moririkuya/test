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
    public class listF{
        public string name { get; set; }
        public string faceV { get; set; }

    }


    public partial class listPage : ContentPage
    {

        public listPage()
        {
            InitializeComponent();
            list.ItemsSource = new List<listF>(){


                new listF(){
                        name ="山田花子",faceV="face.png"
                },
                new listF(){
                        name ="山田花子",faceV="face.png"
                },
                new listF(){
                    name ="山田花子",faceV="face.png"
                },
                new listF()
            {
                name = "山田花子",
                faceV = "face.png"
            },
                new listF(){
                    name ="山田花子",faceV="face.png"
                },
              };




        }
        

    }

}
