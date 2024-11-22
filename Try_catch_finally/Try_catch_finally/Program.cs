
try
{
    Console.WriteLine("Деление не на ноль");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int c = a / b;
}
catch 
{
    Console.WriteLine("непраильно");
}
finally
{
    Console.WriteLine($"правельно");
}