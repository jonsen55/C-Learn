using System.Security.Claims;

// class Student
// {
//     public int age;
//     public string grade;
//     public static string collegeName = "ICP";

// }


class Program
{
    public static void Main(string[] args)
    {
        // Student s1 = new Student();
        // s1.age = 19;
        // s1.grade = "A";

        // Student s2 = new Student();
        // s2.age = 20;
        // s2.grade = "B";

        // Student s3 = new Student();
        // s3.age = 21;
        // s3.grade = "C";

        // Student s4 = new Student();
        // s4.age = 22;
        // s4.grade = "D";

        // Console.WriteLine("<--------------- Student 1 --------------->");
        // Console.WriteLine($"College Name: {Student.collegeName}");
        // Console.WriteLine($"Age: {s1.age}");
        // Console.WriteLine($"Grade: {s1.grade}");
        // Console.WriteLine("<--------------- Student 2 --------------->");
        // Console.WriteLine($"College Name: {Student.collegeName}");
        // Console.WriteLine($"Age: {s2.age}");
        // Console.WriteLine($"Grade: {s2.grade}");
        // Console.WriteLine("<--------------- Student 3 --------------->");
        // Console.WriteLine($"College Name: {Student.collegeName}");
        // Console.WriteLine($"Age: {s3.age}");
        // Console.WriteLine($"Grade: {s3.grade}");
        // Console.WriteLine("<--------------- Student 4 --------------->");
        // Console.WriteLine($"College Name: {Student.collegeName}");
        // Console.WriteLine($"Age: {s4.age}");
        // Console.WriteLine($"Grade: {s4.grade}");


        // Calculator c1 = new Calculator();
        // c1.PrintWelcome();
        // int add = c1.Add(2,3);
        // int sub = c1.Subtract(2,3);
        // int mul = c1.Multiply(2,3);
        // int div = c1.Divide(2,3);

        // Console.WriteLine($"Addition: {add}");
        // Console.WriteLine($"Subtraction: {sub}");
        // Console.WriteLine($"Multiplication: {mul}");
        // Console.WriteLine($"Division: {div}");
        // Console.WriteLine($"Is even: {c1.isEven(2)}");

        int[] numbers = [1,2,33,4,5];
        DemoOut d1 = new DemoOut();
        d1.GetMinMax(numbers, out int min, out int max);
        int sum = d1.Sum(numbers);
        Console.WriteLine($"Sum: {sum}");

        d1.OptionalParams("Kasle vaneko?");

    } 
}

// class Calculator
// {
//     public void PrintWelcome()
//     {
//         Console.WriteLine("Welkhum welkhum");
//     }
//     public int Multiply(int a, int b)
//     {
//         return a*b;
//     }
//     public int Add(int a, int b)
//     {
//         return a+b;
//     }
//     public int Subtract(int a, int b)
//     {
//         return a-b;
//     }
//     public int Divide(int a, int b)
//     {
//         return a/b;
//     }

//     public bool isEven(int a)
//     {
//         return (a%2 == 0?true:false);
//     }

// }

class DemoOut
{
    public void GetMinMax(int[] numbers, out int min, out int max)
    {
        min = numbers[0];
        max = numbers[0];
        foreach (int number in numbers)
        {
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"Min: {min}, Max: {max}");
    }
    public int Sum(params int[] numbers)
    {
        int sum=0;
        foreach(int number in numbers)
        {
            sum += number;
        }
        return sum;
    }

    public void OptionalParams(String text = "Chaahidaina malaai maayaa saayaa")
    {
        Console.WriteLine(text??"Guras Naani");
    }
}


        

