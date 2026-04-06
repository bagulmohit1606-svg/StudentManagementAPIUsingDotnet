using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using StudentManagementSystem.Services;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers
{
    [Authorize] // 🔐 PROTECT ALL APIs
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly StudentService _service;

        public StudentController(StudentService service)
        {
            _service = service;
        }

        // ✅ GET ALL
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var students = await _service.GetAll();
            return Ok(students);
        }

        // ✅ ADD
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Student student)
        {
            await _service.Add(student);
            return Ok(new { message = "Student Added Successfully" });
        }

        // ✅ UPDATE
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Student student)
        {
            await _service.Update(student);
            return Ok(new { message = "Student Updated Successfully" });
        }

        // ✅ DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return Ok(new { message = "Student Deleted Successfully" });
        }
    }
}