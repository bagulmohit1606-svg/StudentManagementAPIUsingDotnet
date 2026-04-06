using StudentManagementSystem.Interfaces;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _repo;

        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public async Task<List<Student>> GetAll()
            => await _repo.GetAll();

        public async Task Add(Student student)
        {
            student.CreatedDate = DateTime.UtcNow;
            await _repo.Add(student);
        }

        public async Task Update(Student student)
            => await _repo.Update(student);

        public async Task Delete(int id)
            => await _repo.Delete(id);
    }
}