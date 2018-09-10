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
        public Command tourokuB { get; set; }
        public string EMaddress
        {
            get { return _emaddress; }
            set
            {
                this._emaddress = value;
                this.OnPropertyChanged(nameof(EMaddress));
                ///tourokuB.ChangeCanExecute();
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
        bool canExecute() { return !string.IsNullOrEmpty(EMaddress); }

        private void Increment()
        {
            EMaddress = tourokuBu.Incriment(EMaddress);
        }
    }
}

