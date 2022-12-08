using System;

//Test Data
int[] arr = { 3, 5, -4, 8, 11, 1, -1, 6 };
int targetSum = 10;
Console.WriteLine(TwoNumberSum(arr, targetSum));

#region Brute-Force
//int[] TwoNumberSum(int[] array, int targetSum)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        for (int j = 0; j < array.Length; j++)
//        {
//            if ((array[i] + array[j] == targetSum) && array[i] != array[j])
//            {
//                return new int[] { array[i], array[j] };
//            }
//        }   
//    }
//    return new int[0];
//}
#endregion

int[] TwoNumberSum(int[] array, int targetSum)
{
    var dict = new Dictionary<int, int>();

    for (int i = 0; i < array.Length; i++)
    {
        //dict.Add(array[i], i);
        if (dict.)
    }


    return new int[0];
}