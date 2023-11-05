
using Academy.Core.Enums;
using Academy.Core.Modes.BaseModes;

namespace Academy.Core.Modes
{
    public class Student : BasModel

    {
        static int _id;
        public object fullName;
        public object group;
        public object average;

        public string FullName { get; set; }
        public string Group { get; set; }
        public int Average { get; set; }

        public Education Education { get; set; }

        public Student(string fullName, string group, int average,Education education)
        {
            _id++;
            FullName = fullName;
            Group = group;
            Average = average;
            Education = education;
            Id = $"{Education.ToString()[0]}-{_id}";

        }

       
    } 
      

    
}
