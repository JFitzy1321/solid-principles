namespace SRPDemo
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool Validate()
        {
            if (string.IsNullOrWhiteSpace(this.FirstName))
            {
                StandardMessages.DisplayInValidMessage("first");
                return false;
            }

            if (string.IsNullOrWhiteSpace(this.LastName))
            {
                StandardMessages.DisplayInValidMessage("last");
                return false;
            }

            return true;
        }
    }
}