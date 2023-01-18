namespace dotnNetCoreApp.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Title { get; set; }
        public string[] Permissions { get; set; }
    }
}
