using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfRestService2.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Score { get; set; }
        public string State { get; set; }
    }

    public class Department
    {
        public string SchoolName { get; set; }
        public string DepartmentName { get; set; }
        public List<Student> Students { get; set; }
    }
}