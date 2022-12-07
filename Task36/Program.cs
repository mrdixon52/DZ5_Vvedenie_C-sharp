void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-20, 21);
}


void SumElementsArr(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    sum = sum + array[i];
    Console.WriteLine($"Sum of array elements on odd position: {sum}");
}


Console.Clear();
Console.Write("Enter number of array elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
SumElementsArr(array);