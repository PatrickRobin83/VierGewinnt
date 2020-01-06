using System.Collections.Generic;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.SampleData
{
    public class MainWindowViewModelSampleData : IMainWindowViewModel
    {
        private readonly IReadOnlyList<IPlayerViewModel> _playerViewModels;
        private readonly IGameBoardViewModel _gameBoardViewModel;

        public MainWindowViewModelSampleData()
        {
            var playerViewModels = new List<IPlayerViewModel>
            {
                new PlayerViewModelSampleData("Player A", new Color(128, 0, 0)),
                new PlayerViewModelSampleData("Player B", new Color(0, 0, 128)) {ItsPlayersTurn = false}
            };

            _playerViewModels = playerViewModels;
            _gameBoardViewModel = new GameBoardViewModelSampleData();
        }

        public IGameBoardViewModel GamerBoardViewModel
        {
            get { return _gameBoardViewModel; }
        }

        public IReadOnlyList<IPlayerViewModel> PlayerViewModels
        {
            get { return _playerViewModels; }
        }

        public string WinnerName
        {
            get { return _playerViewModels[0].Player.Name; }
        }
    }
}
