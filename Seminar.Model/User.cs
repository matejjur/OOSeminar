namespace Seminar.Model
{
    public class User
    {

        public string Username { get; set; }
        public string Password { get; set; }

        public User(string UsrName, string Pass)
        {
            Username = UsrName;
            Password = Pass;
        }

    }
}
