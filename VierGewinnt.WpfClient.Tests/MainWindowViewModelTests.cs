using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VierGewinnt.Core.Tests;
using VierGewinnt.WpfClient.Interfaces;
using VierGewinnt.WpfClient.SampleData;

namespace VierGewinnt.WpfClient.Tests
{
    [TestClass]
    public class MainWindowViewModelTests
    {
        private PlayerMock _playerAMock;
        private PlayerMock _playerBMock;
        private GameBoardMock _gameBoardMock;
        private IMainWindowViewModel _testTarget;
        private List<PlayerViewModelMock> _playerViewModelModelMocks;

        [TestInitialize]
        public void TestInitialize()
        {
            _playerAMock = new PlayerMock();
            _playerBMock = new PlayerMock();
            _gameBoardMock = new GameBoardMock();

            _playerViewModelModelMocks = new List<PlayerViewModelMock>
            {
                new PlayerViewModelMock(_playerAMock) {ItsPlayersTurn = true},
                new PlayerViewModelMock(_playerBMock)

            };
            _testTarget = new MainWindowViewModel(_playerViewModelModelMocks, new GameBoardViewModelSampleData(), _gameBoardMock);
        }
        //[TestMethod]
        //public void PlayTurnDelegateCallsNextPlayer()
        //{
        //    _testTarget.PlayTurn(new ColumnMock());
        //    Assert.IsTrue(_playerAMock.IsPlayTurnOnlyCalledOnce && 
        //                          _playerBMock.CountPlayTurns == 0);
        //}

        //[TestMethod]
        //public void PlayTurnRaisesPropertyChangedWithWinnerNameIsDetermineWinnerIsCalled()
        //{
        //    _gameBoardMock.WinnerName = "Foo";
        //    var countPropertyChangedCalls = 0;
        //    _testTarget.PropertyChanged += (sender, args) => countPropertyChangedCalls++;
        //    _testTarget.PlayTurn(new ColumnMock());

        //    Assert.AreEqual(1,countPropertyChangedCalls);
        //    Assert.AreEqual("Foo",_testTarget.WinnerName);
        //}
        //[TestMethod]
        //public void PlayTurnChangePlayersTurnIfNoWinnerIsFound()
        //{
        //    _testTarget.PlayTurn(new ColumnMock());
        //    Assert.IsTrue(_playerViewModelModelMocks[0].ItsPlayersTurn == false &&
        //                         _playerViewModelModelMocks[1].ItsPlayersTurn == true);
        //}
    }
}
