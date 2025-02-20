// See https://aka.ms/new-console-template for more information

using System.Data;

static void task1()
{
    Console.Write("Enter first element: ");
    int a = int.Parse(Console.ReadLine());

    Console.Write("Enter sub element: ");
    int s = int.Parse(Console.ReadLine());

    Console.Write("Enter count elements: ");
    int c = int.Parse(Console.ReadLine());

    float sum = 0;

    float b = 0;

    for(int i = 0; i < c; i++)
    {
        b = a * MathF.Pow(s, i);
        sum += b;
    }
    Console.Write($"Result: {sum}");
}

static void task2()
{
    Console.Write("Enter a: ");
    int.TryParse(Console.ReadLine(), out int a);

    Console.Write("Enter b: ");
    int b = int.Parse(Console.ReadLine());
    
    Console.Write("Enter c: ");
    int c = int.Parse(Console.ReadLine());

    if(a == b && b == c) 
    {
        Console.WriteLine("True.");
    }
    else
    {
        Console.WriteLine("False.");
    }
}

static void task3()
{
    Console.Write("Enter x: ");
    int x = int.Parse(Console.ReadLine());

    Console.Write("Enter y: ");
    int y = int.Parse(Console.ReadLine());

    if(x < 0 && y < 23 && y > -x)
    {
        Console.WriteLine("True.");
    }
    else if((x == 0 && y <= 23 && y >= -x) || (x <= 0 && y == 23 && y >= -x) || (x <= 0 && y <= 23 && y == -x))
    {
        Console.WriteLine("On edge.");
    }
        else
    {
        Console.WriteLine("False.");
    }
}

static void task4()
{
    Console.Write("Enter mounth: ");
    int mounth = int.Parse(Console.ReadLine());

    int result = 12 - mounth;

    if(result == 0)
    {
        Console.WriteLine("Happy New Year!");
    }
    else if(result < 0)
    {
        Console.WriteLine("Error!");
    }
    else
    {
        Console.WriteLine($"New Year will come in {result} month.");
    }
}

static void task5()
{
    Console.Write("Enter a: ");
    int a = int.Parse(Console.ReadLine());

    Console.Write("Enter b: ");
    int b = int.Parse(Console.ReadLine());

    float result = MathF.Pow(a * b, 3);

    Console.WriteLine("Result: " + result);
}

static void task6()
{
    Console.Write("Enter n: ");
    int n = int.Parse(Console.ReadLine());

    Console.Write("Enter m: ");
    int m = int.Parse(Console.ReadLine());

    int result = (n + m) * (((n + 1)/(m + 1) + (5/m)));

    Console.WriteLine("Result: " + result);
}

task6();

