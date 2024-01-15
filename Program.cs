using MoreCSharpFun;

internal class Program
{
    private static void Main(string[] args)
    {
        Class1 ps = new Class1("EN");


        string name = "";

        System.Console.WriteLine("Please Enter Your Name");
        name = System.Console.ReadLine();

        ps.PrintName();
    }
}