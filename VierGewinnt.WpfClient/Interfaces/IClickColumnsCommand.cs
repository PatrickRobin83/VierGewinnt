using System.Windows.Input;

namespace VierGewinnt.WpfClient.Interfaces
{
    public interface IClickColumnsCommand : ICommand
    {
        int ColumnIndex { get; }
    }
}