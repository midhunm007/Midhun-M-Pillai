// Language used C#

int[] input = { 1, 2, 8, 9, 12, 46, 76, 82, 15, 20, 30 };
var res = new Dictionary<int, int>();

for (int i = 1; i <= 9; i++)
{ 
    res[i] = input.Count(n => n % i == 0);
}

foreach (var value in res)
{ 
    Console.WriteLine($"{value.Key}: {value.Value}");
}
