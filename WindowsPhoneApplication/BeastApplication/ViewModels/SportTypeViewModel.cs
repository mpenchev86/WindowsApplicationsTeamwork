namespace BeastApplication.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SportTypeViewModel : ViewModelBase
    {
        public int StackRow { get; set; }

        public int StackCol { get; set; }

        public string Name { get; set; }

        public string ImagePath { get; set; }
    }
}
