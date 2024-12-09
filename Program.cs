using Cours.Models;
using Cours.Repository;
using Cours.Repository.Impl;
using Cours.Service;
using Cours.Service.Impl;
using Cours.View;

namespace Cours
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Création des repositories et services
            IClientRepository clientRepository = new ClientRepositoryImpl();
            IClientService clientService = new ClientServiceImpl(clientRepository);

            IRSRepository rsRepository = new RSRepositoryImpl();
            IRSService rsService = new RSServiceImpl(rsRepository);

            IComptableRepository comptableRepository = new ComptableRepositoryImpl();
            IComptableService comptableService = new ComptableServiceImpl(comptableRepository);

            int choice;
            do
            {
                choice = Menu();
                switch (choice)
                {
                    // Client Management
                    case 1:
                        Client client = ClientView.CreateClient();
                        clientService.Save(client);
                        break;
                    case 2:
                        ClientView.ListClients(clientService.FindAll());
                        break;
                    case 3:
                        ClientView.ListClients(clientService.FindAll());
                        Client client1 = clientService.FindById(ClientView.SaisirId());
                        if (client1 != null)
                        {
                            ClientView.UpdateClient(client1);
                            clientService.Update(client1);
                        }
                        break;
                    case 4:
                        ClientView.ListClients(clientService.FindAll());
                        Client client2 = clientService.FindById(ClientView.SaisirId());
                        if (client2 != null)
                            clientService.Delete(client2.Id);
                        break;

                    // RS Management
                    case 5:
                        RS rs = RSView.CreateRS();
                        rsService.Save(rs);
                        break;
                    case 6:
                        RSView.ListRS(rsService.FindAll());
                        break;
                    case 7:
                        RSView.ListRS(rsService.FindAll());
                        RS rs1 = rsService.FindById(RSView.SaisirId());
                        if (rs1 != null)
                        {
                            RSView.UpdateRS(rs1);
                            rsService.Update(rs1);
                        }
                        break;
                    case 8:
                        RSView.ListRS(rsService.FindAll());
                        RS rs2 = rsService.FindById(RSView.SaisirId());
                        if (rs2 != null)
                            rsService.Delete(rs2.Id);
                        break;
                    case 9:
                        RSView.ListRS(rsService.FindAll());
                        RS rsToAddCourse = rsService.FindById(RSView.SaisirId());
                        if (rsToAddCourse != null)
                            RSView.AddCourse(rsToAddCourse);
                        break;
                    case 10:
                        RSView.ListRS(rsService.FindAll());
                        RS rsToMarkAbsence = rsService.FindById(RSView.SaisirId());
                        if (rsToMarkAbsence != null)
                            RSView.MarkAbsence(rsToMarkAbsence);
                        break;

                    // Comptable Management
                    case 11:
                        Comptable comptable = ComptableView.CreateComptable();
                        comptableService.Save(comptable);
                        break;
                    case 12:
                        ComptableView.ListComptables(comptableService.FindAll());
                        break;
                    case 13:
                        ComptableView.ListComptables(comptableService.FindAll());
                        Comptable comptable1 = comptableService.FindById(ComptableView.SaisirId());
                        if (comptable1 != null)
                        {
                            ComptableView.UpdateComptable(comptable1);
                            comptableService.Update(comptable1);
                        }
                        break;
                    case 14:
                        ComptableView.ListComptables(comptableService.FindAll());
                        Comptable comptable2 = comptableService.FindById(ComptableView.SaisirId());
                        if (comptable2 != null)
                            comptableService.Delete(comptable2.Id);
                        break;
                    case 15:
                        ComptableView.ListComptables(comptableService.FindAll());
                        Comptable comptableToAddPayment = comptableService.FindById(ComptableView.SaisirId());
                        if (comptableToAddPayment != null)
                            ComptableView.AddPayment(comptableToAddPayment);
                        break;
                    case 16:
                        ComptableView.ListComptables(comptableService.FindAll());
                        Comptable comptableToGenerateReport = comptableService.FindById(ComptableView.SaisirId());
                        if (comptableToGenerateReport != null)
                            ComptableView.GenerateReport(comptableToGenerateReport);
                        break;

                    // Exit
                    case 0:
                        Console.WriteLine("Au revoir!");
                        break;
                    default:
                        Console.WriteLine("Choix invalide!");
                        break;
                }
            } while (choice != 0);
        }

        public static int Menu()
        {
            Console.WriteLine("1. Créer un client");
            Console.WriteLine("2. Afficher tous les clients");
            Console.WriteLine("3. Modifier un client");
            Console.WriteLine("4. Supprimer un client");
            Console.WriteLine("5. Créer un responsable pédagogique");
            Console.WriteLine("6. Afficher tous les responsables pédagogiques");
            Console.WriteLine("7. Modifier un responsable pédagogique");
            Console.WriteLine("8. Supprimer un responsable pédagogique");
            Console.WriteLine("9. Ajouter un cours à un responsable pédagogique");
            Console.WriteLine("10. Marquer une absence pour un étudiant");
            Console.WriteLine("11. Créer un comptable");
            Console.WriteLine("12. Afficher tous les comptables");
            Console.WriteLine("13. Modifier un comptable");
            Console.WriteLine("14. Supprimer un comptable");
            Console.WriteLine("15. Ajouter un paiement à un comptable");
            Console.WriteLine("16. Générer un rapport financier");
            Console.WriteLine("0. Quitter");
            Console.Write("Votre choix : ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
