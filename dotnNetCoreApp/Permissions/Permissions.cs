namespace dotnNetCoreApp.Permissions
{
    public class Permissions
    {
        public static string[] GetPermissions(string title)
        {    var permissions = new List<string>();
            if (title == "judge")
                permissions.Add("admin");
            //..
            //returns the permission for the job title.
            return permissions.ToArray();
        }
    }
}
