using Cours.Models;

namespace Cours.Repository.Impl
{
    public class RSRepositoryImpl : IRSRepository
    {
        private readonly List<RS> rsList = new List<RS>();

        public List<RS> SelectAll() => rsList;

        public RS SelectById(int id) => rsList.FirstOrDefault(rs => rs.Id == id);

        public void Insert(RS rs) => rsList.Add(rs);

        public void Update(RS rs)
        {
            var index = rsList.FindIndex(r => r.Id == rs.Id);
            if (index != -1) rsList[index] = rs;
        }

        public void Delete(int id)
        {
            var rs = rsList.FirstOrDefault(r => r.Id == id);
            if (rs != null) rsList.Remove(rs);
        }
    }
}
