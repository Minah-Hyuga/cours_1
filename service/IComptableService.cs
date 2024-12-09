using Cours.Models;

namespace Cours.Service
{
    public interface IComptableService
    {
        List<Comptable> FindAll();
        Comptable FindById(int id);
        void Save(Comptable comptable);
        void Delete(int id);
        void Update(Comptable comptable);
        void AddPayment(Comptable comptable, decimal amount);
        void GenerateReport(Comptable comptable);
    }
}
