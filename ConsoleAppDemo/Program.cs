// See https://aka.ms/new-console-template for more information
class MyClass{
    enum Grade { Pass = 60, Distinction = 85 };
    public static string GetGrade(int mark)
    {
         if (mark >= (int)Grade.Distinction)
             return  "Distinction grade";
         else if (mark >= (int)Grade.Pass)
             return "PAASS";
         else
             return  "Failed";
    
        
    }
    public static void Main()
    {
    int empid;
    int mark;


    Console.WriteLine("Whats your empid?");
    empid = int.Parse(Console.ReadLine());
    Console.WriteLine("Hello, World!");
    Console.WriteLine($"Thanks for giving your empid {empid}");
    Console.WriteLine("enter your TSQL mark?");
    mark = Convert.ToInt32(Console.ReadLine());

        string grade = GetGrade(mark);
        Console.WriteLine($"The TSQL marks is {mark} and the grade is {grade}");
   
}
}