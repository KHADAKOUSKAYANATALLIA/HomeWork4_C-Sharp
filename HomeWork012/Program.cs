/* Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = 0;

while(number > 0)
{
    int digit = number % 10; // 452 - остаток 2
    result = result + digit; // 0 + 2 = 2
    number = number / 10; // убираем хвост числа
}

Console.WriteLine("Сумма цифр в числе равна: " + result);

// Console.Write("Сумма цифр в числе {0} равна {1}", number, result);