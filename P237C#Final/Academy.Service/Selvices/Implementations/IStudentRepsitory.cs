using Academy.Core.Modes;

namespace Academy.Service.Selvices.Implementations
{
    internal interface IStudentRepsitory
    {
        Task AddAsync(Student student);
        List<Product> GetAllAsync();
    }
}