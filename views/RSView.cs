using Cours.Models;

namespace Cours.View
{
    public static class RSView
    {
        // Affiche la liste des responsables pédagogiques
        public static void ListRS(List<RS> rsList)
        {
            foreach (var rs in rsList)
            {
                Console.WriteLine(rs);
            }
        }

        public static RS CreateRS()
        {
            Console.Write("Nom du responsable : ");
            string name = Console.ReadLine();
            Console.Write("Email : ");
            string email = Console.ReadLine();
            return new RS(name, email);
        }

        // Met à jour les informations d'un responsable pédagogique
        public static void UpdateRS(RS rs)
        {
            Console.Write("Nouveau nom du responsable : ");
            string newName = Console.ReadLine();
            Console.Write("Nouvel email : ");
            string newEmail = Console.ReadLine();
            rs.Name = newName;
            rs.Email = newEmail;
            Console.WriteLine("Responsable modifié!");
        }

        // Supprimer un responsable pédagogique
        public static int DeleteRS()
        {
            Console.Write("Voulez-vous supprimer un responsable ? (o/n) ");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "o")
            {
                Console.Write("Id du responsable à supprimer : ");
                return Convert.ToInt32(Console.ReadLine());
            }
            return 0;
        }

        // Ajouter un cours au responsable
        public static void AddCourse(RS rs)
        {
            Console.Write("Nom du cours : ");
            string courseName = Console.ReadLine();
            Console.Write("Date du cours (JJ/MM/AAAA) : ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Heure du cours : ");
            string time = Console.ReadLine();
            Console.Write("Semestre : ");
            string semester = Console.ReadLine();

            rs.AddCourse(courseName, date, time, semester);
            Console.WriteLine("Cours ajouté!");
        }

        // Marquer une absence pour un étudiant
        public static void MarkAbsence(RS rs)
        {
            Console.Write("Id de l'étudiant absent : ");
            int studentId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Id du cours : ");
            int courseId = Convert.ToInt32(Console.ReadLine());

            rs.MarkStudentAbsent(studentId, courseId);
            Console.WriteLine("Absence enregistrée!");
        }

        internal static int SaisirId()
        {
            throw new NotImplementedException();
        }
    }
}
