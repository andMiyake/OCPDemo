namespace Problem.OCPLibrary
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public EmployeeType TypeOfEmployee { get; set; } = EmployeeType.Staff;
    }
}
