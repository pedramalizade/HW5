

using System.Reflection;
using System.Xml.Linq;

namespace Cw5
{
    public static class Storage
    {
        public static Person CurrentUser { get; set; }


        public static List<Person> persons { get; set; } = new List<Person>()
        {
            new Person()
            {
                Name = "setareh" , Family = "zaman", Age = 20, Gender = Gender.female, Email = "setareh@gamil.com",Password = "12345", ContactInfos = new List<ContactInfo>()
                {
                    new ContactInfo()
                    {
                        City = "tehran", Address = "Tehran", PhoneNumber = "09120000",
                    }
                }
            },
            new Person()
            {
                Name = "Ali" , Family = "tahmasbi", Age = 20, Gender = Gender.male, Email = "Ali@gamil.com",Password= "4566789", ContactInfos = new List<ContactInfo>()
                {
                    new ContactInfo()
                    {
                        City = "tehran", Address = "Tehran", PhoneNumber = "0912002230"
                    }
                }
            }
        };


    }
}
