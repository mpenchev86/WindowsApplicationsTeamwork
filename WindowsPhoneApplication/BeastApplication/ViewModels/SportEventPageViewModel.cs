namespace BeastApplication.ViewModels
{
    using BeastApplication.Helpers;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Windows.Input;

    public class SportEventPageViewModel
    {
        private ObservableCollection<SportEventViewModel> sportEvents;
        private ICommand saveCommand;

        public SportEventPageViewModel()
        {
            this.NewSportEvent = new SportEventViewModel();
        }

        public IEnumerable<SportEventViewModel> SportEvents
        {
            get
            {
                if (this.sportEvents == null)
                {
                    this.sportEvents = new ObservableCollection<SportEventViewModel>();
                }

                return this.sportEvents;
            }

            set
            {
                if (this.sportEvents == null)
                {
                    this.sportEvents = new ObservableCollection<SportEventViewModel>();
                }

                this.sportEvents.Clear();
                foreach (var item in value)
                {
                    this.sportEvents.Add(item);
                }
            }
        }

        public SportEventViewModel NewSportEvent { get; set; }

        public ICommand Save
        {
            get
            {
                if (this.saveCommand == null)
                {
                    this.saveCommand = new DelegateCommand(this.HandleSaveCommand);
                }

                return this.saveCommand;
            }
        }

        private void HandleSaveCommand()
        {
            this.sportEvents.Add(new SportEventViewModel(this.NewSportEvent.PlayAt, this.NewSportEvent.Duration, this.NewSportEvent.ExpectedPeopleCount, this.NewSportEvent.CreatorName));
        }
    }
}
