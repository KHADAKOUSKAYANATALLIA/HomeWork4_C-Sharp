/* Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = 0;

if (number < 0)
{
    number = number * -1;
}

while(number > 0)
{
    int digit = number % 10; 
    result = result + digit;
    number = number / 10; 
}

Console.WriteLine("Сумма цифр в числе равна: " + result);
