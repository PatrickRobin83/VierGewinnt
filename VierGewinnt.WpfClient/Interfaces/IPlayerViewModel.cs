using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.Interfaces

{
    public interface IPlayerViewModel
    {
        //Brush PlayerColor { get; }
        Player Player { get; }
        bool ItsPlayersTurn { get; set; }


    }
}
