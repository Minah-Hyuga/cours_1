using Cours.Models;

namespace Cours.Repository
{
    public interface IRSRepository
    {
        List<RS> SelectAll();
        RS SelectById(int id);
        void Insert(RS rs);
        void Update(RS rs);
        void Delete(int id);
    }
}
