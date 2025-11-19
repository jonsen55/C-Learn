/// <summary>
/// Task 1
/// </summary>
// class Student
// {
//     public string name;
//     public int age;
//     public string address;
//     public static string college = "ICP";
// }


// class Program
// {
//     static void Main(string[] args)
//     {
//         Student s1 = new Student();
//         Student s2 = new Student();
//         s1.name = "Jonsen";
//         s1.age = 19;
//         s1.address = "Nayagaun";
//         s2.name = "Gaire";
//         s2.age = 20;
//         s2.address = "Rambazar";
//         Console.WriteLine("<---------------- STUDENT 1 ---------------->");
//         Console.WriteLine($"Name: {s1.name}, Age: {s1.age}, Address: {s1.address}");
//         Console.WriteLine("<---------------- STUDENT 2 ---------------->");
//         Console.WriteLine($"Name: {s2.name}, Age: {s2.age}, Address: {s2.address}");

//         Console.WriteLine($"College: {Student.college}");
//     }
// }


/// <summary>
/// Task 2
/// </summary>
// class Calculator
// {
//     public void PrintWelcome()
//     {
//         Console.WriteLine("Welcome to the calculator!");
//     }

//     public int Add(int a, int b)
//     {
//         return a + b;
//     }
//     publicint Multiply(int a, int b=1)
//     {
//         return a * b;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Calculator calculator = new Calculator();
//         calculator.PrintWelcome();
//         Console.WriteLine($"Addition: {calculator.Add(2, 3)}");
//         Console.WriteLine($"Multiplication with default value: {calculator.Multiply(2)}");
//         Console.WriteLine($"Multiplication with two numbers: {calculator.Multiply(2, 3)}");
//     }
// }


///<summary>
/// Task 3
/// </summary>

class ParameterDemo
{
    public void Increase(ref int number)
    {
        number += 10;
    }
    public void GetFullName(out string fullname)
    {
        fullname = "Jonsen Gaire";
    }
    public int SumAll(params int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ParameterDemo parameterDemo = new ParameterDemo();
        int number = 10;
        parameterDemo.Increase(ref number);
        Console.WriteLine($"Increased by 10: {number}");
        string fullname;
        parameterDemo.GetFullName(out fullname);
        Console.WriteLine($"Fullname: {fullname}");
        int sum = parameterDemo.SumAll(1, 2, 3, 4, 5);
        Console.WriteLine($"Sum of all numbers: {sum}");
    }
}
