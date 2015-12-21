using BeastApplication.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BeastApplication.ViewModels
{
    public class SportEventViewModel : ViewModelBase
    {
        private ObservableCollection<PlayersViewModel> players;
        private ICommand joinCommand;
        private int actualPeopleCount;
        private bool isJoined;
        private string playAt;

        public SportEventViewModel()
            : this(string.Empty, 0, 0, string.Empty)
        {
            this.players = new ObservableCollection<PlayersViewModel>();
            this.NewPlayer = new PlayersViewModel();
        }

        public SportEventViewModel(string playAt, int duration, int expectedPeopleCount, string creatorName)
        {
            this.PlayAt = playAt;
            this.Duration = duration;
            this.ExpectedPeopleCount = expectedPeopleCount;
            this.CreatorName = creatorName;
            this.players = new ObservableCollection<PlayersViewModel>();
            this.NewPlayer = new PlayersViewModel();
        }

        public int ActualPeopleCount
        {
            get
            {
                return this.actualPeopleCount;
            }
            set
            {
                this.actualPeopleCount = value;
                this.RaisePropertyChange("ActualPeopleCount");
            }
        }

        public bool IsJoined
        {
            get
            {
                return !this.isJoined;
            }
            set
            {
                this.isJoined = value;
                this.RaisePropertyChange("IsJoined");
            }
        }
        public string PlayAt { get; set; }

        public int Duration { get; set; }

        public int ExpectedPeopleCount { get; private set; }

        public string CreatorName { get; set; }

        public PlayersViewModel NewPlayer { get; set; }

        public ICommand Join
        {
            get
            {
                if (this.joinCommand == null)
                {
                    this.joinCommand = new DelegateCommand(this.HandleJoinCommand);
                }

                return this.joinCommand;
            }
        }

        private void HandleJoinCommand()
        {
            this.players.Add(new PlayersViewModel(this.NewPlayer.Name));
            this.ActualPeopleCount = this.players.Count;
            this.IsJoined = true;
        }
    }
}
