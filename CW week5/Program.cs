using CW_week5;
using static CW_week5.Person;

ContactInfo contactInusing CW week5;


Console.WriteLine("Do you want to (1) Login or (2) Register?");
string choice = Console.ReadLine();

switch (choice)
{
    case "1":
        Console.WriteLine("Enter Email: ");
        string email = Console.ReadLine();

        Console.WriteLine("Enter PAssword: ");
        string password = Console.ReadLine();
        Login login = new Login();
        if (login.IsLoggedIn(email, password))
        {
            Console.WriteLine("user logged in");
        }
        else
        {
            Console.WriteLine("user not logged in");
        }
        break;
    case "2":
        Console.WriteLine("Enter Your Name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Family: ");
        string family = Console.ReadLine();

        Console.WriteLine("Enter Age: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Gender: ");
        Gender gender = (Gender)int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your email:");
        string Email = Console.ReadLine();

        Console.WriteLine("Enter your password:");
        string Password = Console.ReadLine();

        Console.WriteLine("Enter  City:");
        string City = Console.ReadLine();

        Console.WriteLine("Enter Mobile:");
        string Mobile = Console.ReadLine();

        Console.WriteLine("Enter your Address:");
        string Address = Console.ReadLine();


        Person newPerson = new Person();
        ContactInfo contact = new ContactInfo();
        contact.City = City;

        contact.PhoneNumber = Mobile;
        contact.Address = Address;
        newPerson.ContactInfos.Add(contact);


        newPerson.Name = name;
        newPerson.Age = age;
        newPerson.Email = Email;
        newPerson.Password = Password;
        newPerson.Gender = gender;
        newPerson.Family = family;




        Console.WriteLine("which contact do you want to add: ");
        string anything = Console.ReadLine();
        switch (anything)
        {
            case "Yes":
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine("Enter  City:");
                    string city = Console.ReadLine();

                    Console.WriteLine("Enter Mobile:");
                    string mobile = Console.ReadLine();

                    Console.WriteLine("Enter your Address:");
                    string address = Console.ReadLine();
                    ContactInfo contact2 = new ContactInfo();
                    contact2.City = city;
                    contact2.PhoneNumber = mobile;
                    contact2.Address = address;
                    newPerson.ContactInfos.Add(contact2);
                    break;
                }
            case "NO":
                break;
        }
        RegisterUser register = new RegisterUser();
        if (register.Register(newPerson))
        {
            Console.WriteLine("User added");
        }
        else
        {
            Console.WriteLine("User not added");
        }

        break;


}




