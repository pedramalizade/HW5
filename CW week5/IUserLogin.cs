using System;
using Cw5;
namespace Interface
{
    public interface IUserLogin
    {
        public bool IsLoggedIn(string email, string password);
    }
}
