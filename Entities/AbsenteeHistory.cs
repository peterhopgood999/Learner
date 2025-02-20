namespace Learner.Entities
{
    public class AbsenteeHistory
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime AbsenceDate { get; set; }
        public string Reason { get; set; }

        // Navigation property
        public Employee Employee { get; set; }

        public AbsenteeHistory(int id, int employeeId, DateTime absenceDate, string reason)
        {
            Id = id;
            EmployeeId = employeeId;
            AbsenceDate = absenceDate;
            Reason = reason;
        }

        public override string ToString()
        {
            return $"Employee ID: {EmployeeId}, Absence Date: {AbsenceDate.ToShortDateString()}, Reason: {Reason}";
        }
    }
}