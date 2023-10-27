try
{
    Console.WriteLine("Введите кол-во выполнения цикла");
    double n = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите x");
    double x = int.Parse(Console.ReadLine());
    double s = 1;
    for (int i = 1; i <= n; i++)
    {
        long f = 1;
        for (int j = 1; j <= 2 * i + 1; j += 2) f *= j;
        if (i % 2 == 0)
        {
            s += (Math.Pow(x, 2 * i + 1)) / f;
        }
        else
        {
            s -= (Math.Pow(x, 2 * i + 1)) / f;
        }
    }
    Console.WriteLine($"S = {s:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
