using System.Collections.Generic;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient
{
    public interface IMainWindowViewModel
    {
        IGameBoardViewModel GamerBoardViewModel { get; }
        IReadOnlyList<IPlayerViewModel> PlayerViewModels { get; }

        string WinnerName { get; }


    }
}