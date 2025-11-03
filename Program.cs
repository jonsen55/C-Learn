using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      // Console.WriteLine("Enter your first name:");
      // string firstName = Console.ReadLine();
      // Console.WriteLine("Enter your last name:");
      // string lastName = Console.ReadLine();
      // if (firstName[0] == 'j')
      // {
      //   Console.WriteLine($"Your name is {firstName} {lastName}.");
      // }
      // else
      // {
      //   Console.WriteLine("Timro j naam vayepani malaai k?");
      // }

      // int x = 5;
      // int y = 64;
      // Console.WriteLine(Math.Sqrt(y));

/*
  Sirle sikaaunuvako
*/
      // int, String, floating point numbers
      // byte = 8 bits [can be defined numbers from 0 to 255]
      byte a = 255;
      Console.WriteLine(a);

      int b = 1000;
      Console.WriteLine("Integer Number:" + b);

      float num1 = 5.75f;
      double num2 = 19.9657659d;
      decimal num3 = 19.990987654323m;
      Console.WriteLine("Floating Point Numbers:"+num1);
      Console.WriteLine("Double Numbers:"+num2);
      Console.WriteLine("Decimal Numbers:" + num3);
      
      //char, bool, String
      //interpolation

      //arrays => collection of similar type of objects (datatype is same)
      int[] numbers = { 5, 2, 6, 4, 7, 9, 1 };
      Console.WriteLine("First array element is " + numbers[0]);
      Array.Sort(numbers);
      Console.WriteLine("First Sorted Array element is " + numbers[0]);
      // interating elements of array
      for (int i = 0; i < numbers.Length; i++)
      {
        Console.WriteLine($"Array element at index {i + 1} is {numbers[i]}");
      }
      
      foreach (int number in numbers)
      {
        Console.WriteLine("Array element is " + number);
      }

      //constants => defined in PascalCase Convention
      const float Pi = 3.14f;
      Console.WriteLine("The value of Pi is " + Pi);

      // I study in {Informatcs College} in {third year}. My subject starts with letter '{A}'
      string collegeName = "Informatics College";
      int year = 3;
      char subjectInitial = 'A';
      Console.WriteLine($"I study in {collegeName} in {year}rd year. My subject starts with letter '{subjectInitial}'");

      //datetime
      DateTime now = DateTime.Now;
      Console.WriteLine("Current date and time is: " + now);

      DateTime utcDateTime = DateTime.UtcNow;
      Console.WriteLine("Current UTC date and time is: " + utcDateTime);

      TimeSpan difference = now - utcDateTime;
      Console.WriteLine("Difference between local time and UTC time is: " + difference.TotalHours + " hours");
    }
  }
}