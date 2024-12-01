namespace LINQ_Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1- List of Numbers 
            List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

            Console.WriteLine("--------Query 1-----------");
            var q1 = numbers.Distinct().OrderBy(x => x);
            foreach (var x in q1)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("--------Query 2-----------");
            foreach (var num in q1)
            {
                Console.WriteLine($"< Number = {num}, Multiply = {num * num} >");
            }

            #endregion

            #region 2- Array of Names
            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };
            
            Console.WriteLine("--------Query 1-----------");
            var q3 = names.Where(n => n.Length == 3);
            foreach (var x in q3)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("--------Query 2-----------");
            var q4 = names.Where(n => n.Contains('a') || n.Contains('A')).OrderBy(n => n.Length);
            foreach (var x in q4)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("--------Query 3-----------");
            var q5 = names.Take(2);
            foreach (var x in q5)
            {
                Console.WriteLine(x);
            }
            #endregion

            #region 3- Class Students
            List<Student> students = new List<Student>(){
                new Student(){ ID=1, FirstName="Ali", LastName="Mohammed", subjects=new Subject[]{ new Subject(){ Code=22,Name="EF"}, new Subject(){ Code=33,Name="UML"}}},              
                new Student(){ ID=2, FirstName="Mona", LastName="Gala", subjects=new Subject []{ new Subject(){ Code=22,Name="EF"}, new Subject (){ Code=34,Name="XML"},new Subject (){ Code=25, Name="JS"}}},             
                new Student(){ ID=3, FirstName="Yara", LastName="Yousf", subjects=new Subject []{ new Subject (){ Code=22,Name="EF"}, new Subject (){ Code=25,Name="JS"}}},               
                new Student(){ ID=1, FirstName="Ali", LastName="Ali", subjects=new Subject []{  new Subject (){ Code=33,Name="UML"}}},

            };
            Console.WriteLine("--------Query 1-----------");
            foreach (Student student in students)
            {
                Console.WriteLine($"< FullName = {student.FullName()} , NoOfSubjects = {student.NoOfSubjects()} >");
            }

            Console.WriteLine("--------Query 2-----------");
            var q6 = students.Select(student => new { student.FirstName , student.LastName}).OrderByDescending(student =>student.FirstName).ThenBy(student => student.LastName).ToList();
            foreach (var student in q6)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            #endregion

        }
    }
}
