int n=Convert.ToInt32(Console.ReadLine());
int[] a=new int[n];
for (int i=0; i<n; i++){
    a[i]=Convert.ToInt32(Console.ReadLine());
}
if (n%2==0){
for (int i=0; i<n; i+=2){
   int b;
    b=a[i];
    a[i]=a[i+1];
    a[i+1]=b;
}
}else{
    for (int i=0; i<n-1; i+=2){
   int b;
    b=a[i];
    a[i]=a[i+1];
    a[i+1]=b;
}
}
foreach (var z in a)
{
    Console.WriteLine(z);
}