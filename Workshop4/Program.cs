class Student
{
    public string name;
    public int age;
    public string address;
    public static string college = "ICP";
}


class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        Student s2 = new Student();
        s1.name = "Jonsen";
        s1.age = 19;
        s1.address = "Nayagaun";
        s2.name = "Gaire";
        s2.age = 20;
        s2.address = "Rambazar";
        Console.WriteLine("<---------------- STUDENT 1 ---------------->");
        Console.WriteLine($"Name: {s1.name}, Age: {s1.age}, Address: {s1.address}");
        Console.WriteLine("<---------------- STUDENT 2 ---------------->");
        Console.WriteLine($"Name: {s2.name}, Age: {s2.age}, Address: {s2.address}");

        Console.WriteLine($"College: {Student.college}");
    }
}

