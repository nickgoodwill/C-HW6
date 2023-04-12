// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через пробел и нажмите enter");
int[] numbers = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

PrintArray(numbers);
Console.WriteLine(PositivSum(numbers));


void PrintArray(int[] numbers)
{
    System.Console.Write("[");
    for (int i = 0; i < numbers.Length-1; i++)
    {
        System.Console.Write(numbers[i] + "; ");
    }
    System.Console.WriteLine(numbers[numbers.Length -1] + "]");
}

int PositivSum(int[] numbers)
{
	int result = 0;

	for (int i = 0; i < numbers.Length; i++)
	{
		if (numbers[i] > 0)
        {
            result+=1;
        }
	}

	return result;
}


// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


int Read (string arg)
{
System.Console.WriteLine($"Введите число: {arg} ");
return int.Parse(System.Console.ReadLine());
}

int K1 = Read("K1");
int K2 = Read("K2");
int B1 = Read("B1");
int B2 = Read("B2");

int x = 0;
int y = 0;

if (K1 == K2)
{
    Console.WriteLine("Линии параллельны");
}
else
{
    x = (B2 - B1) / (K1 - K2);
    y = K1 * x + B1;
    Console.WriteLine($"Точка пересичения линий: x = {x} ; y = {y}");
}
