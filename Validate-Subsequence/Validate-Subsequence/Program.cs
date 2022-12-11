// See https://aka.ms/new-console-template for more information



var arr1 = new List<int>()
{
    5,1,22,25,6,-1,8,10
};

var arr2 = new List<int>()
{
    6,6,-1,10 //3
};


Console.WriteLine(IsValidSubsequence(arr1, arr2));

bool IsValidSubsequence(List<int> array, List<int> sequence)
{

    int index = 0;
    for (int i = 0; i < array.Count; i++)
    {
        if (array[i] == sequence[index])
        {
            index++;
        }
        if (index == sequence.Count())
        {
            return true;
        }
    }
    return false;
}