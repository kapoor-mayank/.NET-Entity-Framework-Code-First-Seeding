using EmployeeEFDemo.Models;

namespace EmployeeEFDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new EntityPracDB();
            List<Employee> employees = context.Employees.Select(x => x).ToList();
            Console.WriteLine("1) Displaying Employees Table:");
            Console.WriteLine("----------------------------------------------------------------------------------");
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"ID: {employee.EmpId}, Name: {employee.Name}, Salary: {employee.Salary}, Department: {employee.Department}, City: {employee.City}, DepartmentID: {employee.DepartmentId}");
                Console.WriteLine("----------------------------------------------------------------------------------");
            }

            int count = context.Employees.Count();
            Console.WriteLine($"\nThe total number of employees are: {count}\n\n");
            

            var result = from employee in context.Employees
                         join department in context.Department on employee.DepartmentId equals department.Id
                         orderby department.DeptName
                         select new
                         {
                             employee.EmpId,
                             employee.Name,
                             department.DeptName,
                         };
            Console.WriteLine("Employees Department Wise:\n");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.DeptName}");
                Console.WriteLine($"EmployeeID: {item.EmpId}\nEmployeeName: {item.Name}\n");
            }
            var two = context.Employees.Join(context.Department,
                e=> e.DepartmentId,
                d=> d.Id,
                (e,d) => new {e.Name , e.Department, e.DepartmentId, d.Id, d.DeptName}
                ).GroupBy(d => d.DeptName);
            //foreach (var item in two)
            //{
            //    foreach (var item2 in context.Department)
            //    {
            //        Console.WriteLine($"{item2.DeptName}");
            //    }

            //}

            
            employees = context.Employees.Where(emp => emp.Salary > 25000).Select(x => x).ToList();
            Console.WriteLine("\nSalary above 25000");
            Console.WriteLine("----------------------------------------------------------------------------------");
            foreach (Employee employee in employees)
            {
                
                Console.WriteLine($"ID: {employee.EmpId}, Name: {employee.Name}, Salary: {employee.Salary}, Department: {employee.Department}, City: {employee.City}, DepartmentID: {employee.DepartmentId}");
                Console.WriteLine("----------------------------------------------------------------------------------");
            }

            employees = context.Employees.Where(emp => emp.City.Equals("Dehradun")).Select(x => x).ToList();
            Console.WriteLine("\nEmployees in Dehradun");
            Console.WriteLine("----------------------------------------------------------------------------------");
            foreach (Employee employee in employees)
            {

                Console.WriteLine($"ID: {employee.EmpId}, Name: {employee.Name}, Salary: {employee.Salary}, Department: {employee.Department}, City: {employee.City}, DepartmentID: {employee.DepartmentId}");
                Console.WriteLine("----------------------------------------------------------------------------------");
            }

            int? salary = context.Employees.Max(emp => emp.Salary);
            Console.WriteLine($"\nMaximum Salary: {salary}");

            salary = context.Employees.Min(emp => emp.Salary);
            Console.WriteLine($"\nMinimum Salary: {salary}");
        }
    }
}