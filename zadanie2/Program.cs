// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11
//82 -> 10
//9012 -> 12

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

int value = Prompt("введите число ");
int i = 0;
int b = 0;
void summ(int number)
{
    while (number > 0.1)
    {
        b = number % 10;
        i = i + b;
        number = number / 10;
    }
}
summ(value);
System.Console.WriteLine(i);
