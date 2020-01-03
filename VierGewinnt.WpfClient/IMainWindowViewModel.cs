using System.Collections.Generic;

namespace VierGewinnt.WpfClient
{
    public interface IMainWindowViewModel
    {
        IGameBoardViewModel GamerBoardViewModel { get; }
        IReadOnlyList<IPlayerViewModel> PlayerViewModels { get; }


    }
}