using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Dal.Entity
{
    public class department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Emps { get; set; }


    }



}