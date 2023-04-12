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
