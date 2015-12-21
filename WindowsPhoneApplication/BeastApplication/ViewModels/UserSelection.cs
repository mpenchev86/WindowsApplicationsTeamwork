namespace BeastApplication.ViewModels
{
    public static class UserSelection
    {
        private static string sportType = "";
        private static string date = "";

        public static string SportType
        {
            get { return sportType; }
            set { sportType = value; }
        }

        //public static string Location { get; set; }

        public static string Date
        {
            get { return date; }
            set { date = value; }
        }
    }
}
