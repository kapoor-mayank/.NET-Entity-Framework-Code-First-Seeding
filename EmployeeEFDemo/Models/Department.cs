using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEFDemo.Models
{
    internal class Department
    {
        [Column("DeptId")]
        public int Id { get; set; }
        [Column("DeptName")]
        public string DeptName { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
