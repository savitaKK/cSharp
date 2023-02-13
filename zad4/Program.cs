// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число");
string inputNum;
inputNum=Console.ReadLine();

int num= Convert.ToInt32(inputNum);
int startnum=1;

while (startnum<=num)
{
 if(startnum%2==0)
 System.Console.WriteLine (startnum+ " ");
 
  startnum++;
}

