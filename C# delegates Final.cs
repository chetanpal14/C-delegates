delegate void MathOperation(int x, int y);

class Program
{
    public static void Add(int a, int b)
    {

        Console.WriteLine($"Addition result {a} + {b} = " + (a +b));

    }
    public static void subtract(int a, int b)
    {

        Console.WriteLine($"Addition result {a} - {b} = " + (a - b));
    }

    static void Main(string[] args)
    {
       
        MathOperation calc = new MathOperation(Add);

        calc += subtract;
       
        calc(40, 30);



    }
}