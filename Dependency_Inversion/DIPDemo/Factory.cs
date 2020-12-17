using DIPLibrary;

namespace DIPDemo
{
    public static class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static IChore CreateChore()
        {
            return new Chore(CreatLogger(), CreateMessageSender());
        }

        public static ILogger CreatLogger()
        {
            return new Logger();
        }

        public static IMessageSender CreateMessageSender()
        {
            return new Texter();
        }
    }
}