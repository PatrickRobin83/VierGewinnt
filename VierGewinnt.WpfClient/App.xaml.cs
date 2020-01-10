using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using VierGewinnt.Core;
using VierGewinnt.WpfClient.Commands;
using VierGewinnt.WpfClient.Interfaces;

namespace VierGewinnt.WpfClient
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Composition root
            var gameBoard = new GameBoardFactory(new FieldDecoratorFactory()).Create(6,7);
            
            Player playerA = CreatePlayer("Player A", new Color(0, 0, 128));
            Player playerB = CreatePlayer("Player B", new Color(128, 0, 0));

            var playerViewModels = new List<IPlayerViewModel>
            {
                new PlayerViewModel(playerA) {ItsPlayersTurn = true},
                new PlayerViewModel(playerB)
            };

            var fields = gameBoard.Fields.SelectMany(twoDimensionArray => twoDimensionArray).ToList();
            var clickColumnsCommands = new List<IClickColumnsCommand>();

            var gameBoardViewModel = new GameBoardViewModel(fields, clickColumnsCommands);

            var mainWindowViewModel = new MainWindowViewModel(playerViewModels, 
                                                              gameBoardViewModel, 
                                                              gameBoard);
        
            clickColumnsCommands.AddRange(gameBoard.Columns.Select(column => new ClickColumnCommand(column,mainWindowViewModel)));

            // Show MainWindow 
            MainWindow = new MainWindow{DataContext = mainWindowViewModel};
            MainWindow.Show();
        }

        private static Player CreatePlayer(string name, Color playerColor)
        {
            var gamePieces = new ObservableCollection<GamePiece>();
            for (int i = 0; i < 21; i++)
            {
                gamePieces.Add(new GamePiece(playerColor, name));
            }
            return new Player(name,gamePieces,playerColor);
        }
    }
}
