void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1001);
}


void EvenNumberArr(int[] array)
{
    int SumEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0 )
        SumEven++;
    }
    Console.WriteLine($"Number of even elements: {SumEven}");
}


Console.Clear();
Console.Write("Enter number of array elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
EvenNumberArr(array);

