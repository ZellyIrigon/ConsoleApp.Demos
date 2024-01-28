// See https://aka.ms/new-console-template for more information
//Simple For Loop Demo
//Print Hello Wolrd 10 times
Console.WriteLine("********** Simple For Loop **********");

for (int count =0; count < 10; count++)
{
    Console.WriteLine($"{count} - Hello Wolrd");
}
Console.WriteLine("Loop completed");

//Ask user how many times they wish to print hello world and print accordingly
Console.Write("How many times should we print 'Hello World!'? ");
int userCount =Convert.ToInt32(Console.ReadLine());

for (int count =0; count < userCount; count++)
{
    Console.WriteLine($"{count} - Hello World!");
}

Console.WriteLine("********** Simple For Loop Completed **********");
Console.WriteLine();

//While Loop
Console.WriteLine("********** Simple While Loop **********");
int counter = 0;
while(counter <10)
{
    Console.WriteLine($"Hello World! {counter}");
    counter+=2;
}
// Ask the user for a number and find the total for each number that is entered. Print final sum when the user enters -1 to exit.
int sum = 0;
int num = 0;
while(num != -1)
{
    Console.WriteLine("Please numbers to be summed up. (-1 to stop or exit) ");
    num =  Convert.ToInt32(Console.ReadLine()); 
    //nested if statement
    if (num != -1)
    {
        sum += num;
    }
}

Console.WriteLine($"Your sum is: {sum}");

Console.WriteLine("********** Simple While Loop Completed **********");
Console.WriteLine();

Console.WriteLine("********** Do While Loop **********");
sum=  0;
num = -1;
do
{
    Console.WriteLine("Please numbers to be summed up. (-1 to stop or exit) ");
    num = Convert.ToInt32(Console.ReadLine());
    //nested if statement
    if (num != -1)
    {
        sum += num;
    }
} while (num != -1);
Console.WriteLine($"Your sum is: {sum}");
Console.WriteLine("********** Do While Loop Completed **********");
Console.WriteLine();