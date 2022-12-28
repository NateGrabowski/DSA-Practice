// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] testData = { 1, 2, 3, 5, 6, 8, 9 };

Console.WriteLine(SortedSquaredArray(testData));

int[] SortedSquaredArray(int[] array)
{
    int[] squared = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        squared[i] += array[i] * array[i];
        Console.WriteLine(squared[i]);
    }
    Array.Sort(squared);
	return squared;
}