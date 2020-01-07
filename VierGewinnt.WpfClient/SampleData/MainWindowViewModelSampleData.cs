using System.Collections.Generic;
using System.ComponentModel;
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

        public string WinnerText { 
            get { return "Player A hat gewonnen!"; } 
        }

        public Color WinnerColor
        {
            get { return new Color(128,0,0); }
        }
        public void PlayTurn(IColumn column)
        {
            throw new System.NotImplementedException();
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
