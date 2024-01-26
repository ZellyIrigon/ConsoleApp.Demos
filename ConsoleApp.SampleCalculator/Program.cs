// See https://aka.ms/new-console-template for more information
using System.Security.AccessControl;

Console.WriteLine("***** - Welcome to the sample calculator - *****!");

//Prompt for user input
Console.Write("Please enter the first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
 int secondNum = Convert.ToInt32(Console.ReadLine());

//Show calculator options / Show menu
Console.WriteLine("Please select an operation");
Console.WriteLine("1 - Addition");
Console.WriteLine("2 - Subtraction");
Console.WriteLine("3 - Multiplication");
Console.WriteLine("4 - Division");

int choice = Convert.ToInt32(Console.ReadLine());


//Decide which operation is needed based on selected option
switch (choice)
{
    case 1:
        Console.WriteLine("You chose ADDITION, the result is:" + firstNum + secondNum);
        break;
    case 2:
        Console.WriteLine("You chose SUBTRACTION, the result is:"+ (firstNum - secondNum));
        break;
    case 3:
        Console.WriteLine("You chose MULTIPLICATION, the result is:" + (firstNum * secondNum));
        break;
    case 4:
        Console.WriteLine("You chose DIVISION, the result is:" + (firstNum / secondNum));
        break;
    default:
        Console.WriteLine("Invalid choice entered! Exit");
        break;
}
