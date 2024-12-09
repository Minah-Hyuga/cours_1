using Cours.Models;

namespace Cours.Repository
{
    public interface IComptableRepository
    {
        List<Comptable> SelectAll();
        Comptable SelectById(int id);
        void Insert(Comptable comptable);
        void Update(Comptable comptable);
        void Delete(int id);
    }
}
