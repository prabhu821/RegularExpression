namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Regular Expression!");
            Pattern pattern = new Pattern();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter option to choose \n1.First Name \n2.Last Name \n3.Email \n4.Mobile Number \n5.Password Rule 1" +
                    "\n6.Password Rule 2 \n7.Password Rule 3 \n8.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nEnter First Name");
                        string fName = Console.ReadLine();
                        pattern.validateFirstName(fName);
                        break;
                    case 2:
                        Console.WriteLine("\nEnter Last Name");
                        string lName = Console.ReadLine();
                        pattern.validateLastName(lName);
                        break;
                    case 3:
                        Console.WriteLine("\nEnter Email");
                        string email = Console.ReadLine();
                        pattern.validateEmail(email);
                        break;
                    case 4:
                        Console.WriteLine("\nEnter Mobile Number");
                        string mobileNumber = Console.ReadLine();
                        pattern.validateMobileNumber(mobileNumber);
                        break;
                    case 5:
                        Console.WriteLine("\nEnter Password");
                        string password = Console.ReadLine();
                        pattern.validatePassword(password);
                        break;
                    case 6:
                        Console.WriteLine("\nEnter Password");
                        string password2 = Console.ReadLine();
                        pattern.validatePassword2(password2);
                        break;
                    case 7:
                        Console.WriteLine("\nEnter Password");
                        string password3 = Console.ReadLine();
                        pattern.validatePassword3(password3);
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}