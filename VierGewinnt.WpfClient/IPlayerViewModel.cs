using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient
{
    public interface IPlayerViewModel
    {
        //Brush PlayerColor { get; }
        Player Player { get; }
        bool ItsPlayersTurn { get; }


    }
}
