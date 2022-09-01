internal class Program
{
    private static void Main(string[] args)
    {
        byte firstNum = EnterStringNum("Enter first num: ");
        byte secondNum = EnterStringNum("Enter second num: ");

        sbyte? result = null;
        string? operation = null;
        while (result == null)
        {
            operation = EnterStringOperation("Enter operator: ");
            result = Operations(operation, firstNum, secondNum);
        }

        Console.WriteLine("Result: {0} {1} {2} = {3}", firstNum, operation, secondNum, result);
    }

    private static byte EnterStringNum(string? massege)
    {
        Console.Write(massege);
        byte? answer;
        do
        {
            answer = StringNumToByteNum(Console.ReadLine());
        }
        while (answer == null);
        return (byte)answer;
    }

    private static byte? StringNumToByteNum(string? answer)
    {
        byte? number;
        switch (answer)
        {
            case "zero":
                number = 0;
                break;
            case "one":
                number = 1;
                break;
            case "two":
                number = 2;
                break;
            case "three":
                number = 3;
                break;
            case "four":
                number = 4;
                break;
            case "five":
                number = 5;
                break;
            case "six":
                number = 6;
                break;
            case "seven":
                number = 7;
                break;
            case "eight":
                number = 8;
                break;
            case "nine":
                number = 9;
                break;
            default:
                number = null;
                Console.WriteLine("Сonversion error. Enter from zero to nine");
                break;
        }
        return number;
    }

    private static string? EnterStringOperation(string? massege)
    {
        Console.Write(massege);
        string? answer = Console.ReadLine();
        return answer;
    }

    private static sbyte? Operations(string? operation, byte firstNum, byte secondNum)
    {
        sbyte? answer;
        switch (operation)
        {
            case "+":
                answer = (sbyte)(firstNum + secondNum);
                break;
            case "-":
                answer = (sbyte)(firstNum - secondNum);
                break;
            case "*":
                answer = (sbyte)(firstNum * secondNum);
                break;
            case "/":
                if (secondNum == 0)
                {
                    Console.WriteLine("Dividing by zero is not allowed. Enter +, -, *.");
                    answer = null;
                    break;
                }
                answer = (sbyte)(firstNum / secondNum);
                break;
            default:
                Console.WriteLine("Operator error. Enter +, -, *, /.");
                answer = null;
                break;
        }
        return answer;
    }
}