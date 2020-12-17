namespace OCPLibrary
{
    internal class ExecutiveAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            return new EmployeeModel
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                EmailAddress = $"{ person.FirstName }{ person.LastName}@acmecorp.com",
                IsManager = true,
                IsExecutive = true
            };
        }
    }
}