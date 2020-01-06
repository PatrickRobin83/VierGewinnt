using System.Windows.Input;

namespace VierGewinnt.WpfClient
{
    public interface IClickColumnsCommand : ICommand
    {
        int ColumnIndex { get; }
    }
}