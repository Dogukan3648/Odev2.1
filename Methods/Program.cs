
public class Program
{
    [STAThread]
    public  void Main(string[] args)
    {
        Add();
        var result = Add2(20,30);
        int number1 = 20;
        int number2 = 100;
        var result2 = Add3(ref number1, number2);
        Console.WriteLine(result2);
        Console.WriteLine(number1);
        Console.WriteLine(Multiply(2, 4));
        Console.WriteLine(Multiply(2, 4, 5));
    }

     void Add()


    {
        Console.WriteLine("Added: ");
    }

     int Add2(int number1, int number2)
    {
        var result = number1 + number2;
        return result;
    }

     int Add3(ref int number1, int number2)
    {
        number1 = 30;
        return number1 + number2;
    }

     int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

     int Multiply(double number1, int number2, int number3)
    {
        return (int)number1 * number2 * number3;
    }


}



