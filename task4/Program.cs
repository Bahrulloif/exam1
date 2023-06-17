int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
int z = 0;
for (int i = 0; i < n; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < n; i++)
{
    int t = 0;
    for (int j = i; j < n; j++)
    {
        if (a[i] == a[j] && i != j)
        {
            t++;
        }
    }
    if (t == 0)
    {
        z++;
    }
}
Console.WriteLine(z);