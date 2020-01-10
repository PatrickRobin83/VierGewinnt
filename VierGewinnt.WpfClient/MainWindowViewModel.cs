using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using VierGewinnt.Core;
using VierGewinnt.Core.Interfaces;
using VierGewinnt.WpfClient.Interfaces;

namespace VierGewinnt.WpfClient
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        private readonly IReadOnlyList<IPlayerViewModel> _playerViewModels;
        private readonly IGameBoardViewModel _gameBoardViewModel;
        private readonly IGameBoard _gameBoard;
        private string _winnerText;
        private Color _color;

        public MainWindowViewModel(IReadOnlyList<IPlayerViewModel> playerViewModels,
            IGameBoardViewModel gameBoardViewModel, IGameBoard gameBoard)
        {
            _playerViewModels = playerViewModels ?? throw new ArgumentNullException(nameof(playerViewModels));
            _gameBoardViewModel = gameBoardViewModel ?? throw new ArgumentNullException(nameof(gameBoardViewModel));
            _gameBoard = gameBoard ?? throw new ArgumentNullException(nameof(gameBoard));
        }
        public IReadOnlyList<IPlayerViewModel> PlayerViewModels
        {
            get { return _playerViewModels; }
        }

        public string WinnerText
        {
            get { return _winnerText; }
            private set
            {
                if (_winnerText == value) return;
                _winnerText = value;
                OnPropertyChanged();
            }

        }
        public Color WinnerColor
        {
            get { return _color; }
            private set
            {
                if (_color == value) return;
                _color = value;
                OnPropertyChanged();
            } 
        }

        public IGameBoardViewModel GamerBoardViewModel
        {
            get { return _gameBoardViewModel; }
        }

        public void PlayTurn(IColumn column)
        {
            if(column == null) throw new ArgumentNullException(nameof(column));
            var currentPlayerViewModel = PlayerViewModels.First(vm => vm.ItsPlayersTurn);
            currentPlayerViewModel.Player.PlayTurn(column);
            var winnerName = _gameBoard.DetermineWinner();
                if (winnerName != null)
                {
                    WinnerText = winnerName + " hat gewonnen!";
                    WinnerColor = currentPlayerViewModel.Player.PlayerColor;

                }
                foreach (var playerViewModel in _playerViewModels)
                {
                    playerViewModel.ItsPlayersTurn = !playerViewModel.ItsPlayersTurn;
                }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if(handler != null)
                handler(this,new PropertyChangedEventArgs(propertyName));
        }
    }
}
