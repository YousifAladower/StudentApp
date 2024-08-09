using StudentApp.Modules.Domain;

namespace StudentApp.Repository.Interface
{
    public interface IStudentRepository
    {
        Task<Student> creatStudentAsync(Student Student);
        Task<IEnumerable<Student>> getAllStudentAsync();
        Task<Student?> editStudentAsync(Student Student);
        Task<Student?> geStudenttByIDAsync(int id);

        Task<Student?> deleteStudentAsync(int id);
    }
}
