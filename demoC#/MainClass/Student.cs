public class Student
{
    public static void Main(string[] arguments)
    {
        Console.WriteLine("Enter Student Information: ");
        Console.WriteLine("Enter Student Name : ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Student Age : ");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Student Class Name : ");
        string className = Console.ReadLine();
        Console.WriteLine("Enter Student University Name : ");
        string universityName = Console.ReadLine();
        
        Console.WriteLine("Student : " + name);
        Console.WriteLine("Student Age : " + age);
        Console.WriteLine("Student Class : " + className);
        Console.WriteLine("Student University Name : " + universityName);
    }
}