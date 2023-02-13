// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите первое число");
string inputValue1;
inputValue1=Console.ReadLine();

System.Console.WriteLine("Введите второе число");
string inputValue2;
inputValue2=Console.ReadLine();

System.Console.WriteLine("Введите третье число");
string inputValue2;
inputValue2=Console.ReadLine();

int value1= Convert.ToInt32(inputValue1);
int value2= Convert.ToInt32(inputValue2);
int value3= Convert.ToInt32(inputValue3);

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