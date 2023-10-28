void summa()
{
    Console.WriteLine("Найдем сумму чисел от 100 до 200, которые делятся на 17");
    int sum = 0;
    for (int i = 100; i < 200; i++)
    {
        if (i % 17 == 0)
        {
            sum = sum + i;
            Console.WriteLine(i);
        }
    }
    Console.WriteLine($"Сумма чисел будет равна {sum}");
}
summa();