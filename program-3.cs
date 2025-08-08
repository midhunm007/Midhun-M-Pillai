// language used C#


Console.WriteLine("Enter the number : ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    a--; 
}

int i = 1;
while (i <= a * 2 - 1)
{
    Console.Write(i + " ");
    i += 2;
}
