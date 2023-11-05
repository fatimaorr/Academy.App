

using Academy.Core.Enums;
using Academy.Core.Modes;
using Academy.Core.Repositories;
using Academy.Data.Repositories;
using Academy.Service.Selvices.Interfaces;


namespace Academy.Service.Selvices.Implementations
{
    public class StudentService : IStudentService
    {
        StudentRepository _istudentRepository = new StudentRepository();
        
        public async Task<string> CreateAsync(string fullName, string group, int average, Education education)
        {
            if (string.IsNullOrEmpty(fullName))
                return "Full name is can not be empty";
            if (string.IsNullOrEmpty(group))
                return "Full name is can not be empty";
            if (average<0 &&average>100)
                return "0-100";
            Student student = new Student(fullName, group, average,education);
            student.CreatedAt = DateTime.UtcNow.AddHours(4);
            await _istudentRepository.AddAsync(student);
            return "Created succefully";
        }

        public async Task GetAllAsync()
        {
            List<Student> students = await _istudentRepository.GetAllAsync();

            foreach(Student student in students)
            {
                 Console.WriteLine($"Id:{student. Id}FullName:{student. FullName}Group:{student .Group }Average:{student .Average }Education:{student .Education }CreatedAt:{student .CreatedAt}UpdatedAt:{student .UpdateAt}"  );

            }
             
        }
        public async Task<string> RemoveAsync(string id)
        {
            Student student = await _istudentRepository.GetAsync(x => x.Id == id);
            if (student == null)
                return "Student not found";
            Console.WriteLine($"Id:{student.Id}FullName:{student.FullName}Group:{student.Group}Average:{student.Average}Education:{student.Education}CreateAt:{student.CreatedAt}UpdatedAt:{student.UpdateAt}");
            return "Success";
        }

        public async  Task<string> GetAsync(string id)
        {
            Student student = await _istudentRepository.GetAsync(x => x.Id == id);
            if (student == null)
                return "Student not found";
            await _istudentRepository.RemoveAsync(student);

            return "Removed successfully";

        }

        

        public  async Task<string> UpdateAsync(string id, string fullName, string group, int average, Education education)
        {
            Student student = await _istudentRepository.GetAsync(x => x.Id == id);

            if (student == null)
                return "Student not found";

            if (string.IsNullOrEmpty(fullName))
                return "Full name is can not be empty";
            if (string.IsNullOrEmpty(group))
                return "Full name is can not be empty";
            if (average < 0 && average > 100)
                return "0-100";

            student.FullName = fullName;
            student.Group = group;
            student.Average = average;
            student.Education = education;
            student.UpdateAt = DateTime.UtcNow.AddHours(4);
            return "Updated successfully";
        }
    }
}
