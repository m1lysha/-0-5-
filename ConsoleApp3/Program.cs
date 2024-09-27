try
{
    Console.Write("Введите число для x:");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введите число для b:");
    double b = double.Parse(Console.ReadLine());
    Console.Write("Введите число для a:");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Введите число для y:");
    double y = double.Parse(Console.ReadLine());

    double T = Math.Sqrt(x + b - a) + Math.Log(2 * y + 3 * x) / Math.Tan(b + a);
    Console.WriteLine($"T={T:F2}");

}
catch
{
    Console.WriteLine("Error");
}