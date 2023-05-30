string ShowNums(int N)
{
    if(N >= 1) return   $"{N} " + ShowNums(N-1);
    else return string.Empty;
}
Console.Write("введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"N = {N} -> " + ShowNums(N));