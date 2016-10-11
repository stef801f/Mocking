using System;

namespace Mocking
{
    public class Employee
    {
        public int Id { get; set; }
        public MailBox MailBox { get; internal set; }
        public string Name { get; set; }
        public string Type { get;  set; }
        public int Wage { get; set; }

        public double CalculateWeeklySalary(int hours, int wage)
        {
            return hours*wage;
        }
    }
}