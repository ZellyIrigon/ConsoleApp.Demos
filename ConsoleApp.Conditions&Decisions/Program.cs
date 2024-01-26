// See https://aka.ms/new-console-template for more information
//Conditions & Decisions

//Prompt for input
using System.Text;
using System;

Console.Write("Please enter student's grade: ");
int grade = Convert.ToInt32(Console.ReadLine());

//Simple If...Else ... statement - Decide to print and pass or fail based on input
Console.WriteLine("************Simple IF Results**********");
if(grade > 50)
{
    Console.WriteLine("Congratulations!!! Student has passed.");
}
else
{
    Console.WriteLine("Student has falied.");
    Console.WriteLine("Please recommend student to affair's office");
}

Console.WriteLine("************Simple IF Results End**********");
Console.WriteLine();

// Complex If...Else...IF... statement - Decide to print letter based on grade value
Console.WriteLine("************Complex IF Else IF Results**********");
if (grade < 0 || grade > 100)
{
    Console.WriteLine("Invalid Value");
}
else if (grade < 50)
{
    Console.WriteLine("Student has failed - F");
}
else if (grade >= 50 && grade <= 64 )
{
    Console.WriteLine("C-");
}
else if(grade >=65 && grade <= 74)
{
    Console.WriteLine("C+");
}
else if (grade >= 75 && grade <= 84)
{
    Console.WriteLine("B");
}
else if (grade >= 85 && grade <= 100)
{
    Console.WriteLine("A - Good Job!");
}

int gradeAfterBonus = grade >= 0 && grade <=100 ? grade + 10 : 0;
Console.WriteLine($"Grade after bonus: {gradeAfterBonus}");

Console.WriteLine("************Complex IF Else IF Results End**********");
Console.WriteLine();

// Ternary operator - Used to assign a value to a variable based on a condition.
Console.WriteLine("***********Ternary Operator Result**********");

string passStatus = grade < 50 ?"Fail": "Pass";
Console.WriteLine($"Student Status is : {passStatus}");

Console.WriteLine("**********Ternary Operator Result End**********");
Console.WriteLine();

Console.WriteLine("**********Switch Statement Results**********");

/*Switch statements - used to evaluate a value and take an action
 * Write a program to accept an integer as the day of the week and print the appropriate message as outlined below.
 * 1 - Sunday
 * 2 - Monday
 * 3 - Tuesday 
 * 4 - Wednesday (Hump Day!)
 * 5 - Thursday
 * 6 - Friday(TGIG!!!)
 * 7 - Saturday (Beach Day!!!)
 * */
Console.Write("Please enter the day of the week:");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());
switch (dayOfTheWeek)
{
    case 1:
        Console.WriteLine("--Sunday");
        break;
    case 2: Console.WriteLine("--Monday");
        break;
    case 3: Console.WriteLine("--Tuesday");
        break;
    case 4: Console.WriteLine("--Wednesday");
        Console.WriteLine("(Hump Day!)");
        break;
    case 5: Console.WriteLine("--Thursday");
        break;
    case 6: Console.WriteLine("--Friday");
        Console.WriteLine("(TGIG!!!)");
        break;
    case 7: Console.WriteLine("--Saturday");
            Console.WriteLine("(Beach Day!!!)");
        break;
    default:
        Console.WriteLine("Invalid day number entered!!");
        break;
}
Console.WriteLine("**********Switch Statement Results End**********");


//The rest of the application
Console.WriteLine();
Console.WriteLine("Thank you fo using this program.");
