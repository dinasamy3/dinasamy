using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Dal.Entity
{
    public class project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("EmployeeProject")]
        public int? EmployeeProjectId { get; set; }
        public EmployeeProject? EmployeeProject { get; set; }
    }
}
