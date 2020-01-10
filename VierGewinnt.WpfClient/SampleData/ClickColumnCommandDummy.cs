using System;
using VierGewinnt.WpfClient.Interfaces;

namespace VierGewinnt.WpfClient.SampleData
{
    public class ClickColumnCommandDummy : IClickColumnsCommand
    {
        private readonly int _columnIndex;
        private readonly bool _canExecute;
        public ClickColumnCommandDummy(bool canExecute, int columnIndex)
        {
            _canExecute = canExecute;
            _columnIndex = columnIndex;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute;
        }

        public void Execute(object parameter)
        {
        }

        public event EventHandler CanExecuteChanged;
        public int ColumnIndex => _columnIndex;

        protected virtual void OnCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}