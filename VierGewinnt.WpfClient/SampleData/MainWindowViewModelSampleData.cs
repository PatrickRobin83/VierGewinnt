using System.Collections.Generic;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.SampleData
{
    public class MainWindowViewModelSampleData : IMainWindowViewModel
    {
        private readonly IReadOnlyList<IPlayerViewModel> _playerViewModels;

        public MainWindowViewModelSampleData()
        {
            var playerViewModels = new List<IPlayerViewModel>
            {
                new PlayerViewModelSampleData("Player A", new Color(128, 0, 0)),
                new PlayerViewModelSampleData("Player B", new Color(0, 0, 128)) {ItsPlayersTurn = false}
            };

            _playerViewModels = playerViewModels;
        }

        public IGameBoardViewModel GamerBoardViewModel
        {
            get { return null; }
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
