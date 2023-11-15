using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp_IMTAHAN_TURBO_AZ.MyCommand
{
    public class RealeCommand : ICommand
    {
        

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }

            remove { CommandManager.RequerySuggested -= value; }

        }

        private readonly Action<object?>? _Is;
        private readonly Predicate<object?>? _Yoxlama;

        public RealeCommand(Action<object?>? ıs, Predicate<object?>? yoxlama = null)
        {
            _Is = ıs;
            _Yoxlama = yoxlama;
        }

        public bool CanExecute(object? parameter)
        {
            if(_Yoxlama == null) { return true; }

            return _Yoxlama.Invoke(parameter);

        }

        public void Execute(object? parameter)
        {
            _Is?.Invoke(parameter);
        }
    }
}
