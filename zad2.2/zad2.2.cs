// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6



int Prompt(string msg)
{
    System.Console.Write($"{msg} >");
    return Convert.ToInt32(Console.ReadLine());
}

bool Validate(int num)
{
    if (num >= 100 )
    {
        return true;
    }
    System.Console.WriteLine("третьей цифры нет");
    return false;
}

int number = Prompt("Введите число");
if (Validate(number))
{
    int trDigit = number % 10;
    System.Console.WriteLine($"третья цифра числа {number} равна {trDigit}");
}
else
{
int trDigit = number =/ 10;
   System.Console.WriteLine($"третья цифра числа {number} равна {trDigit}");
}
хзхзхз
 