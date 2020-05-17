 int countPrimes = 0;
for (int i = 2; i < n; i++)
{
    int isPrim = 0;
    for (int j = 1; j < i; j++)
    {
        if (i % j == 0)
            isPrim++;
        if (isPrim == 2)
            break;
    }
    if (isPrim != 2)
        countPrimes++;
    isPrim = 0;
}
return countPrimes;