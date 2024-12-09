using Cours.Models;
using Cours.Repository;

namespace Cours.Service.Impl
{
    public class RSServiceImpl : IRSService
    {
        private readonly IRSRepository rsRepository;

        public RSServiceImpl(IRSRepository rsRepository)
        {
            this.rsRepository = rsRepository;
        }

        public List<RS> FindAll() => rsRepository.SelectAll();

        public RS FindById(int id) => rsRepository.SelectById(id);

        public void Save(RS rs) => rsRepository.Insert(rs);

        public void Delete(int id) => rsRepository.Delete(id);

        public void Update(RS rs) => rsRepository.Update(rs);

        // Méthodes supplémentaires
        public void AddCourse(RS rs, string name, DateTime date, string time, string semester)
        {
            rs.AddCourse(name, date, time, semester);
            Update(rs); // Mettre à jour l'RS après l'ajout du cours
        }

        public void MarkAbsence(RS rs, int studentId, int courseId)
        {
            rs.MarkStudentAbsent(studentId, courseId);
            Update(rs); // Mettre à jour l'RS après avoir marqué l'absence
        }
    }
}
