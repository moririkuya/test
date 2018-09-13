using System;
using Airlex.BasePages;
using Xamarin.Forms;
using Airlex.ViewModels;

namespace Airlex.Models
{
    public class user : ViewModelBase

    {

        private String _name;
        public string Name { get { return _name;}
            set 
            {
                this._name = value;
                this.OnPropertyChanged(nameof(Name));
            }
        }
        public int seibetu { get; set; }
        public DateTime birthD { get; set; }
        //public static string _selectdata3;
        public static string sqlC;


        internal static string Incriment(string _nameW2,string _selectdata3,DateTime _selectD2)
        {


            //if (_selectdata2 == "男")
            //    _selectdata3 = "1";
            //if (_selectdata2 == "女")
            //    _selectdata3 = "2";
            //if (_selectdata2 == "その他")
                //_selectdata3 = "3";

            System.Diagnostics.Debug.WriteLine(" 名前 : " + _nameW2 + " 性別 : " + _selectdata3 + " 生年月日 : " + _selectD2);

            return sqlC;
        }


    }
       
    }


