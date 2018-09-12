using System;
using System.Windows.Input;
using Airlex.BasePages;
using Airlex.Commands;
using Airlex.Models;
using Xamarin.Forms;




namespace Airlex.ViewModels
{
    internal class namewriteViewModel : ViewModelBase
    {
        private string _nameW;
        private string _selecteddata;
        private DateTime _selectd = DateTime.Now;
        private DateTime _now = DateTime.Now;
        public int nenrei 
        {
            get => _now.Year - selectD.Year;
        }
        public Command namesendB { get; set; }



        static string[] _PrefdataSets = ("男|" + "女|" + "その他|").Split('|');


        public string nameW
        {
            get { return _nameW; }
            set
            {
                this._nameW = value;
                this.OnPropertyChanged(nameof(nameW));
                namesendB.ChangeCanExecute();
            }
        }



        public string[] PrefDataSets => _PrefdataSets;


        public string selectedData
        {
            get { return _selecteddata; }
            set
            {
                this._selecteddata = value;
                this.OnPropertyChanged(nameof(selectedData));
                namesendB.ChangeCanExecute();
            }
        }

        public DateTime selectD
        {
            get { return _selectd; }
            set
            {
                this._selectd = value;
                this.OnPropertyChanged(nameof(selectD));
                this.OnPropertyChanged(nameof(nenrei));
                namesendB.ChangeCanExecute();
            }
            
        }




        public namewriteViewModel()
        {


            namesendB = new Command(() =>
            {
                System.Diagnostics.Debug.WriteLine("name : " + nameW + " selectedData : " + selectedData + " date :" + selectD);
                Increment();
                Increment2();
            });




        }
        private void Increment()
        {
            _nameW = user.Incriment(_nameW);
        }

         private void Increment2()
        {
            selectedData = user.Incriment2(_selecteddata);
        }
    }
}

