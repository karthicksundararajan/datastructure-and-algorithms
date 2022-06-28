// See https://aka.ms/new-console-template for more information

using DsAlgo.Sorting;

ExecuteSelectionSort();
Console.WriteLine("------------------------------------------------------------------");
ExecuteBubbleSort();
Console.WriteLine("------------------------------------------------------------------");
ExecuteInsertionSort();
Console.ReadLine();

static void PrintOutput(int[] array)
{
    var op = $"{{ {string.Join(",", array)} }}";
    Console.WriteLine(op);
}

static void ExecuteSelectionSort()
{
    Console.WriteLine("Selection Sort");
    var array = new int[] { 58, 36, 72, 22, 19, 12 };
    Console.WriteLine("Before Sort");
    PrintOutput(array);
    array.SelectionSort();
    Console.WriteLine("After Sort");
    PrintOutput(array);
}

static void ExecuteBubbleSort()
{
    Console.WriteLine("Bubble Sort");
    var array = new int[] { 89, 98, 76, 28, 15, 11 };
    Console.WriteLine("Before Sort");
    PrintOutput(array);
    array.BubbleSort();
    Console.WriteLine("After Sort");
    PrintOutput(array);
}

static void ExecuteInsertionSort()
{
    Console.WriteLine("Bubble Sort");
    var array = new int[] { 4, 3, 2, 10, 12, 1, 5, 6 };
    Console.WriteLine("Before Sort");
    PrintOutput(array);
    array.InsertionSort();
    Console.WriteLine("After Sort");
    PrintOutput(array);
}