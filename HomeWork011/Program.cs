/* Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.
3, 5 -> 243 (3 в 5 степени)
2, 4 -> 16 */

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int count = numberB;
int result = 1;

  for(int i=0; i < count; i++) 
  {
   result *= numberA;
  }

Console.Write("Число A в степени B равно: " + "{0} ^ {1} = ", numberA, count);




Console.WriteLine(result);