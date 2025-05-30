﻿// See https://aka.ms/new-console-template for more information

//Excersise 11
// int[] numbers = new int[10];

// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.Write($"Enter integer {i + 1}: ");
//     numbers[i] = int.Parse(Console.ReadLine());
// }

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] % 2 == 0)
//     {
//         Console.WriteLine($"Even Numbers: {i} ");
//     }
// }

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] % 2 != 0)
//     {
//         Console.WriteLine($"Odd Numbers: {i} ");
//     }
// }

//Excersise 12

// int[] numbers = new int[10];

// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.Write($"Enter integer {i + 1}: ");
//     numbers[i] = int.Parse(Console.ReadLine());
// }

// int largest = numbers[0];
// int secondLargest = numbers[0];
// foreach (int num in numbers)
// {
//     if (num > largest)
//     {
//         largest = num;
//     }

//     else if (secondLargest < largest && num != largest)
//     {
//         secondLargest = num;
//     }
// }
// Console.WriteLine("Second Largest Element: " + secondLargest);
// Console.WriteLine("Largest Element: " + largest);

/**
 int[] numbers = new int[10];
        // Create an array to store 10 integers from the user

        Console.WriteLine("Enter 10 integers:");
        // Tell the user what to do

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Number {i + 1}: ");
            // Ask the user to enter the next number (shows 1 to 10)

            numbers[i] = int.Parse(Console.ReadLine());
            // Read what the user typed, convert it to an integer, and store it in the array
        }

        int largest = numbers[0];
        // Start by assuming the first number is the largest

        for (int i = 1; i < 10; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
                // If we find a bigger number, update the largest variable
            }
        }

        int secondLargest = int.MinValue;
        // Start with the smallest possible number for comparison

        for (int i = 0; i < 10; i++)
        {
            if (numbers[i] != largest && numbers[i] > secondLargest)
            {
                secondLargest = numbers[i];
                // If this number is not the largest and it's bigger than what we have so far,
                // set it as the new second largest
            }
        }

        if (secondLargest == int.MinValue)
        {
            Console.WriteLine("There is no second largest number (all numbers might be the same).");
            // If no second largest number was found, that means all numbers are the same
        }
        else
        {
            Console.WriteLine($"The second largest number is: {secondLargest}");
            // Print the second largest number
        }
        **/

// Excersise 13 (Template)

Console.WriteLine("Please write down a number: ");
string input = Console.ReadLine();

if (double.TryParse(input, out double number)) //we give it some rules while transferring the double into a string so that the string input comand can work
{
    Console.WriteLine("Given Number: " + number); //original number 

    double rounded = Math.Round(number);  // rounds up the number 

    Console.WriteLine($"Rounded up number (Closest Highest Rounded): {rounded}"); //rounds up the number to the closest number 

    double ceiling = Math.Ceiling(number);
    Console.WriteLine($"Rounded up number (To a Higher Number): {ceiling}"); //round it up to a higher number

}
else // if you dont type in a number that is considered roundable or something like that 
{
    Console.WriteLine("Invalid number, please write down a valid number");
    //theres No Math.Floor cause this felt easier to write with, although I feel like it could be written better 
}