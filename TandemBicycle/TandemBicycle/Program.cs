// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int TandemBicycle(int[] redShirtSpeeds, int[] blueShirtSpeeds, bool fastest)
{
    int acum = 0;
    Array.Sort(redShirtSpeeds);
    Array.Sort(blueShirtSpeeds);
    if (fastest)
    {
        for (int i = 0; i < redShirtSpeeds.Length; i++)
        {
            acum += Math.Max(redShirtSpeeds[i], blueShirtSpeeds[blueShirtSpeeds.Length - 1 - i]);
        }
    }
    else
    {
        for (int i = 0; i < redShirtSpeeds.Length; i++)
        {
            acum += Math.Max(redShirtSpeeds[i], blueShirtSpeeds[i]);
        }
    }
    return acum;
}
