using System.Collections.Generic;
using System;


List<List<string>> Semordnilap(string[] words)
{

    Dictionary<string, (string pair, bool IsSemordnilap)> semordnilapDictionary = new Dictionary<string, (string pair, bool IsSemordnilap)>();
    foreach (var word in words)
    {
        if (!semordnilapDictionary.ContainsKey(word))
        {
            semordnilapDictionary.Add(new string(word.Reverse().ToArray()), (word, false));
        }
        else
        {
            var val = semordnilapDictionary[word];
            val.IsSemordnilap = true;
            semordnilapDictionary[word] = val;
        }
    }
    List<List<string>> semordnilap = new List<List<string>>();
    foreach (var item in semordnilapDictionary)
    {
        if (item.Value.IsSemordnilap)
        {
            semordnilap.Add(new List<string> { item.Value.pair, item.Key });
        }
    }
    return semordnilap;
}



