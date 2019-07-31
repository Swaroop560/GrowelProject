namespace GrowelAPI.Model
{
    public class Login
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string UserRole { get; set; }

    }
}


