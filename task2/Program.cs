// Напишите программу, которая будет принимать на 
// вход два числа и выводить, является ли второе число 
// кратным первому. Если число 2 не кратно числу 1, то 
// программа выводит остаток от деления.
// ● 34, 5 -> не кратно, остаток 4 
// ● 16, 4 -> кратно
Console.Clear();
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
int rem =num2%num1;
if(rem == 0)
{
    Console.WriteLine($"{num2} является кратным {num1}");
}
else
{
     Console.WriteLine($"{num2} является кратным {num1}.Остаток деления {num2} на {num1} равен {rem}");
}