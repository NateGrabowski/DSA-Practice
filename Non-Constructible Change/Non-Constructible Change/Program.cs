// See https://aka.ms/new-console-template for more information


int[] coins = { 1, 2, 4 };
Console.WriteLine(NonConstructibleChange(coins));

int NonConstructibleChange(int[] coins)
{
    Array.Sort(coins);
    int change = 0;
    for (int i = 0; i < coins.Length; i++)
    {


        if (coins[i] > change + 1)
        {
            break;
        }

        if (coins[i] <= change + 1)
        {
            change += coins[i];
        }


    }
    return change + 1;
}
