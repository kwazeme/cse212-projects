// See https://aka.ms/new-console-template for more information
using System.Reflection;

/* Console.WriteLine("Hello, World!");

const string directoryPath = @"C:\Users";

DisplayDirectoriesInDirectory(directoryPath, 3);

static void DisplayDirectoriesInDirectory(string path, int depth = 0)
{

string[] directories = Directory.GetDirectories(directoryPath);

foreach (var dir in directories)
{
    Console.WriteLine(dir);
    //recusive call
   if (depth > 0)
   {
     DisplayDirectoriesInDirectory(dir, depth - 1);
   }

}
} 

SayHello(10);

static void SayHello(int count)
{
	if (count <= 0)
    {
        return;
    }
    else
    {
        Console.WriteLine("Hello");
        SayHello(count - 1); // This is the recursive call
    }
}*/
Console.WriteLine(Factorial(3));

static int Factorial(int n)
{
    if (n <= 1)
    {
        // 1! = 1 (no recursion)
        return 1;
    }
    else
    {
        // n! = n * (n - 1)!
        return (n * Factorial(n - 1));
    }
}