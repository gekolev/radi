// See https://aka.ms/new-console-template for more information

//Excersise 11
int[] numbers = new int[10];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Enter integer {i + 1}: ");
    numbers[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        Console.WriteLine($"Even Numbers: {i} ");
    }
}

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 != 0)
    {
        Console.WriteLine($"Odd Numbers: {i} ");
    }
}

//Excersise 12

// int[] numbers = new int[10];

// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.Write($"Enter integer {i + 1}: ");
//     numbers[i] = int.Parse(Console.ReadLine());
// }

// int largest = numbers[0];
// foreach (int num in numbers)
// {
// if (num > largest)
// largest = num; 
// }