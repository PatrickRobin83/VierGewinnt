using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using VierGewinnt.Core;
using VierGewinnt.WpfClient.Annotations;
using VierGewinnt.WpfClient.Interfaces;

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
