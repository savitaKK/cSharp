// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.WriteLine("Введите число");
string inputNum;
inputNum=Console.ReadLine();

int num= Convert.ToInt32(inputNum);

if (num %2==0)
{
   System.Console.WriteLine($"{num} четное число"); 
}
else 
{
    System.Console.WriteLine($"{num} нечетное число");
}
