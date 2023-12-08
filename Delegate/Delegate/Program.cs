

using Delegate;
using Delegate.Extentions;

Console.WriteLine("Welcome");
T:
menu();
int cons =int.Parse(Console.ReadLine());

switch (cons)
{
    case 1:
        BookDelegate bookD = new BookDelegate();
    Author:
        Console.WriteLine("Select Authors Name to Know How many Books we have: ");
        Console.WriteLine(" 1 - Jafar Jabbarli: \n 2 - Mirza Fatali Akundov: \n 3 - Nizami Ganjavi: ");

        #region x

        bool res;
        int num;
        string myStr = Console.ReadLine();
        res = int.TryParse(myStr, out num);
        #endregion
        #region x
        Authors authors = new Authors();
        string authorName;

        switch (num)
        {
            case 1:
                authorName = Authors.Jafar_Jabbarli.ToString();
                Console.Write("Book Count: ");
                bookD.Result(authorName);
                break;
            case 2:
                authorName = Authors.Mirza_Fatali_Akundov.ToString();
                Console.Write("Book Count: ");
                bookD.Result(authorName);
                break;
            case 3:
                authorName = Authors.Nizami_Ganjavi.ToString();
                Console.Write("Book Count: ");
                bookD.Result(authorName);
                break;
            default:
                authorName = string.Empty;
                Console.WriteLine("Author is not in the List Try Again: \n");
                goto Author;

        }
        #endregion
        goto T;
    case 2:
        EmployeeDelegate employee = new EmployeeDelegate();

        Console.WriteLine("Enter Employee starting Salary to Know who earns higher: ");

        EmployeeDelegate delegatePredicate = new EmployeeDelegate();
        int a = int.Parse(Console.ReadLine());
        EmployeeDelegate.Result(a);
        goto T;
    case 3:
        Console.WriteLine("Goodbye");
        break;
    default:
        
        Console.WriteLine("Not Right key was Pressed: \n");
        goto T;

}

static void menu()
{
    Console.WriteLine("\n For Task (1) Books Enter (1) \n For Task (2) Employees Enter (2) \n Exit (3)");
}


