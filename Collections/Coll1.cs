using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Collections
{
    internal class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public decimal Salary { get; set; }

    }

        class  Coll1
    {
        static void Main()
        {
            List<Department> deptList = new List<Department>();

            deptList.Add(new Department { DeptId = 1, DeptName = "IT", Salary = 75000 });
            deptList.Add(new Department { DeptId = 2, DeptName = "HR", Salary = 60000 });
            deptList.Add(new Department { DeptId = 3, DeptName = "Marketing", Salary = 65000 });

            foreach (Department d in deptList)
            {
                Console.WriteLine($"DeptId: {d.DeptId}, DeptName: {d.DeptName}, Salary: {d.Salary}");
            }
        }
    }
}
