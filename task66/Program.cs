int SumNums(int M,int N)
{
    if(M <= N) return M + SumNums(M+1,N);
    else return 0;
}
Console.Clear();
Console.Write("M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());
int M = Math.Min(m,n);
int N = Math.Max(m,n);
Console.Clear();
Console.WriteLine($"M = {m}; N = {n} -> {SumNums(M,N)}");