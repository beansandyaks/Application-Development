
using ConsoleAppYear3.Basics;
using ConsoleAppYear3.Calculator;
using ConsoleAppYear3.Week_2;
using ConsoleAppYear3.Week_3;

int num1=0;int num2=0;

Console.WriteLine("Console Calculator");

Console.WriteLine("Enter first number: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Choose an option from the following:");
Console.WriteLine("Press 1 for Addition");
Console.WriteLine("Press 2 for Subtraction");
Console.WriteLine("Press 3 for Multiplication");
Console.WriteLine("Press 4 for Division");
Console.WriteLine("Press 5 for Jagged Arrays");
Console.WriteLine("Press 6 for Single Dimentional Arrays");
Console.WriteLine("Press 7 for Implicitly Typed Arrays");
Console.WriteLine("Press 8 for Multi Dimensional Arrays");
Console.WriteLine("Press 9 for If-Else Statement Example");
Console.WriteLine("Press 10 for Switch-Case Statement Example");
Console.WriteLine("Press 11 for While Statement Example");
Console.WriteLine("Press 12 for Do-While Statement Example");
Console.WriteLine("Press 13 for For Statement Example");
Console.WriteLine("Press 14 for For-Each Statement Example");
Console.WriteLine("Press 15 for Prime Number Check Example");
Console.WriteLine("Press 16 for Odd Even Number Check Example");
Console.WriteLine("Press 17 for Swap Numbers check Example");
Console.WriteLine("Press 18 for Search in arrays Example");


Console.WriteLine("What's your choice?")
var choice = Console.ReadLine();

switch(choice)
{
    case "1":
        Calculator.Additions(num1, num2);
        break;
    case "2":
        Calculator.Subtraction(num1, num2);
        break;
    case "3":
        Calculator.Multiplication(num1, num2);
        break;
    case "4":
        Calculator.Division(num1, num2);
        break;
    case "5":
        Arrays.JaggedArray();
        break;
    case "6":
        Arrays.SingleDimensionalArray();
        break;
    case "7":
        Arrays.ImplicitlyTypedArray();
        break;
    case "8":
        Arrays.MultiDimensionalArray();
        break;
    case "9":
        s.IfElse(num1, num2);
        break;
    case "10":
        ControlStatement.SwitchCase();
        break;
    case "11":
        ControlStatement.WhileStatement(num1);
        break;
    case "12":
        ControlStatement.DoWhileStatement(num1);
        break;
    case "13":
        ControlStatement.ForLoop(num1);
        break;
    case "14":
        ControlStatement.ForEachLoop();
        break;
    case "15":
        Example.IsPrime(num1);
        break;
    case "16":
        Example.OddEven(num1);
        break;
    case "17":
        Example.SwapNumbers(num1, num2);
        break;
    case "18":
        Example.SimpleSearchInArrays();
        break;
    default:
        Interpolation.StringInterpolation();
        break;
}

Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();
