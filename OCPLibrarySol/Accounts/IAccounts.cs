using OCPLibrarySol;
using OCPLibrarySol.Applicants;

namespace OCPLibrarySol.Accounts
{
    public interface IAccounts
    {
        EmployeeModel Create(IApplicantModel person);
    }
}