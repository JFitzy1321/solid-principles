using System;
using DIPLibrary;

namespace DIPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Joe";
            owner.LastName = "Fitz";
            owner.EmailAddress = "joe@email.com";
            owner.PhoneNumber = "555-1234";

            var chore = Factory.CreateChore();
            chore.ChoreName = "Take out the trash";
            chore.Owner = owner;

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();
        }
    }
}
