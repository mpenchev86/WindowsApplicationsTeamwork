using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeastApplication.ViewModels
{
    class MainPageViewModel : IPageViewModel
    {
        public IContentViewModel ContentViewModel { get; set; }

        public string Title { get; set; }
    }
}
