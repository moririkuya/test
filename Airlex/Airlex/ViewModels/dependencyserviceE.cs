using System;
using System.Windows.Input;
using Airlex.BasePages;
using Airlex.Commands;
using Airlex.Models;
using Xamarin.Forms;
namespace Airlex.ViewModels
{

    public class dependencyserviceE : ViewModelBase
    {
        public Command DepeB { get; set; }
        private string _depes;
        private string _appword;



        public string DepeS
        {
            get { return _depes; }
            set
            {
                this._depes = value;
                this.OnPropertyChanged(nameof(DepeS));
              

            }
        }

        public dependencyserviceE()
        {
            DepeB = new Command(() =>
            {
                _appword = DependencyService.Get<IAssemblyService>().GetPackageName();
                System.Diagnostics.Debug.Write(_appword);
            });
        }
    }


}
