using System.Diagnostics;

string password = "";
do
{
    System.Console.WriteLine("Enter password: ");
    password = Console.ReadLine();
}while(password != "pa$$word");

System.Console.WriteLine("Type 1st number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter operation(+,-,/,*,%): ");
string operation = Console.ReadLine();
System.Console.WriteLine("Type 2nd number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
// ternary operator
string message =
    !(firstNumber >= 0)
    ? "1st number is not positive"
    : "1st number is not negative";
// logical operator: &&, ||, !
System.Console.WriteLine(message);

if (firstNumber > secondNumber)
{
    System.Console.WriteLine($"1st number is greater than 2nd number!");
}
else if (firstNumber == secondNumber)
{
    System.Console.WriteLine($"1st number is equal to 2nd number!");
}
else
{
    System.Console.WriteLine($"1st number is less than 2nd number!");
}

string result = operation switch
{
    "+" => $"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}",
    "-" => $"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}",
    "/" => $"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}",
    "*" => $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}",
    "%" => $"{firstNumber} % {secondNumber} = {firstNumber % secondNumber}",
    _   => "Operation Not Found!"
};
System.Console.WriteLine(result);

int counter = 2;
while(counter < firstNumber)
{
    Console.WriteLine(counter);
    counter += 2;
}
for(int iterator = 1; iterator <= 10; iterator++)
{
    for(int innerIterator = 1; innerIterator <= 10; innerIterator++)
    {
        System.Console.WriteLine($"{iterator} x {innerIterator} = {iterator * innerIterator}");
    }
    System.Console.WriteLine();
}