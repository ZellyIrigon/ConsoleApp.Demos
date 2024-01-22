// See https://aka.ms/new-console-template for more information


Console.Write("Plese enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

/*
  Math Operations and Operators
 */

//Add numbers
int sum = num1 + num2;

//multiply
int product = num1 * num2;

//division
int quotient = num1 / num2;

//subtraction
int difference = num1 - num2;

//modulus - division remainder
int mod = num1 % num2;

Console.WriteLine("**********Math Results**********");

Console.WriteLine($"Sum:  {sum}");
Console.WriteLine($"Difference:  {difference}");
Console.WriteLine($"Product:  {product}");
Console.WriteLine($"Quotient:  {quotient}");
Console.WriteLine($"Modulus:  {mod}");
Console.WriteLine("**********End Math Results**********");
Console.WriteLine();

/*
 Logic Operarions and Operators
 */

bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isLessThanOrEqualTo = num1 <= num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("**********Logic Results**********");

Console.WriteLine($"Is Greater Than: {isGreaterThan}");
Console.WriteLine($"Is Less Than: {isLessThan}");
Console.WriteLine($"Is Equal To: {isEqualTo}");
Console.WriteLine($"Is Greater Than or Equal To: {isGreaterThanOrEqualTo}");
Console.WriteLine($"Is Less Than or Equal To: {isLessThanOrEqualTo}");
Console.WriteLine($"Is Not Equal: {isNotEqual}");
Console.WriteLine("**********End Logic Results**********");
Console.WriteLine();

/*
 Assignment Operarions and Operators
 */

Console.Write("Enter Random Value for Assignment Operations: ");
int randomValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("**********Assignment Results**********");

Console.WriteLine($"Num 1: {num1}");
//num1 = num1 + randonValue;
num1 += randomValue;
Console.WriteLine($"Num 1 increased by {randomValue}: {num1}");
//num1 = num1 - randonValue;
num1 -= randomValue;
Console.WriteLine($"Num 1 reduced by {randomValue}: {num1}");
//num1 = num1 / randonValue;
num1 /= randomValue;
Console.WriteLine($"Num 1 divided by {randomValue}: {num1}");
//num1 = num1 % randonValue;
num1 %= randomValue;
Console.WriteLine($"Num 1 mod by {randomValue}: {num1}");
//num1 = num1 * randonValue;
num1 *= randomValue;
Console.WriteLine($"Num 1 multiplied by {randomValue}: {num1}");
Console.WriteLine("**********End Assignment Results**********");