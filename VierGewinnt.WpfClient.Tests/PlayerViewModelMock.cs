using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.Tests
{
    public class PlayerViewModelMock : IPlayerViewModel
    {
        private readonly PlayerMock _player;
        private readonly int _countPlayTurnCalls;

        public PlayerViewModelMock(PlayerMock player)
        {
            _player = player;
        }
        public Player Player { get; }
        public bool ItsPlayersTurn { get; set; }
        

    }
}