using Cours.Models;

namespace Cours.Repository.Impl
{
    public class ComptableRepositoryImpl : IComptableRepository
    {
        private readonly List<Comptable> comptableList = new List<Comptable>();

        public List<Comptable> SelectAll() => comptableList;

        public Comptable SelectById(int id) => comptableList.FirstOrDefault(c => c.Id == id);

        public void Insert(Comptable comptable) => comptableList.Add(comptable);

        public void Update(Comptable comptable)
        {
            var index = comptableList.FindIndex(c => c.Id == comptable.Id);
            if (index != -1) comptableList[index] = comptable;
        }

        public void Delete(int id)
        {
            var comptable = comptableList.FirstOrDefault(c => c.Id == id);
            if (comptable != null) comptableList.Remove(comptable);
        }
    }
}
