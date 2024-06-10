using Agiletask9;
List<User> users = new List<User>();
Console.WriteLine("                                                       Welcome");
double balance = 0;

while (true)
{
    Console.WriteLine("1.Registration");
    Console.WriteLine("2.Login");
    Console.WriteLine("3.Output");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Register();
            break;
        case "2":
            Console.WriteLine("Firstly, you must register for Login");
            Register();
            break;
        case "3":
            return;
        default:
            Console.WriteLine("Enter correct number");

            break;
    }
    while (true)
    {
        {
            Console.WriteLine("Login");

            Console.WriteLine("Username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Password: ");
            string password = Console.ReadLine();

            User user = FindUser(username, password);

            if (user != null)
            {
                Console.WriteLine("Login completed successfully");

            }
            else
            {
                Console.WriteLine("Incorrect Username");
                break;
            }

        }

        while (true)
        {

            Console.WriteLine("4.Balance");
            Console.WriteLine("5.Income");
            Console.WriteLine("6.Expense");

            Console.WriteLine("3.Output");

            string choices = Console.ReadLine();

            switch (choices)
            {
                case "4":
                    Balance();
                    break;
                case "5":
                    Income();
                    break;
                case "6":
                    Expense();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Enter correct number");
                    ; break;
            }
        };
    }
}

void Register()
{

    Console.WriteLine("Enter Username: ");
    string username = Console.ReadLine();

    Console.WriteLine("Enter Password: ");
    string password = Console.ReadLine();


    Console.WriteLine("Gmail: ");
    string gmail = Console.ReadLine();


    Console.WriteLine("FirstName: ");
    string firstname = Console.ReadLine();

    Console.WriteLine("LastName: ");
    string lastname = Console.ReadLine();

    Console.WriteLine("Age: ");
    int age = Convert.ToInt32(Console.ReadLine());



    if (UserExists(username))
    {
        Console.WriteLine("This username already exists");

    }
    else

    {

        users.Add(new User
        {
            Username = username,
            Password = password,
            Gmail = gmail,
            FirstName = firstname,
            LastName = lastname,
            Age = age

        });
        Console.WriteLine("Registration completed successfully");
    }


}

bool UserExists(string username)
{
    foreach (User user in users)
    {
        if (user.Username == username)
        {

            return true;
        }
    }
    return false;
}

User FindUser(string username, string password)
{
    foreach (User user in users)
    {
        if (user.Username == username && user.Password == password)
        {
            return user;
        }
    }
    return null;

}
 
void Balance()
{
    Console.WriteLine("Current balance: " + balance);
}
void Income()
{
    Console.WriteLine("Enter the amount: ");
    double amountincluded = Convert.ToDouble(Console.ReadLine());
    if (amountincluded > 0)
    {
        balance += amountincluded;
        Console.WriteLine(amountincluded + " amount  you have invested money. New amount : " + balance);
    }
    else
    {
        Console.WriteLine("Enter correct amount");
    }
}
void Expense()
{
    Console.WriteLine("Enter the amount: ");
    double amountwithdrawn = Convert.ToDouble(Console.ReadLine());
    if (amountwithdrawn <= balance)
    {
        balance -= amountwithdrawn;
        Console.WriteLine(amountwithdrawn + " amount you have withdrawn money. New amount : " + balance);
    }
    else
    {
        Console.WriteLine("You don't have enough money in your balance");
    }
}




