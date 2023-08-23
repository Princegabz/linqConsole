using System;
using System.Linq;

namespace linqConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data source jf
            String[] names = { "Bill", "Steve", "James", "Mohan"};

            //LINQ Query
            var myLinqQuery = from name in names where name.Length > 4 select name;

            //Query execution
            foreach (var name in myLinqQuery)
                Console.Write(name + ", ");
            Console.WriteLine();


            Student[] studentArray = {
                new Student() {StudentID = 1, StudentName = "John", age=18 },
                new Student() {StudentID = 2, StudentName = "Steve", age=21 },
                new Student() {StudentID = 3, StudentName = "Bill", age=25 },
                new Student() {StudentID = 4, StudentName = "Ram", age=20 },
                new Student() {StudentID = 5, StudentName = "Ron", age=31 },
                new Student() {StudentID = 6, StudentName = "Chris", age=17 },
                new Student() {StudentID = 7, StudentName = "Rob", age=19 },
            };

            //Use LINQ to find teenager students
            Student[] teenAgerStudents = studentArray.Where(s => s.age > 12 && s.age < 23).ToArray();
            foreach(var teen in teenAgerStudents)
                Console.WriteLine(teen.StudentID + " " + teen.StudentName + " " + teen.age+"\n");
            Console.WriteLine();

            // Use LINQ to find first student whose name is bill
            Student bill = studentArray.Where(s => s.StudentName == "Bill").FirstOrDefault();
            Console.Write(bill.StudentID + " " + bill.StudentName + " " + bill.age);
            Console.WriteLine();

            //Use LINQ to find student whose StudentID is 5
            Student student5 = studentArray.Where(s => s.StudentID == 5).FirstOrDefault();
            Console.WriteLine(student5.StudentID + " " + student5.StudentName + " " + student5.age);
            Console.WriteLine();
            Console.Read();
        }
    }
}
