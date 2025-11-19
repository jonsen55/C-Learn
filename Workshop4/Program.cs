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
// class ParameterDemo
// {
//     public void Increase(ref int number)
//     {
//         number += 10;
//     }
//     public void GetFullName(out string fullname)
//     {
//         fullname = "Jonsen Gaire";
//     }
//     public int SumAll(params int[] numbers)
//     {
//         int sum = 0;
//         foreach (int number in numbers)
//         {
//             sum += number;
//         }
//         return sum;
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         ParameterDemo parameterDemo = new ParameterDemo();
//         int number = 10;
//         parameterDemo.Increase(ref number);
//         Console.WriteLine($"Increased by 10: {number}");
//         string fullname;
//         parameterDemo.GetFullName(out fullname);
//         Console.WriteLine($"Fullname: {fullname}");
//         int sum = parameterDemo.SumAll(1, 2, 3, 4, 5);
//         Console.WriteLine($"Sum of all numbers: {sum}");
//     }
// }


/// <summary>
/// Task 4
/// </summary>
// class Player
// {
//     public string playerName;
//     public int level;
//     public int health;
//     public Player()
//     {
//         Console.WriteLine("Default constructor has been called");
//     }
//     public Player(string name, int level, int health)
//     {
//         this.playerName = name;
//         this.level = level;
//         this.health = health;
//     }
// }

// class Program
// {
//     public static void Main(string[] args)
//     {
//         Player player1 = new Player();
//         Player player2 = new Player("Jonsen", 1, 100);
//         Console.WriteLine("<---------------- Player 1 ---------------->");
//         Console.WriteLine($"Player 1: {player1.playerName}, Level: {player1.level}, Health: {player1.health}");
//         Console.WriteLine("<---------------- Player 2 ---------------->");
//         Console.WriteLine($"Player 2: {player2.playerName}, Level: {player2.level}, Health: {player2.health}");
//     }
// }


/// <summary>
/// Task 5
/// </summary>
// public enum Weekday
// {
//     Sunday, Monday, Tuesday, Wednesday, Thursday
// }
// public enum Weekend
// {
//     Saturday, Sunday
// }
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Input a day:");
//         string input = Console.ReadLine();
//         foreach(Weekend day in Weekend.GetValues(typeof(Weekend)))
//         {
//             if(day.ToString().ToLower() == input.ToLower())
//             {
//                 Console.WriteLine("It is: Weekend");
//                 break;
//             }
//             else
//             {
//                 Console.WriteLine("It is: Weekday");
//                 break;
//             }
//         }
//     }
// }


/// <summary>
/// Task 6
/// </summary>

class Program
{
    public static void Main(string[] args)
    {
        int marksInt, totalInt;
        Console.WriteLine("Input marks:");
        bool isMarksValid = int.TryParse(Console.ReadLine(), out marksInt);
        Console.WriteLine("Input total:");
        bool isTotalValid = int.TryParse(Console.ReadLine(), out totalInt);

        if (!isMarksValid || !isTotalValid || totalInt == 0)
        {
            Console.WriteLine("Invalid input or total cannot be zero.");
            return;
        }
        double marks = marksInt;
        double total = totalInt;

        double percentage = marks / total * 100;
        Console.WriteLine($"Percentage: {percentage}%");
    }
}


