using System.Collections.Generic;
using System;
using System.Reflection;


/*
 * O(N) time
 * O(K) space
 */

#region Test Data
var match1 = new List<string>()
{
    "HTML", "C#"
};

var match2 = new List<string>();
match1.Add("C#");
match1.Add("Python");

var match3 = new List<string>()
{
    "Python", "HTML"
};

var competitions = new List<List<string>>()
{
    match1, match2, match3
};

var results = new List<int>()
{
    0,0,1
};
#endregion
Console.WriteLine(TournamentWinner(competitions, results));



#region Solution 1
//string TournamentWinner(List<List<string>> competitions, List<int> results)
//{
//    var scores = new Dictionary<string, int>();

//    for (int i = 0; i < results.Count; i++)
//    {
//        if (results[i] == 0)
//        {
//            if (scores.ContainsKey(competitions[i][1]))
//            {
//                scores[competitions[i][1]] += 3;
//            }
//            else
//            {
//                scores.Add(competitions[i][1], 3);
//            }
//        }

//        else if (results[i] == 1)
//        {
//            if (scores.ContainsKey(competitions[i][0]))
//            {
//                scores[competitions[i][0]] += 3;
//            }
//            else
//            {
//                scores.Add(competitions[i][0], 3);
//            }
//        }
//    }
//    var maxValueKey = scores.OrderByDescending(x => x.Value).First().Key;

//    return maxValueKey;
//}

#endregion


#region Solution 2

string TournamentWinner(List<List<string>> competitions, List<int> results)
{
    Dictionary<string, int> score = new Dictionary<string, int>();
    int topScore = 0;
    string team = "";
    for (int i = 0; i < competitions.Count; i++)
    {
        var winner = results[i] == 1 ? competitions[i][0] : competitions[i][1];
        if (score.ContainsKey(winner))
        {
            score[winner] += 3;
        }
        else
        {
            score.Add(winner, 3);
        }
        if (score[winner] > topScore)
        {
            topScore = score[winner];
            team = winner;
        }

    }
    return team;
}

#endregion
