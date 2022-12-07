using System.Collections.Generic;
using System;


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

string TournamentWinner(List<List<string>> competitions, List<int> results)
{
    var match = new Dictionary<string, int>();

    for (int i = 0; i < results.Count; i++)
    {
        //var winner = results[i] == 1 ? competitions[i][0] : competitions[i][0];

        if (results[i] == 0)
        {
            match.Add(competitions[i][1], 3);
        }
        else if (results[i] == 1)
        {
            match.Add(competitions[i][0], 3);
        }
    }

    return "";
}

/*
 * When you win you get 3
 * When you lose you gain 0
 * Never a tie
 * 
 * 
 * bestTeam = ""; in loop
 * compare score of team with current best team
 * 
 * O(N) time
 * O(K) space
 */