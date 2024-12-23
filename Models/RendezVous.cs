namespace HopitalAPI.Models
{
    public class RendezVous
    {
        // Propriétés
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Heure { get; set; }
        public string Medecin { get; set; }
        public string Patient { get; set; }

        // Constructeur par défaut (requis par Entity Framework)
        public RendezVous()
        {
        }

        // Constructeur sans l'Id (par exemple, lors de la création d'un rendez-vous avant de l'enregistrer)
        public RendezVous(DateTime date, string heure, string medecin, string patient)
        {
            Date = date;
            Heure = heure;
            Medecin = medecin;
            Patient = patient;
        }
    }
}
