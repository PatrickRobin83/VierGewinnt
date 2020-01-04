using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        private readonly IReadOnlyList<IPlayerViewModel> _playerViewModels;
        private string _winnerName;

        public MainWindowViewModel(IReadOnlyList<IPlayerViewModel> playerViewModels)
        {
            _playerViewModels = playerViewModels;
        }
        public IReadOnlyList<IPlayerViewModel> PlayerViewModels
        {
            get { return _playerViewModels; }
        }

        public string WinnerName => _winnerName;

        public IGameBoardViewModel GamerBoardViewModel
        {
            get { return null; }
        }
    }
}
