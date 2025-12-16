using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    internal class Student
    {
        public int SId { get; set; }
        public string Name { get; set; }
        public int Fee { get; set; }
    }
    class Coll3
    {
        static void Main()
        {
            Dictionary<int, Student> studentDict = new Dictionary<int, Student>();
            studentDict.Add(1, new Student { SId = 1, Name = "John", Fee = 5000 });
            studentDict.Add(2, new Student { SId = 2, Name = "Jane", Fee = 6000 });
            studentDict.Add(3, new Student { SId = 3, Name = "Jim", Fee = 7000 });
            foreach (KeyValuePair<int, Student> kvp in studentDict)
            {
                Student s = kvp.Value;
                Console.WriteLine($"SId: {s.SId}, Name: {s.Name}, Fee: {s.Fee}");
            }
        }

    }
}

