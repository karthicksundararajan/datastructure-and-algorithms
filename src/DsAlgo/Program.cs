// See https://aka.ms/new-console-template for more information

using DsAlgo.Sorting;

Console.WriteLine("Selection Sort");
var array = new int[] { 58, 36, 72, 22, 19, 12 };
Console.WriteLine("Before Sort");
PrintOutput(array);
array.SelectionSort();
Console.WriteLine("After Sort");
PrintOutput(array);
Console.ReadLine();

static void PrintOutput(int[] array)
{
    var op = $"{{ {string.Join(",", array)} }}";
    Console.WriteLine(op);
}