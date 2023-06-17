int n = Convert.ToInt32(Console.ReadLine());
string[] names = new string[n];
for (int i=0; i<n; i++){
    names[i]=Console.ReadLine();
}
foreach (var name in names)
{
    Console.WriteLine(name);
}