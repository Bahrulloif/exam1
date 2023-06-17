int n=Convert.ToInt32(Console.ReadLine());
int[] a=new int [n];
int two=1;
int sum=1;
for (int i=1; i<=n; i++){
two*=2;
sum+=two;
}
System.Console.WriteLine(sum);