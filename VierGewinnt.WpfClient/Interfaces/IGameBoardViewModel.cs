using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VierGewinnt.Core;
using VierGewinnt.Core.Interfaces;

namespace VierGewinnt.WpfClient.Interfaces
{
    public interface IGameBoardViewModel
    {
        IReadOnlyList<IField> Fields { get; }
        IReadOnlyList<IClickColumnsCommand> ClickColumnsCommands { get; }
    }
}
