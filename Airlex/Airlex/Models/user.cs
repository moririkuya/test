using System;

using Xamarin.Forms;

namespace Airlex.Models
{
    internal static class user
    {
        internal static string Incriment(string _nameW2)
        {
            System.Diagnostics.Debug.WriteLine( _nameW2);

            return _nameW2;
        }

        internal static string Incriment2(string _selectData2)
            {
            
            if (_selectData2 == "男")
                _selectData2 = "1";

            if (_selectData2 == "女")
                _selectData2 = "2";
            if (_selectData2 == "その他")
                _selectData2 = "3";

                System.Diagnostics.Debug.WriteLine(_selectData2);
            return _selectData2;
                
            }
    }
}

