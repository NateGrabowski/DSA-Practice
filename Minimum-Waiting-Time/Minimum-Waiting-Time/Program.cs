// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


/*
 * 
 * 
 * 
 * 
 */
var test = new BinarySearchTree


int[] ints = { 3, 2, 1, 2, 6 };
// 6, 3, 2, 2, 1

Console.WriteLine(MinimumWaitingTime(ints));

int MinimumWaitingTime(int[] queries)
{

    Array.Sort(queries);
    int currentScore = 0;
    int newScore = 0;

    for (int i = 0; i < queries.Length - 1; i++)
    {
        currentScore += queries[i];
        newScore += currentScore;
    }
    return newScore;
}