// Language used C#


class Calculator
{
    public double Operations(double a, double b, string operation)
    {
        switch (operation)
        {
            case "+":
                return a + b;
                break;

            case "-":
                return a - b;
                break;

            case "*":
                return a * b;
                break;

            case "/":
                if (b == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return 0;
                }
                else
                { return a / b; }
                break;

            default:
                Console.WriteLine("Invalid operator");
                return 0;
        }
    }


    static void Main(string[] args)
    {
        Calculator c = new Calculator();

        Console.WriteLine("Enter the First number : ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Second Number : ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the Operator( + , - , * , / )");
        string operation = Console.ReadLine();

        double result = c.Operations(a, b, operation);
        Console.WriteLine("Result = "+ result);
    }
}
