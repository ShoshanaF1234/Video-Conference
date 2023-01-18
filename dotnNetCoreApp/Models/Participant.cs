namespace dotnNetCoreApp.Models
{
    public class Participant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public bool Video { get; set; }//to know for next time if to keep video on
        public bool Sound { get; set; }
    }
}
