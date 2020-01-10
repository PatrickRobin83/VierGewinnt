using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using VierGewinnt.Core;
using VierGewinnt.Core.Interfaces;
using VierGewinnt.WpfClient.Interfaces;

namespace VierGewinnt.WpfClient.SampleData
{
    public class GameBoardViewModelSampleData : IGameBoardViewModel
    {
        private readonly IReadOnlyList<IField> _fields;
        private readonly IReadOnlyList<IClickColumnsCommand> _clickColumnsCommands;

        public GameBoardViewModelSampleData()
        {
            var fields = new IField[7][];
            for (var i = 0; i < 7; i++)
            {
                fields[i] = new IField[6];
                for (var j = 0; j < 6; j++)
                {
                    fields[i][j] = new Field(i,j);
                }
            }

            for (int i = 0; i < 7; i++)
            {
                fields[i][4].GamePiece = new GamePiece(new Color(128,0,0),"Foo" );
            }

            for (int i = 0; i < 7; i++)
            {
                fields[i][5].GamePiece = new GamePiece(new Color(0,0,128), "Bar");
            }

            _fields = fields.SelectMany(innerArray => innerArray).ToList();

            // initialize column commands
            var clickColumnCommands = new List<IClickColumnsCommand>();
            for (int i = 0; i < 7; i++)
            {
                var canExecute = i != 0 && i != 1;
                clickColumnCommands.Add(new ClickColumnCommandDummy(canExecute, i));
            }
            _clickColumnsCommands = clickColumnCommands;
        }
        public IReadOnlyList<IField> Fields
        {
            get { return _fields; }
        }
        public IReadOnlyList<IClickColumnsCommand> ClickColumnsCommands => _clickColumnsCommands;
    }
}
