
using CW_week5;
using System.Reflection;

namespace Cw5
{
    public class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Gender Gender { get; set; }
        public List<ContactInfo> ContactInfos { get; set; } = new List<ContactInfo>();


    }
}
