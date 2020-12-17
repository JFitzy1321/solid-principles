namespace OCPLibrary
{
    public class ManagerAccount : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            return new EmployeeModel
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAddress = $"{ person.FirstName.Substring(0,1) }{person.LastName}@acmecorp.com",
                IsManager = true
            };
        }
    }
}