// Собрать строку с числами от a до b, a <= b

string NumbersFor(int a, int b) // сам метод
{
string result = String.Empty;
for (int i = a; i <= b; i++)
{
result += $"{i} ";
}
return result;
}

string NumbersRec(int a, int b) // тот же метод, но рекурсивный
{
if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
else return String.Empty;
}

Console.Clear();
Console.WriteLine(NumbersFor(1, 10)); // 1 2 3 4 5 6 7 8 9 10
Console.WriteLine(NumbersRec(1, 10)); // 1 2 3 4 5 6 7 8 9 10

Console.WriteLine();

