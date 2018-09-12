using System;

using Xamarin.Forms;

namespace Airlex.Models
{
    public static class user
    {
        public static string _selectdata3;
        public static string sqlC;

        internal static string Incriment(string _nameW2,string _selectdata2,DateTime _selectD2)
        {


            if (_selectdata2 == "男")
                _selectdata3 = "1";
            if (_selectdata2 == "女")
                _selectdata3 = "2";
            if (_selectdata2 == "その他")
                _selectdata3 = "3";

            System.Diagnostics.Debug.WriteLine(" 名前 : " + _nameW2 + " 性別 : " + _selectdata3 + " 生年月日 : " + _selectD2);

            return sqlC;
        }

        //internal static string Incriment2(string _selectData2)
        //{

        //    if (_selectData2 == "男")
        //        _selectData2 = "1";
        //    if (_selectData2 == "女")
        //        _selectData2 = "2";
        //    if (_selectData2 == "その他")
        //        _selectData2 = "3";

        //    System.Diagnostics.Debug.WriteLine(_selectData2);
        //    return _selectData2;

        //}

        //internal static DateTime Increment3(DateTime selectD2)
        //{
        //    System.Diagnostics.Debug.WriteLine(selectD2);
        //    return selectD2;
        //}

       
    }
}

