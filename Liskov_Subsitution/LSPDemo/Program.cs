using System;
using LSPLibrary;

namespace LSPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var accoutingVP = new Manager()
            {
                FirstName = "Emma",
                LastName = "Stone"
            };
            accoutingVP.CalculatePerHourRate(4);

            var emp = new Manager()
            {
                FirstName = "Joe",
                LastName = "Fitz"
            };
            //emp.AssignManager(accoutingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");
            Console.WriteLine($"{ emp.FirstName } is a { emp.GetType().Name }.");

            Console.WriteLine(
                        !(emp is CEO)
                        ? $"{ emp.FirstName }'s manager is { (emp as IManaged).Manager.FirstName } { (emp as IManaged).Manager.LastName }." : $"{ emp.FirstName } doesn't have a manager because they are the CEO!"
                    );

        }
    }
}
