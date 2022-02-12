int n = 101;
int p = 2;
List<int> S = new List<int>();
for (int i = 2; i <= n; i++)
    S.Add(i);
while ( p * p <= n )
{
    int q = p;
    while ( p * q <= n )
    {
        int x = p * q;
        while ( x <= n )
        {
            S.Remove(x);
            x = p * x;
        }
        q = next(S, q);
        //if (q == -1) break;
    }
    p = next(S, p);
    //if (p == -1) break;
}
foreach (int i in S)
    Console.WriteLine(i);
int next(List<int> S, int val)
{
    int index = S.BinarySearch(val);
    //if (index >= 0)
    //{
        index += 1;
        //if (index < S.Count)
            return S[index];
    //}
    //return -1;
}