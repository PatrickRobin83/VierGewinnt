using System.Collections.Generic;
using System.ComponentModel;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient
{
    public interface IMainWindowViewModel : INotifyPropertyChanged
    {
        IGameBoardViewModel GamerBoardViewModel { get; }
        IReadOnlyList<IPlayerViewModel> PlayerViewModels { get; }

        string WinnerText { get; }
        void PlayTurn(IColumn column);

    }
}