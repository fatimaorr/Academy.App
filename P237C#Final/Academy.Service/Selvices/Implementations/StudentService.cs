

using Academy.Core.Enums;
using Academy.Core.Modes;
using Academy.Service.Selvices.Interfaces;
using System.Collections.ObjectModel;

namespace Academy.Service.Selvices.Implementations
{
    internal class StudentService : IStudentService
    {
        IStudentRepsitory _studentRepsitory = new StudentRepsitory();
        private IEnumerable<object> collection;
        private IEnumerable<Student> studens;
        private object student;

        public  async Task<string> CreateAsync(string fullName, string group, int average, Education education)
        {
            if(string .IsNullOrWhiteSpace(fullName))
              return "fullName can not be empaty ";

            if (string.IsNullOrWhiteSpace(group))
                return "group can not be empty ";

            if (average <0&& average>100)
                return "Price can not less than 0";

            Student student = new Student(fullName,group,average,education);
           await _studentRepsitory.AddAsync(student);

            return "Successfully created";


        }

        public  async Task GetAllAsync()
        {
            List<Product> products = _studentRepsitory.GetAllAsync();
            foreach (Student student  in studens) ;
            {
                Console.WriteLine($"Id:{student.Id} fullName:{student group}average{student group}"  );
            }
            
        }

        public Task<string> GetAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<string> RemoveAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<string> UpdateAsync(string fullName, string group, int average, Education education)
        {
            throw new NotImplementedException();
        }
    }
}
