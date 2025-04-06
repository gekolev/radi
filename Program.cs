// See https://aka.ms/new-console-template for more information

int[] numbers = new int [10];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"Enter integer {i + 1}: ");
    numbers[i] = int.Parse(Console.ReadLine()); 
}

int largest = numbers[0];
foreach (int num in numbers)
{
if (num > largest)
largest = num; 
}
