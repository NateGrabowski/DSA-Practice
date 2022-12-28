//Solved but need to refactor 

var redShirtHeights = new List<int>()
{
    5,8,1,3,4
};

var blueShirtHeights = new List<int>()
{
    6,9,2,4,5
};

Console.WriteLine(ClassPhotos(redShirtHeights, blueShirtHeights));

#region Iteration 1
bool ClassPhotos(List<int> redShirtHeights, List<int> blueShirtHeights)
{
    redShirtHeights.Sort();
    blueShirtHeights.Sort();
    if (redShirtHeights.Max() < blueShirtHeights.Max())
    {
        for (int i = blueShirtHeights.Count - 1; i >= 0; i--)
        {
            if (blueShirtHeights[i] > redShirtHeights[i])
            {
                continue;
            }
            if (blueShirtHeights[i] <= redShirtHeights[i])
            {
                return false;
            }
        }
    }
    else
    {
        for (int i = blueShirtHeights.Count - 1; i >= 0; i--)
        {
            if (blueShirtHeights[i] < redShirtHeights[i])
            {
                continue;
            }
            if (blueShirtHeights[i] >= redShirtHeights[i])
            {
                return false;
            }
        }
    }
    return true;
} 
#endregion