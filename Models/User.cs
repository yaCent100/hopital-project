namespace HopitalAPI.Models
{
    public class User
    {
        public int Id { get; set; } // Propriété publique pour EF Core
        public string Nom { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        // Constructeur avec paramètres
        public User(string nom, string email, string password, string role)
        {
            Nom = nom;
            Email = email;
            Password = password;
            Role = role;
        }

        // Constructeur par défaut requis par EF Core
        public User()
        {
        }
    }
}
