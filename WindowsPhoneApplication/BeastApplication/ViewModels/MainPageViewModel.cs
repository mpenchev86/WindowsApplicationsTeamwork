using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeastApplication.ViewModels
{
    class MainPageViewModel : ViewModelBase, IPageViewModel
    {
        public string Title
        {
            get
            {
                return "Our App Title";
            }
        }

        public IContentViewModel ContentViewModel { get; set; }
    }
}
