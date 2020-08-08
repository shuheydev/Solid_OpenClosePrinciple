namespace Solid_OpenClosePrinciple
{
    public class TechnicianAccounts : IAccounts
    {
        public EmployeeModel Create(IApplicantModel person)
        {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName}_{person.LastName}@acmecorp.com";

            output.IsTechnician = true ;

            return output;
        }
    }
}