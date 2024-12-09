using Cours.Models;
using Cours.Repository;

namespace Cours.Service.Impl
{
    public class ComptableServiceImpl : IComptableService
    {
        private readonly IComptableRepository comptableRepository;

        public ComptableServiceImpl(IComptableRepository comptableRepository)
        {
            this.comptableRepository = comptableRepository;
        }

        public List<Comptable> FindAll() => comptableRepository.SelectAll();

        public Comptable FindById(int id) => comptableRepository.SelectById(id);

        public void Save(Comptable comptable) => comptableRepository.Insert(comptable);

        public void Delete(int id) => comptableRepository.Delete(id);

        public void Update(Comptable comptable) => comptableRepository.Update(comptable);

        // Méthodes supplémentaires
        public void AddPayment(Comptable comptable, decimal amount)
        {
            comptable.AddPayment(amount);
            Update(comptable); // Mettre à jour le comptable après le paiement
        }

        public void GenerateReport(Comptable comptable)
        {
            comptable.GenerateFinancialReport();
        }
    }
}
