using System;
using System.IO;

namespace SRPDemo
{
    public enum NewLineCharacter { no, yes }
    public static class StandardMessages
    {
        public static void WelcomeMessage() => Console.WriteLine("Welcome to my Application on Single Responsibily Principle!");

        public static string ReadLine()
        {
            try
            {
                return Console.ReadLine();
            }
            catch (IOException io)
            {
                throw io;
            }
        }
        public static void PrintMessage(string message) => Console.WriteLine(message);

        public static void PrintMessage(string message, NewLineCharacter type=NewLineCharacter.yes)
        {
            if (type == NewLineCharacter.yes)
                Console.WriteLine(message);
            else
                Console.Write(message);
        }

        public static void DisplayInValidMessage(string parama)
        {
            Console.WriteLine($"You did not give us a valid {parama} name!");
        }
    }
}