using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeastApplication.ViewModels
{
    public class SportEventViewModel
    {
        public SportEventViewModel()
            :this(0, string.Empty, string.Empty)
        {

        }

        public SportEventViewModel(int peopleCont, string playAt, string creatorName)
        {
            this.PeopleCount = peopleCont;
            this.PlayAt = playAt;
            this.CreatorName = creatorName;
        }

        public int PeopleCount { get; set; }

        public string PlayAt { get; set; }

        public string CreatorName { get; set; }
    }
}
