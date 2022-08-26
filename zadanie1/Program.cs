// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}
int value1 = Prompt ("введите первое число");
int value2 = Prompt ("введите второе число");
int i = 1;
int b = 1;

while (i!=value2)
{
    b = b*value1;
    i++;
}
System.Console.WriteLine(b);
