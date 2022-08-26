//Задача 3: Напишите программу, которая задаёт массив из 8 элементов, выводит их на экран.
// И ищет второй максимум (элемент меньше максимального, но больше всех остальных)

//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33], 19

int[] array = new int[8];
int i = 0; //счетчик

while (i < array.Length)
{
    array[i] = new Random().Next(0, 100);
    i++;

}


int count = 0; //счетчик
while (count < array.Length)
{
    System.Console.Write($"{array[count]}\t");
    count++;
}


int max = array[0];
int max2 = array[0];
int c = 0; //счетчик
int b = 0; //счетчик
while (b < array.Length)
{
    if (array[b] > max)
    {
        max = array[b];
    }
    b++;
}
System.Console.WriteLine($" максимальное {max}");

while (c < array.Length)
{

    if (array[c] > max)
    {
        max2 = max;
        max = array[c];
    }
    else if (array[c] > max2 && array[c] != max)

    {
        max2 = array[c];
    }
    c++;
}

System.Console.WriteLine($" 2e максимальное {max2}");