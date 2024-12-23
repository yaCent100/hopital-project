using HopitalAPI.Models;

namespace HopitalAPI.Data
{
    public static class DbInitializer
    {
        public static void Initialize(HopitalDbContext context)
        {
            context.Database.EnsureCreated();

            // Vérifier si des utilisateurs existent déjà
            if (context.Users.Any()) return;

            // Ajouter des utilisateurs de test
            var utilisateurs = new User[]
            {
                new User("Admin", "admin@hopital.com", "admin123", "Administrateur"),
                new User("Dr. Smith", "smith@hopital.com", "doctor123", "Medecin"),
                new User("John Doe", "john.doe@gmail.com", "patient123", "Patient")
            };
            context.Users.AddRange(utilisateurs);

            // Ajouter des rendez-vous de test
            var rendezVous = new RendezVous[]
            {
                new RendezVous { Date = DateTime.Now.AddDays(2), Heure = "10:00", Medecin = "Dr. Smith", Patient = "John Doe" }
            };
            context.RendezVous.AddRange(rendezVous);

            // Enregistrer les modifications
            context.SaveChanges();
        }
    }
}
