using System.Windows.Input;
using Airlex.BasePages;
using Airlex.Commands;
using Airlex.Models;
using Xamarin.Forms;

namespace Airlex.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {
        private string _emaddress;
        private string _passW;
        private string _passWC;
        public Command tourokuB { get; set; }
        public string EMaddress
        {
            get { return _emaddress; }
            set
            {
                this._emaddress = value;
                this.OnPropertyChanged(nameof(EMaddress));
                tourokuB.ChangeCanExecute();
            }
        }

        public string PassW
        {
            get { return _passW; }
            set
            {
                this._passW = value;
                this.OnPropertyChanged(nameof(PassW));
                tourokuB.ChangeCanExecute();
            }
        }

        public string PassWC
        {
            get { return _passWC; }
            set
            {
                this._passWC = value;
                this.OnPropertyChanged(nameof(PassWC));
                tourokuB.ChangeCanExecute();
            }
        }


        public MainViewModel()
        {
            ///tourokuB = new tourokuB(Increment);
            tourokuB = new Command(() =>
            {
                ///if (!string.IsNullOrEmpty(EMaddress))
                {
                    System.Diagnostics.Debug.WriteLine("EMaddress : " + EMaddress);
                }
            }, canExecute);
        }
        bool canExecute() { return !string.IsNullOrEmpty(EMaddress) && !string.IsNullOrEmpty(PassW) && !string.IsNullOrEmpty(PassWC) && PassWC == PassW ; }

        private void Increment()
        {
            EMaddress = tourokuBu.Incriment(EMaddress);
        }
    }
}

