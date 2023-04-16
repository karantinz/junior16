int minCount = 100;
int maxCount = 999;
int minRandom = 1;
int maxRandom = 28;

int totalCount = 0;

Random rand = new Random();

int number = rand.Next(minRandom, maxRandom);

Console.WriteLine("N = " + number);

for (int i = minCount; i < maxCount; i += number)
{
    if (i >= minCount)
    {
        totalCount++;
    }
}

Console.WriteLine($"Количество трехзначных натуральных чисел, которые кратны N: {totalCount}");