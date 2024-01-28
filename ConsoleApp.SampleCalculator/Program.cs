// See https://aka.ms/new-console-template for more information
using System;
using System.Security.AccessControl;

Console.WriteLine("***** - Welcome to the sample calculator - *****!");

//Show calculator options / Show menu
Console.WriteLine("Please select an operation (-1 to exit)");
Console.WriteLine("1 - Addition");
Console.WriteLine("2 - Subtraction");
Console.WriteLine("3 - Multiplication");
Console.WriteLine("4 - Division");
Console.WriteLine("5 - Fibonacci Sequence");
int choice = Convert.ToInt32(Console.ReadLine());

while (choice != -1)
{
    //Prompt for user input
    Console.Write("Please enter the first number: ");
    int firstNum = Convert.ToInt32(Console.ReadLine());

    Console.Write("Please enter the second number: ");
    int secondNum = Convert.ToInt32(Console.ReadLine());

    //Decide which operation is needed based on selected option
    int answer = 0;
    switch (choice)
    {
        case 1:
            answer = firstNum + secondNum;
            break;
        case 2:
            answer = firstNum - secondNum;
            break;
        case 3:
            answer = firstNum * secondNum;
            break;
        case 4:
            answer = firstNum / secondNum;
            break;
        case 5:
            for (int i = firstNum; i <= secondNum; i++)
            {
                answer += i;
            }
            break;
        default:
            Console.WriteLine("Invalid choice entered! Exit");
            break;
    }
    //print output
    Console.WriteLine($"The result is {answer}");
    Console.WriteLine("Press enter to continue.");
    Console.ReadLine();
    Console.Clear();


    Console.WriteLine("Please select an operation (-1 to exit)");
    Console.WriteLine("1 - Addition");
    Console.WriteLine("2 - Subtraction");
    Console.WriteLine("3 - Multiplication");
    Console.WriteLine("4 - Division");
    Console.WriteLine("5 - Fibonacci Sequence");
    choice = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine("******** - Thank you for using the sample calculator! - ********");
