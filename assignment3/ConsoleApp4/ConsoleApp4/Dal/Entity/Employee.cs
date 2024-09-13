using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Dal.Entity
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        [ForeignKey("department")]
        public int? DeptId { get; set; }
        public department? department { get; set; }
        [ForeignKey ("EmployeeProject")]
        public int? EmployeeProjectId { get; set; }
        public EmployeeProject? EmployeeProject { get; set; }
        public List<project> projects { get; set; }

    }
}
