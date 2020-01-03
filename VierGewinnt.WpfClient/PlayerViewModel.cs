using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VierGewinnt.Core;
using VierGewinnt.WpfClient.Annotations;

namespace VierGewinnt.WpfClient
{
    public class PlayerViewModel : IPlayerViewModel, INotifyPropertyChanged
    {
        private readonly Player _player;
        private bool _isPlayersTurn;

        public PlayerViewModel(Player player)
        {
            _player = player ?? throw new ArgumentNullException(nameof(player));

        }

        public Player Player
        {
            get { return _player; }

        }

        public bool ItsPlayersTurn
        {
            get { return _isPlayersTurn; }
            set
            {
                if (_isPlayersTurn == value) return;
                 
                _isPlayersTurn = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
