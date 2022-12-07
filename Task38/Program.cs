void InputDoubleArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-10, 11);
}


void DiffMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        max = array[i];
        if (array[i] < min)
        min = array[i];
    }
    Console.WriteLine($"Max = {max}; Min = {min}");
    Console.WriteLine($"Difference between max and min: {max - min}");
}


Console.Clear();
Console.Write("Enter number of array elements: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputDoubleArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
DiffMaxMin(array);