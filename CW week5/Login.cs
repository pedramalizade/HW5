using Cw5;
using Interface;
using System;

public class Login : IUserLogin
{
    public bool IsLoggedIn(string email, string password)
    {

        foreach (var person in Storage.persons)
        {
            if (person.Email.Contains(email))
                if (person.Email == email && person.Password == password)
                {
                    Storage.CurrentUser = person;
                    return true;
                }

        }
        return false;
    }
}
