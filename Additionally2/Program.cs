bool CheckProsto (int a)
{
    int i = 2;
    while (i < a)
    {
        if (a % i == 0)
        return false;
    i++;
    }
    return true;
}


Console.Clear();
Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());
int min = 0;
int max = 0;
for (int j = 2; j < n; j++)
{
    if (CheckProsto(j) == true && CheckProsto(n - j) == true) break;
    min = j + 1;
    max = n - j - 1;
}
Console.WriteLine($"{min} {max}");

