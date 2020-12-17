namespace SRPDemo
{
    public class AccountGenerator
    {
        public static void Create(Person user)
        {
            StandardMessages.PrintMessage($"Your username is { user.FirstName.Substring(0, 1) }{ user.LastName }");
        }
    }
}