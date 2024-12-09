using Cours.Models;

namespace Cours.View
{
    public static class ComptableView
    {
        // Affiche la liste des comptables
        public static void ListComptables(List<Comptable> comptables)
        {
            foreach (var comptable in comptables)
            {
                Console.WriteLine(comptable);
            }
        }

        // Crée un nouveau comptable
        public static Comptable CreateComptable()
        {
            Console.Write("Nom du comptable : ");
            string name = Console.ReadLine();
            Console.Write("Email : ");
            string email = Console.ReadLine();
            return new Comptable(name, email);
        }

        // Met à jour les informations d'un comptable
        public static void UpdateComptable(Comptable comptable)
        {
            Console.Write("Nouveau nom du comptable : ");
            string newName = Console.ReadLine();
            Console.Write("Nouvel email : ");
            string newEmail = Console.ReadLine();
            comptable.Name = newName;
            comptable.Email = newEmail;
            Console.WriteLine("Comptable modifié!");
        }

        // Supprimer un comptable
        public static int DeleteComptable()
        {
            Console.Write("Voulez-vous supprimer un comptable ? (o/n) ");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "o")
            {
                Console.Write("Id du comptable à supprimer : ");
                return Convert.ToInt32(Console.ReadLine());
            }
            return 0;
        }

        // Ajouter un paiement au comptable
        public static void AddPayment(Comptable comptable)
        {
            Console.Write("Montant du paiement : ");
            decimal amount = Convert.ToDecimal(Console.ReadLine());

            comptable.AddPayment(amount);
            Console.WriteLine("Paiement ajouté!");
        }

        // Générer un rapport financier
        public static void GenerateReport(Comptable comptable)
        {
            comptable.GenerateFinancialReport();
            Console.WriteLine("Rapport financier généré!");
        }

        internal static int SaisirId()
        {
            throw new NotImplementedException();
        }
    }
}
