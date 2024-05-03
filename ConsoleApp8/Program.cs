

delegate int FactorialDelegate(int n);

delegate T SquareDelegate<T>(T x);

class Program
{
    static int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        return n * Factorial(n - 1);
    }

    static void Main()
    {
        FactorialDelegate factorialDelegate = Factorial;

        int factorialOf3 = factorialDelegate(3);
        Console.WriteLine( factorialOf3); 

        SquareDelegate<int> squareDelegate = x => x * x;

        int squareOf9 = squareDelegate(9);
        Console.WriteLine( squareOf9); 
    }
}
