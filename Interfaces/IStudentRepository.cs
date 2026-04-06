using System.Collections.Generic;
using System.Threading.Tasks;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Interfaces
{
    public interface IStudentRepository   // ✅ FIXED (interface, not class)
    {
        Task<List<Student>> GetAll();
        Task<Student?> GetById(int id);
        Task Add(Student student);
        Task Update(Student student);
        Task Delete(int id);
    }
}