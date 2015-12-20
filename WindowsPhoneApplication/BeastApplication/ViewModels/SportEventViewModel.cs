using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeastApplication.ViewModels
{
    public class SportEventViewModel
    {
        private ObservableCollection<PlayersViewModel> players;
        public SportEventViewModel()
            :this(string.Empty, 0, 0, string.Empty)
        {

        }

        public SportEventViewModel(string playAt, int duration, int expectedPeopleCount, string creatorName)
        {
            this.PlayAt = playAt;
            this.Duration = duration;
            this.ExpectedPeopleCount = expectedPeopleCount;
            this.CreatorName = creatorName;
        }

        public int ActualPeopleCount
        {
            get
            {
                return this.players.Count;
            }
        }

        public string PlayAt { get; set; }

        public int Duration { get; set; }

        public int ExpectedPeopleCount { get; private set; }

        public string CreatorName { get; set; }


        public IEnumerable<PlayersViewModel> Players
        {
            get
            {
                if (this.players == null)
                {
                    this.players = new ObservableCollection<PlayersViewModel>();
                }

                return this.players;
            }

            set
            {
                if (this.players == null)
                {
                    this.players = new ObservableCollection<PlayersViewModel>();
                }

                this.players.Clear();
                foreach (var item in value)
                {
                    this.players.Add(item);
                }
            }
        }

       
    }
}
