using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VierGewinnt.WpfClient
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        private readonly IReadOnlyList<IPlayerViewModel> _playerViewModels;

        public MainWindowViewModel(IReadOnlyList<IPlayerViewModel> playerViewModels)
        {
            _playerViewModels = playerViewModels;
        }
        public IReadOnlyList<IPlayerViewModel> PlayerViewModels
        {
            get { return _playerViewModels; }
        }

        public IGameBoardViewModel GamerBoardViewModel
        {
            get { return null; }
        }
    }
}
