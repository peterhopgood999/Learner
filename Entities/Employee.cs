namespace Learner.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string firstName, string lastName, string position, decimal salary)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, Position: {Position}, Salary: {Salary:C}";
        }
    }
}