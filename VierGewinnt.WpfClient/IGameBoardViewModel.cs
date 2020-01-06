using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient
{
    public interface IGameBoardViewModel
    {
        IReadOnlyList<Field> Fields { get; }
        IReadOnlyList<IClickColumnsCommand> ClickColumnsCommands { get; }
    }
}
