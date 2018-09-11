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
    public partial class namewrite : ContentPage
    {
        public namewrite()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.namewriteViewModel();
                      }
    }
}
