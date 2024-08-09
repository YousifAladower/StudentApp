using Microsoft.EntityFrameworkCore;
using StudentApp.API.Data;
using StudentApp.Modules.Domain;
using StudentApp.Repository.Interface;

namespace StudentApp.Repository.Implmention
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public StudentRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Student> creatStudentAsync(Student Student)
        {
            await _dbContext.AddAsync(Student);
            await _dbContext.SaveChangesAsync();

            return Student;
        }

        public async Task<Student?> deleteStudentAsync(int id)
        {
            var existingSudent = await _dbContext.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (existingSudent != null)
            {
                _dbContext.Students.Remove(existingSudent);
                await _dbContext.SaveChangesAsync();
                return existingSudent;
            }
            return null;
        }

        public async Task<Student?> editStudentAsync(Student Student)
        {
            var existingSudent = await _dbContext.Students.FirstOrDefaultAsync(x => x.Id == Student.Id);

            if (existingSudent != null)
            {
                _dbContext.Entry(existingSudent).CurrentValues.SetValues(Student);
                await _dbContext.SaveChangesAsync();
                return Student;
            }
            return null;
        }

        public async Task<Student?> geStudenttByIDAsync(int id)
        {
            var existingStudent = await _dbContext.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (existingStudent != null)
            {
                return existingStudent;
            }
            return null;
        }

        public async Task<IEnumerable<Student>> getAllStudentAsync()
        {
            return await _dbContext.Students.ToListAsync();
        }
    }
}
