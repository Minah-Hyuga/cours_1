using Cours.Models;

namespace Cours.Service
{
    public interface IRSService
    {
        List<RS> FindAll();
        RS FindById(int id);
        void Save(RS rs);
        void Delete(int id);
        void Update(RS rs);
        void AddCourse(RS rs, string name, DateTime date, string time, string semester);
        void MarkAbsence(RS rs, int studentId, int courseId);
    }
}
