namespace DIPLibrary
{
    public class Chore : IChore
    {
        private ILogger _logger;
        private IMessageSender _sender;
        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }
        public Chore(ILogger logger, IMessageSender sender)
        {
            _logger = logger;
            _sender = sender;
        }
        public void PerformedWork(double hours)
        {
            HoursWorked += hours;

            _logger.Log($"Performed work on { ChoreName } ");
        }

        public void CompleteChore()
        {
            IsComplete = true;

            _logger.Log($"Completed { ChoreName }");

            _sender.SendMessage(Owner, $"The chore { ChoreName } is completed.");
        }
    }
}