using System;

namespace PublicProtectedPrivate
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                FirstName = "egemen",
                LastName = "io"
            };

            //public, from irrelevant class
            Console.WriteLine(employee.FirstName);
            Console.WriteLine(employee.GetFullName());

            //protected, from irrelevant class
            //employee.SSN = "123-45-6789"; ERRORR!!

            //public method, from irrelevant class
            employee.SetSSN("123-45-6789");

            Developer developer = new Developer
            {
                FirstName = "egemen",
                LastName = "io",
                Title = "Developer"
            };

            //private, from irrelevant class
            //developer.Sex('F'); ERRORR!!

            //public method, from irrelevant class
            developer.SetSex('F');
            developer.SetSSN("123-45-6789");

            //public methods, from irrelevant class
            Console.WriteLine(developer.GetFullNameWithTitle());
            Console.WriteLine(developer.IsSSNValid());
            Console.WriteLine(developer.IsFemale());
            Console.ReadLine();
        }
    }
}
