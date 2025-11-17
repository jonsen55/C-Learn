using System.Security.Claims;

class Student
{
    public int age;
    public string grade;
    public static string collegeName = "ICP";

}


class Program
{
    public static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.age = 19;
        s1.grade = "A";

        Student s2 = new Student();
        s2.age = 20;
        s2.grade = "B";

        Student s3 = new Student();
        s3.age = 21;
        s3.grade = "C";

        Student s4 = new Student();
        s4.age = 22;
        s4.grade = "D";

        Console.WriteLine("<--------------- Student 1 --------------->");
        Console.WriteLine($"College Name: {Student.collegeName}");
        Console.WriteLine($"Age: {s1.age}");
        Console.WriteLine($"Grade: {s1.grade}");
        Console.WriteLine("<--------------- Student 2 --------------->");
        Console.WriteLine($"College Name: {Student.collegeName}");
        Console.WriteLine($"Age: {s2.age}");
        Console.WriteLine($"Grade: {s2.grade}");
        Console.WriteLine("<--------------- Student 3 --------------->");
        Console.WriteLine($"College Name: {Student.collegeName}");
        Console.WriteLine($"Age: {s3.age}");
        Console.WriteLine($"Grade: {s3.grade}");
        Console.WriteLine("<--------------- Student 4 --------------->");
        Console.WriteLine($"College Name: {Student.collegeName}");
        Console.WriteLine($"Age: {s4.age}");
        Console.WriteLine($"Grade: {s4.grade}");
    } 
}

class Calculator
{
    public void PrintWelcome()
    {
        Console.WriteLine("Welkhum welkhum");
    }
    public int Multiply(int a, int b)
    {
        return a*b;
    }
    public int add(int a, int b)
    {
        return a+b;
    }
    public int Multiply(int a, int b)
    {
        return a*b;
    }
    public int Multiply(int a, int b)
    {
        return a*b;
    }


}