using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MatchResults.Helpers
{
    /// <summary>
    /// Klasa odpowiedzialna za implementację komend
    /// </summary>
    public class RelayCommand : ICommand
	{
		private readonly Func<object, bool> _canExecute;
		private readonly Action<object> _execute;

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
		{
            if (execute == null)
            {
                throw new ArgumentNullException("Null execute");
            }

            _execute = execute;
			_canExecute = canExecute ?? (o => true);
		}

		public bool CanExecute(object parameter)
		{
			return _canExecute(parameter);
		}

		public void Execute(object parameter)
		{
			_execute(parameter);
		}

		public event EventHandler CanExecuteChanged;

		public void RaiseCanExecuteChanged()
		{
			var handler = CanExecuteChanged;
			if (handler != null)
				handler(this, EventArgs.Empty);
		}
	}
}
