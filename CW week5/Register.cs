using Interface;

namespace CWwek5
{
    public class RegisterUser : IUserRegister
    {
        public bool Register(Person person)
        {
            foreach (var item in Storage.persons)
            {
                if (item.Email == person.Email)
                {
                    return false;
                }
            }
            Storage.persons.Add(person);
            return true;
        }
    }
}
