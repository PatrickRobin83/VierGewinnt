using System;
using VierGewinnt.Core;
using System.ComponentModel;
namespace VierGewinnt.WpfClient
{
    public class ClickColumnCommand : IClickColumnsCommand
    {
        private readonly IColumn _column;
        private readonly IMainWindowViewModel _mainWindowViewModel;

        public ClickColumnCommand(IColumn column, IMainWindowViewModel mainWindowViewModel)
        {
            _column = column ?? throw new ArgumentNullException(nameof(column));
            _mainWindowViewModel = mainWindowViewModel ?? throw new ArgumentNullException(nameof(mainWindowViewModel));

            _mainWindowViewModel.PropertyChanged += MainWindowViewModelOnPropertyChanged;
        }

        private void MainWindowViewModelOnPropertyChanged(object sender,
            PropertyChangedEventArgs propertyChangedEventArgs)
        {
            if (propertyChangedEventArgs.PropertyName == "WinnerText")
            {
                onCanExecuteChanged();
            }
        }

        private void onCanExecuteChanged()
        {
            var handler = CanExecuteChanged;
            if(handler != null )
                handler(this, EventArgs.Empty);
        }

        public bool CanExecute(object parameter)
        {
            if (string.IsNullOrEmpty(_mainWindowViewModel.WinnerText) && _column.IsColumnFull == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Execute(object parameter)
        {
            _mainWindowViewModel.PlayTurn(_column);
            if (_column.IsColumnFull)
            {
                onCanExecuteChanged();
            }
        }

        public event EventHandler CanExecuteChanged;
        public int ColumnIndex => _column.Index;
    }
}
