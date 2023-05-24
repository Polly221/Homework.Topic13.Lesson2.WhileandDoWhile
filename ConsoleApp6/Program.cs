//ДЗ Тема 13. Урок 2
//1.
Random random = new Random();
int n;
do
{
    n = random.Next(1, 11);
    Console.WriteLine(n + " ");
}
while (n != 7);

//2.
int d;
int s = 0;
do
{
    d =int.Parse(Console.ReadLine());
    s += d;
}
while (d != 0);
Console.WriteLine("Сумма вводимых чисел: " +s);