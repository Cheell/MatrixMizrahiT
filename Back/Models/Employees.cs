namespace WebApplication.Models
{
    public class Employees
    {
        public int employeesNumber { get; set; }
        public sbyte month { get; set; }
    
        public Employees(int number, sbyte month)
        {
            employeesNumber = number;
            this.month = month;
        }
    }
}
