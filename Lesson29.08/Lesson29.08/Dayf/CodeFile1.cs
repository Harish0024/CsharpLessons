
public delegate void MethodHandlerA();
public delegate int MethodHandlerB(int x, int y);
//delegate types
//single cast delegate//multicast delegate
public class MathCalculator
{
    public void DoTask()
    {
        Console.WriteLine("Calculator DoTask");
    }
    public int Add(int x, int y)
    {
        Console.WriteLine(x + ", " + y);
        return x + y;
    }
    public int Multiply(int x, int y)
    {
        Console.WriteLine(x + ", " + y);
        return x * y;
    }
    public double Divide(double x, double y)
    {
        Console.WriteLine(x + ", " + y);
        return x / y;
    }
    public string GetModel()
    {
        return "x500";
    }
}
public class DelegateDemo
{
    public static void TestOne()
    {
        MathCalculator mc = new MathCalculator();
        MethodHandlerA methodHandlerA = new MethodHandlerA(mc.DoTask);
        MethodHandlerB methodHandlerB = mc.Multiply;//new MethodHandlerB(mc.Add);
        MethodHandlerB methodHandlerTwo = new MethodHandlerB(mc.Multiply);
        methodHandlerA();
        int addResult = methodHandlerB(100, 50);
        Console.WriteLine(addResult);
        int multiplyResult = methodHandlerTwo(20, 5);
        Console.WriteLine(multiplyResult);
    }
    public static void TestTwo()
       //methods with typecast are not suited for multicast only void method are suitable for multicast
       //all events are multicast   deligate
       //event is action reaised when data is modified
       //eg sms sent to mobil phone when bank balance is modified and sent event mssage
    {
        MathCalculator mc=new MathCalculator();
        MethodHandlerB methodHandlerB = mc.Add;
        methodHandlerB += mc.Multiply;
        methodHandlerB(100, 50);
    }
}
