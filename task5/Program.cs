int n = Convert.ToInt32(Console.ReadLine());
int[] a = new int[n];
for (int i = 0; i < n; i++)
{
    a[i] = Convert.ToInt32(Console.ReadLine());
}
int min = a[0];
int indmin = 0;
for (int i = 0; i < n; i++)
{
    if (a[i] < min)
    {
        min = a[i];
        indmin = i;
    }
}
Console.WriteLine($"min:{min} indmin: {indmin}");
int max = a[0];
int indmax = 0;
for (int i = 0; i < n; i++)
{
    if (a[i] > max)
    {
        max = a[i];
        indmax = i;
    }
}
Console.WriteLine($"max:{max} indmax: {indmax}");
if (indmin < indmax)
{
    for (int i = indmin; i <= indmax; i++)
    {
        System.Console.WriteLine(a[i]);
    }
}
else
{
    for (int i = indmin; i >= indmax; i--)
    {
        System.Console.WriteLine(a[i]);
    }
}
