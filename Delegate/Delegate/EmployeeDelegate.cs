using Delegate.Models;

namespace Delegate
{
    internal class EmployeeDelegate
    {
        public delegate bool CheckSalary(List<Person> person);
        public static void ShowPersons(List<Person> persons, Predicate<Person> predicate)
        {
            persons.FindAll(predicate).ForEach(person =>
                Console.WriteLine($"{person.Name} - {person.Surname} - {person.Address}"));
        }
        public static void Result(int salary)
        {
            List<Person> people = new()
            {
            new Person() { Name = "Tofiq", Surname = "Nasibli", Salary = 15000, Address = "USA" },
            new Person() { Name = "Ali", Surname = "Shukurlu", Salary = 1400, Address = "Germany" },
            new Person() { Name = "Ali", Surname = "Huseynov", Salary = 200, Address = "Azerbaijan" },
            };

            ShowPersons(people, people => people.Salary > salary);
        }
    }
}
