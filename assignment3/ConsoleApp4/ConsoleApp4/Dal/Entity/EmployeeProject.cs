﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Dal.Entity
{
    public class EmployeeProject
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int EmployeeId { get; set; }
        public List<Employee> Employees { get; set; }
        public List<project> projects { get; set; }
    }
}
