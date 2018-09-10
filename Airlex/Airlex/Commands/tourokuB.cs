using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Airlex.Commands
{
    internal class tourokuB:ICommand
    {
        private readonly Action _action;
        public event EventHandler CanExecuteChanged;
        internal tourokuB(Action action)
        {
            this._action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this._action();
        }
    }
}

