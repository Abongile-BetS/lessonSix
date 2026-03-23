namespace convertArray_3_
{
    internal class Program
    {
        
        public class User
        {
            private string _username;

            public User(string username)
            {
                _username = username;
            }

            public string Username
            {
                get
                {
                    return _username;
                }
                set
                {
                    // TODO:
                    // 1. Check if value is null, empty, or whitespace
                    if(string.IsNullOrWhiteSpace(value))
                    {
                        Console.WriteLine("Error: Cannot be empty");
                        return;
                    }
                    
                    _username = value;
                    // 2. Print an error message and return if invalid
                    // 3. Otherwise update _username
                }
            }
        }
        public static void Main()
        {
            var user = new User("Witcher01");

            Console.WriteLine($"Starting username: {user.Username}");

            user.Username = "";
            Console.WriteLine($"After invalid update: {user.Username}");

            user.Username = "WhiteWolf";
            Console.WriteLine($"After valid update: {user.Username}");
        }
    }
}
