/* Напишите программу, которая задает массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void FullArray(int[] array) // заполняем массив
{
    int length = array.Length;
    int index = 0;
    while(index < length)
    {
        array[index] = new Random().Next(0, 9);
        index++;
    }
}

void PrintArray(int[] array) // выводим массив 
{
    int length = array.Length;
    int index = 0;
    while(index < length)
    {
        Console.WriteLine(array[index]);
        index++;
    }

}

Console.WriteLine("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int[N]; // создаем новый массив с количеством N-элементов
FullArray(array);
Console.WriteLine("Ваш массив: ");
PrintArray(array);






