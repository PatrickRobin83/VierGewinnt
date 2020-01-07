using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VierGewinnt.Core;

namespace VierGewinnt.WpfClient.Tests
{
    public class MainWindowViewModelMock : IMainWindowViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void SetWinner(string name)
        {
            WinnerText = name;
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("WinnerText"));
        }

        public IGameBoardViewModel GamerBoardViewModel
        {
            get
            {
                throw  new NotSupportedException();
            }
        }

        public IReadOnlyList<IPlayerViewModel> PlayerViewModels
        {
            get
            {
                throw  new NotSupportedException();
            }
        }

        public string WinnerText { get; private set; }
        public void PlayTurn(IColumn column)
        {
            CountPlayTurnCalls++;
        }
        public int CountPlayTurnCalls { get; private set; }
        public bool IsPlayTurnOnlyOnceCalled
        {
            get { return CountPlayTurnCalls == 1; }
        }
    }
}
