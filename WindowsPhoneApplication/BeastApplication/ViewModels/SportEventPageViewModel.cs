using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeastApplication.ViewModels
{
    public class SportEventPageViewModel
    {
        private ObservableCollection<SportEventViewModel> sportEvents;

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
    }
}
