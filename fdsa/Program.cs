

// hàm - method - function
class Program
{
    static void Main(string[] args)
    {
        Calculator();
    }

    public static void Calculator()
    {
        Console.WriteLine("Chào mừng đến với máy tính cầm tay");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Chọn tính năng bạn muốn sử dụng:");
        Console.WriteLine("Bấm 1 - Cộng");
        Console.WriteLine("Bấm 2 - Trừ");
        Console.WriteLine("Bấm 3 - Nhân");
        Console.WriteLine("Bấm 4 - Chia");
        var option = Convert.ToInt32(Console.ReadLine());

        int a, b, result;
        
        switch (option)
        {
            case 1:
                a =GetInput("a");
                b =GetInput("b");
                result = Plus(a, b);
                Print(result.ToString());
                break;
            case 2:
                a =GetInput("a");
                b =GetInput("b");
                result = Minus(a, b);
                Print(result.ToString());
                break;
            case 3:
                a =GetInput("a");
                b =GetInput("b");
                result = Multiple(a, b);
                Print(result.ToString());
                break;
            case 4:
                a =GetInput("a");
                b =GetInput("b");
                result = Divide(a, b);
                Print(result.ToString());
                break;
            default:
                Console.WriteLine("Wrong input, please try again!!!");
                break;
        }
    }
    
    public static int GetInput(string text)
    {
        Console.WriteLine($"Hãy nhập vào {text}");
        return Convert.ToInt32(Console.ReadLine());
    }
    
    public static void Print(string text)
    {
        Console.WriteLine($"Kết quả là: {text}");
    }
    
    public static int Plus(int a, int b)
    {
        return a + b;
    }
    
    public static int Minus(int a, int b)
    {
        return a - b;
    }
    public static int Multiple(int a, int b)
    {
        return a * b;
    }
    
    public static int Divide(int a, int b)
    {
        return a / b;
    }
}
