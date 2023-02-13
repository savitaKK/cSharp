// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

System.Console.WriteLine("Введите первое число");
string inputValue1;
inputValue1=Console.ReadLine();

System.Console.WriteLine("Введите второе число");
string inputValue2;
inputValue2=Console.ReadLine();

int value1= Convert.ToInt32(inputValue1);
int value2= Convert.ToInt32(inputValue2);

if (value1>=value2)
{
   System.Console.WriteLine("Числа равны"); 
}
else if (value1>value2)
{
    System.Console.WriteLine($"Наибольшее число {value1}, а наименьшее число {value2}");
}
else
{
    System.Console.WriteLine($"Наибольшее число {value2}, а наименьшее число {value1}");
}
