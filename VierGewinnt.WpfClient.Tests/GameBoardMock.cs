using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.Tests
{
    public class GameBoardMock : IGameBoard
    {
        public IReadOnlyList<IReadOnlyList<IField>> Fields { get; }
        public IReadOnlyList<Row> Rows { get; }
        public IReadOnlyList<Column> Columns { get; }
        public IReadOnlyList<Diagonal> Diagonals { get; }
        public string DetermineWinner()
        {
            throw new NotImplementedException();
        }

        public string WinnerName { get; set; }
    }
}
