int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int c=Convert.ToInt32(Console.ReadLine());
int d=Convert.ToInt32(Console.ReadLine());
int FindMinimum (int a, int b, int c, int d){
    int min=a;
if (a<b && a<c && a<d){
    min= a;
}
if (b<a && b<c && b<d) {
    min= b;
}
if (c<a && c<b && c<d) {
    min= c;
}
if (d<a && d<c && d<c) {
    min= d;
    }
    return min;
}
System.Console.WriteLine(FindMinimum(a,b,c,d));