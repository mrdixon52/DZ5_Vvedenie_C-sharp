void InputArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 32);
}


Console.Clear();
Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
int countOdd = 0; 
int countEven = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 1 )
    {
    Console.Write($"{array[i]} ");
    countOdd++;
    }
}
Console.WriteLine();
for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0 )
    {
    Console.Write($"{array[j]} ");
    countEven++;
    }
}
Console.WriteLine();
if (countEven > countOdd)
Console.WriteLine("YES");
else 
Console.WriteLine("NO");