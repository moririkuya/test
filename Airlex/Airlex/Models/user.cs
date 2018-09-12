using System;

using Xamarin.Forms;

namespace Airlex.Models
{
    internal static class user
    {
        internal static string Incriment(string _nameW2)
        {
            System.Diagnostics.Debug.WriteLine( _nameW2);

            return ;
        }

        internal static string Incriment2(string _selectData2)
            {
            if (_selectData2 == "男")
                _selectData2 = "1";
                System.Diagnostics.Debug.WriteLine(_selectData2);
            return ;
                
            }
    }
}

