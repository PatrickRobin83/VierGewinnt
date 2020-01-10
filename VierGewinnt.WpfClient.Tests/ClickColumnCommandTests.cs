using Microsoft.VisualStudio.TestTools.UnitTesting;
using VierGewinnt.Core.Tests;
using VierGewinnt.WpfClient.Commands;

namespace VierGewinnt.WpfClient.Tests
{
    [TestClass]
    public class ClickColumnCommandTests
    {
        private MainWindowViewModelMock _mainWindowViewModelMock;
        private ClickColumnCommand _testTarget;
        private ColumnMock _columnMock;
        [TestInitialize]
        public void TestInitialize()
        {
            _mainWindowViewModelMock = new MainWindowViewModelMock();
            _columnMock = new ColumnMock();
            _columnMock.IsColumnFull = false;
            _testTarget = new ClickColumnCommand(_columnMock,_mainWindowViewModelMock);
        }

        [TestMethod]
        public void CommandExecutesCanExecuteChangedIfWinnerIsSetOnMainWindowViewModel()
        {
            var canExecuteChangedCalls = 0;
            _testTarget.CanExecuteChanged += (sender, args) => canExecuteChangedCalls++;
            _mainWindowViewModelMock.SetWinner("Foo");
            Assert.AreEqual(1, canExecuteChangedCalls);
        }

        [TestMethod]
        public void CanExecuteReturnsTrueIfWinnerIsNotSetAndColumnIsNotFull()
        {
            var canExecute = _testTarget.CanExecute(null);
            Assert.IsTrue(canExecute);
        }
        [TestMethod]
        public void CanExecuteReturnsFalseIfColumnFull()
        {
            _columnMock.IsColumnFull = true;
            var canExecute = _testTarget.CanExecute(null);
            Assert.IsFalse(canExecute);
        }

        [TestMethod]
        public void CanExecuteReturnsFallsIfWinnerIsSet()
        {
            _mainWindowViewModelMock.SetWinner("Foo");
            var canExecute = _testTarget.CanExecute(null);
            Assert.IsFalse(canExecute);
        }

        [TestMethod]
        public void ExecuteCallsPlayTurnOnMainWindowViewModel()
        {
            _testTarget.Execute(null);
            Assert.IsTrue(_mainWindowViewModelMock.IsPlayTurnOnlyOnceCalled);
        }

        [TestMethod]
        public void CanExecuteRaisesCanExecuteChangedIfColumnFullAfterPlayersTurn()
        {
            var countCanExecuteChangedCalls = 0;
            _testTarget.CanExecuteChanged += (sender, args) => countCanExecuteChangedCalls++;
            _columnMock.IsColumnFull = true;
            _testTarget.Execute(null);

            Assert.AreEqual(1,countCanExecuteChangedCalls);

        }
    }
}
