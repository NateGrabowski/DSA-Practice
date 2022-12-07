//brute force: O(N ^ 2)time

//bool duplicate

//for int i over string length

//nested for loop int j over string length, checking against each char, except for same index

//if there is a match set duplicate to true, if not set to false and return index of char

using System.Collections.Generic;
string algo = "abcdcaf";

Console.WriteLine(FirstNonRepeatingCharacter(algo));

#region Iteration 1

//int FirstNonRepeatingCharacter(string str)
//{
//    for (int i = 0; i < str.Length; i++)
//    {
//        bool duplicate = false;

//        for (int j = 0; j < str.Length; j++)
//        {
//            if (i == j) { continue; }

//            if (str[i] == str[j])
//            {
//                duplicate = true;
//            }
//        }
//        if (!duplicate) { return i; }
//    }
//    return -1;
//}

#endregion

int FirstNonRepeatingCharacter(string str)
{
    Dictionary<char, int> dict = new Dictionary<char, int>();
    for (int i = 0; i < str.Length; i++)
    {
        if (!dict.ContainsKey(str[i]))
        {
            dict.Add(str[i], 1);
        }
        else if (dict.ContainsKey(str[i]))
        {
            dict[str[i]]++;
        }
    }
    //if value = 1 return answer
    foreach (var item in dict)
    {
        if (item.Value == 1)
        {
            return str.IndexOf(item.Key);
        }
    }
    return -1;
}