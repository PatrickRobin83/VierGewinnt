using VierGewinnt.Core;
using VierGewinnt.WpfClient.Interfaces;

namespace VierGewinnt.WpfClient.Tests
{
    public class PlayerViewModelMock : IPlayerViewModel
    {
        private readonly PlayerMock _player;

        public PlayerViewModelMock(PlayerMock player)
        {
            _player = player;
        }
        public Player Player { get; }
        public bool ItsPlayersTurn { get; set; }
        

    }
}