using System;

namespace DIPLibrary
{
    public class Emailer : IMessageSender
    {
        public void SendMessage(IPerson owner, string message)
        {
            Console.WriteLine($"Simulating sending an email to { owner.EmailAddress }");
        }
    }
}