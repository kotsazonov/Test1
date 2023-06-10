// напишите программу ,которая на вход принимает число и выдает его квадрат ( число умноженое на само себя).
// `

// например
// 4 -> 16
// -3-> 9
// -7-> 49

Console.Write("введите число: ");
int number = int.Parse(Console.ReadLine()!);
int result = number * number;
Console.WriteLine("квадрат числа = " + result);