// See https://aka.ms/new-console-template for more information

string name = "Zelly Irigon";
Console.WriteLine(" I am " + name); //String concatenation
Console.WriteLine($"They call me {name}"); //string interpolation
Console.WriteLine(" I was give the name {0}", name); //Formated string

int age = 40;
int retirementYearsLeft = 25;
int retirementAge = age + retirementYearsLeft;

Console.WriteLine("My age is {0}", age);
Console.WriteLine("My retirement age is {0}", retirementAge);

bool isRetired = false;
Console.WriteLine("Am I retired? {0}", isRetired);