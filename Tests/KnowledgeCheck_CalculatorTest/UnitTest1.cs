public class Program
{
    public static void Main()
    {
        Calculator calculator = new Calculator();

        double num1 = 10;
        double num2 = 5;

        Console.WriteLine("Addition: " + calculator.Add(num1, num2));
        Console.WriteLine("Subtraction: " + calculator.Subtract(num1, num2));
        Console.WriteLine("Multiplication: " + calculator.Multiply(num1, num2));
        Console.WriteLine("Division: " + calculator.Divide(num1, num2));
    }
}