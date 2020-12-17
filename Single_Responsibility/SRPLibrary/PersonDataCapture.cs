using System.IO;

namespace SRPDemo
{
    public class PersonDataCapture
    {
        private static readonly string firstNameMessage = "What is your first name? : ";
        private static readonly string lastNameMessage = "What is your last name? : ";
        public static Person Capture()
        {
            return new Person
            {
                FirstName = GetName(firstNameMessage),
                LastName = GetName(lastNameMessage)
            };

            // user.FirstName = GetName("What is your first name? : ");
            // LastName = GetName("What is your last name? : ");

            // return user;
        }

        private static string GetName(string sentence)
        {
            while (true)
            {
                try
                {
                    StandardMessages.PrintMessage(sentence, NewLineCharacter.no);
                    return StandardMessages.ReadLine();
                }
                catch (IOException)
                {
                    StandardMessages.PrintMessage("Invalid entry, please try again");
                    continue;
                }
            }
        }
    }
}