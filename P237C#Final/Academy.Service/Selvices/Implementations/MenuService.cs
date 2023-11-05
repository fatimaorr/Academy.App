
using Academy.Core.Enums;
using Academy.Data.Repositories;
using Academy.Service.Selvices.Implementations;
using Academy.Service.Selvices.Interfaces;

namespace Academy.Service.Selvices.Implementations
{
    public class MenuService
    {
        IStudentService studentService = new StudentService();
          public async Task RunApp()
        {

            await Menu();
            string request = Console.ReadLine();
            while (request != null)
            {
                switch (request)
                {
                    case "1":
                        await CreatStudent();
                        break;
                    case "2":
                        await UpdateStudent();
                        break;
                    case "3":
                        await RemoveStudent();
                        break;
                    case "4":
                        await GetAllStudent();
                        break;
                    case "5":
                        await Get();
                        break;
                    default:
                        break;
                }
                await Menu();
                request = Console.ReadLine();
            }
        }
          async Task CreatStudent()
        {
            Console.WriteLine("add fullName");
            string FullName = Console.ReadLine();
            Console.WriteLine("add group");
            string Group = Console.ReadLine();
            Console.WriteLine("add average");
            int.TryParse(Console.ReadLine(), out int Average);
            int i = 1;

            foreach (var item in Enum.GetValues(typeof(Education)))
            {
                Console.WriteLine($"{i}.{item}");
                i++;
            }
            bool IsExsist;
            int EnumIndex;
            do
            {

                Console.WriteLine("Add StudentRepository");
                int.TryParse(Console.ReadLine(), out EnumIndex);
                IsExsist = Enum.IsDefined(typeof(Education), (Education)EnumIndex);
            } while (!IsExsist);

            string result = await studentService.CreateAsync(FullName, Group, Average, (Education)EnumIndex);
            Console.WriteLine(result);
        }
          async Task UpdateStudent()
        {
            Console.WriteLine("add Id");
            string Id = Console.ReadLine();
            Console.WriteLine("add fullName");
            string FullName = Console.ReadLine();
            Console.WriteLine("add group");
            string Group = Console.ReadLine();
            Console.WriteLine("add average");
            int.TryParse(Console.ReadLine(), out int Average);
            int i = 1;

            foreach (var item in Enum.GetValues(typeof(Education)))
            {
                Console.WriteLine($"{i}.{item}");
                i++;
            }
            bool IsExsist;
            int EnumIndex;
            do
            {

                Console.WriteLine("Add Education");
                int.TryParse(Console.ReadLine(), out EnumIndex);
                IsExsist = Enum.IsDefined(typeof(Education), (Education)EnumIndex);
            } while (!IsExsist);

            string result = await studentService.UpdateAsync( Id,FullName, Group, Average, (Education)EnumIndex);
            Console.WriteLine(result);
        }
          async Task RemoveStudent()
        {
            Console.WriteLine("add Id");
            string Id = Console.ReadLine();
           string result= await studentService.RemoveAsync(Id);
            Console.WriteLine(result);
        }
          async Task GetAllStudent()
        {
            await studentService.GetAllAsync();
        }
          async Task Get()
        {
            Console.WriteLine("add Id");
            string Id = Console.ReadLine();
            string  result= await studentService.GetAsync(Id);
            Console.WriteLine(result);
        }
        
         async Task Menu()
        {



            Console.WriteLine("1.Create");
            Console.WriteLine("2.Update");
            Console.WriteLine("3.Remove");
            Console.WriteLine("4.Get");
            Console.WriteLine("5.GetAll");
            Console.WriteLine("0.Close");







         }
    }
}
