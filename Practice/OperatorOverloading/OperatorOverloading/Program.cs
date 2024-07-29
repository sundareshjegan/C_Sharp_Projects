using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee()
            {
                Name = "name1",
                Salary = 700000
            };
            Employee e2 = new Employee()
            {
                Name = "name2",
                Salary = 300000
            };

            // Using the ** operator to add salaries
            Employee totalSalary = e1 == e2;
            Console.WriteLine(totalSalary.Salary);
            Console.Read();
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        // Define ** operator to add salaries
        public static Employee operator ==(Employee e1, Employee e2)
        {
            Employee employeeSum = new Employee();
            employeeSum.Salary = e1.Salary + e2.Salary;
            return employeeSum;
        }
        public static Employee operator !=(Employee e1, Employee e2)
        {
            Employee employeeSum = new Employee();
            employeeSum.Salary = e1.Salary + e2.Salary;
            return employeeSum;
        }
    }
}
