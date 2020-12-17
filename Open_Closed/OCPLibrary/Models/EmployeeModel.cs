namespace OCPLibrary
{
    public class EmployeeModel : IApplicantModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public bool IsManager { get; set; } = false;
        public bool IsExecutive { get; set; } = false;
        public IAccounts AccountProcessor { get; set;} = new Accounts();
    }
}