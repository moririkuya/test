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

        public user user { get; set; }
        public namewriteViewModel()
        {
            user = new user
            {
                Name = "test",

            };


            namesendB = new Command(() =>
            {
                string _selectdata2 ;

                if (_selecteddata == "男")
                {
                    _selectdata2 = "1";
                }
                else if (_selecteddata == "女")
                {
                    _selectdata2 = "2";
                }
                else if (_selecteddata == "その他")
                {
                    _selectdata2 = "3";
                }
                else
                    _selectdata2 = "0";

                System.Diagnostics.Debug.WriteLine("name : " + nameW + " selectedData : " + selectedData + " date :" + selectD);


                user.Incriment(_nameW,_selectdata2,selectD);


            });

        }

    }
}

