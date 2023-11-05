
using Academy.Core.Enums;
using System;
namespace Academy.Service.Selvices.Interfaces
{
    public interface IStudentService
    {

        public Task<string> CreateAsync(string fullName,string group,int average,Education education );
        public Task<string> UpdateAsync(string id ,string fullName, string group, int average,Education education);
        public Task<string> RemoveAsync(string id);
        public Task<string> GetAsync (string id);
        public Task GetAllAsync();
      
    }
}