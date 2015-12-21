namespace BeastApplication.ViewModels
{
    public class PlayersViewModel
    {
        public PlayersViewModel()
        {

        }
        public PlayersViewModel(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }
}