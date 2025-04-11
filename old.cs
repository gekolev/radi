// bool happyDog = true; // boolean
// bool unhappyDog = false; // boolean


// if (unhappyDog == false)
// {
//     Console.WriteLine("The dog is happy");
// }
// else
// {
//     Console.WriteLine("The dog is unhappy");
// }


// if (happyDog == true)
// {
//     Console.WriteLine("Happy happy dog");
// }


// string A = "Cheese";
// string B = "Cheese";
// string C = "Bread";


// if (A == C)
//as {
//     Console.WriteLine("Success!");
//     if (C == B)
//     {
//         Console.WriteLine("Success, Again!");
//     }
//     else if (A == B)
//     {
//         Console.WriteLine("Success3!");
//     }
//     else if (C == A)
//     {
//         Console.WriteLine("Success4!");
//     }
// }
// else
// {
//     Console.WriteLine("ERROR!");
// }
// using Microsoft.VisualBasic;
// Console.Write("gender: ");
// string answer1 = Console.ReadLine().Trim().ToLower();


// if (answer1 == "f")
// {
//   Console.WriteLine("Female");
// }
// else if (answer1 == "m")
// {
//     Console.WriteLine("Male");
// }
// else
// {
//     Console.WriteLine("Error!");
//     return;
// }
// Console.Write("age: ");
// int answer2 =  int.Parse(Console.ReadLine());


// if (answer1 == "f")
// {
//     if (answer2 > 16)
//     {
//     Console.WriteLine("Miss");
//     }
//     else
//     {
//     Console.WriteLine("Ms.");
//     }
// }
// else
// {
//     if (answer2 > 16)
//     {
//     Console.WriteLine("Master");
//     }
//     else
//     {
//     Console.WriteLine("Mr.");
//     }
// }


// var age = double.Parse(Console.ReadLine());
// var gender = Console.ReadLine();


// if (age < 16)
// {
//     if (gender == "m") Console.WriteLine("Mister");
//     else if (gender == "f") Console.WriteLine("Miss");
// }
// else
// {
//     if (gender == "m") Console.WriteLine("Mr.");
//     else if (gender == "f") Console.WriteLine("Ms.");
// }
// using System.Runtime.InteropServices;


// int A = 3;
// int B = 3;
// int C = 6;
// // "!" = NOT (reverse psychology)
// if (!(A == B && B > C))
// {
//   Console.WriteLine("Ok");  
// }
// else
// {
//     Console.WriteLine("Error!");
// }
// for (int i = 4; i <= 40; i++)
// {
//   Console.WriteLine($"Something: {i*2}");
// }
// Console.Write("Age:  ");
// int answer1 = int.Parse(Console.ReadLine());
// Console.Write("Gender: ");
// string answer2 = Console.ReadLine().Trim().ToLower();


// if (answer1 > 16)
// {
//     if (answer2 == "f")
//     {
//         Console.WriteLine("Miss");
//     }
//     else
//     {
//         Console.WriteLine("Master");
//     }
// }
// else
// {
//     if (answer2 == "m")
//     {
//         Console.WriteLine("Ms.");
//     }
//     else
//     {
//         Console.WriteLine("Mr.");
//     }
// }
// int = integer
// string = string of symbols
// boolean = true or false
// double = range of numbers
// char = system char (symbol)
// >, <, =, -, +, !=, ==, %. /
// if, else, else if, for, while, switch
// Excersise 1:
// int price = 0;
// Console.WriteLine("Day: ");
//     string day = Console.ReadLine().ToLower();
// Console.WriteLine("Age: ");  
//     int age = int.Parse(Console.ReadLine());
//     if (age < 0 || age > 120)
//     {
//         Console.WriteLine("Invalid Age!");
//     }
//     if (day == "saturday" || day == "sunday")
//     {
//         if (age <= 12) {price = 6;}
//         else if (age <= 64) {price = 12;}
//         else {price = 7;}
//     }
//     else if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
//     {
//          if (age <= 12) {price = 5;}
//         else if (age <= 64) {price = 10;}
//         else {price = 8;}
//     }
//     else Console.WriteLine ("Invalid Day!");


//     Console.WriteLine ($"the price for your ticket is {price}");


// Excerscise 6:
// Console.WriteLine("Day: ");
// int day = int.Parse(Console.ReadLine());
// if (day > 7)
// {
//   Console.WriteLine("Invalid Day!");
// }
// switch (day)
// {
//   case 1:
//     Console.WriteLine("Monday");
//     break;
//   case 2:
//     Console.WriteLine("Tuesday");
//     break;
//   case 3:
//     Console.WriteLine("Wednesday");
//     break;
//   case 4:
//     Console.WriteLine("Thursday");
//     break;
//   case 5:
//     Console.WriteLine("Friday");
//     break;
//   case 6:
//     Console.WriteLine("Saturday");
//     break;
//   case 7:
//     Console.WriteLine("Sunday");
//     break;
// }


// Excerscise 3:
// Console.WriteLine("Age: ");
// int age = int.Parse(Console.ReadLine());
// Console.WriteLine("Do you have a licence?: true/false");
// bool hasLicence = bool.Parse(Console.ReadLine());


// if (age >= 18 || hasLicence )
// {
//       Console.WriteLine("You can drive");
// }
// else Console.WriteLine("You cannot drive");


// class Program
// {
//     private static void HappyBirthday(string Name)
//     {
//         for (int i = 1; i <= 3; i++)
//         {
//             Console.WriteLine($"Happy Birthday {Name}");
//         }
//     }
//     static void Main()
//     {
//         HappyBirthday("Terry");
//         HappyBirthday("Riley");
//         HappyBirthday("Rocky");
//     }
// }


using System;


public class Program
{


    static void Main()
    {
        Console.WriteLine("Welcome to Guess the Number!");
        // Displays a welcome message to the player


        PlayGame();
        // Calls the function that contains the main game logic
    }


    static void PlayGame()
    {
        Random random = new Random();
        // Creates a new Random object to generate random numbers


        int numberToGuess = random.Next(1, 101); // Random number between 1 and 100
        // Picks a random number between 1 and 100 (inclusive of 1, exclusive of 101)


        int guess = 0;
        // Stores the player's guess, initially set to 0


        int attempts = 1;
        // Counts how many attempts the player has made


        while (guess != numberToGuess)
        // Repeats the loop until the player guesses the correct number
        {
            Console.Write("Take a guess (1-100): ");
            // Asks the player to input their guess


            string input = Console.ReadLine();
            // Reads the player's input as a string


            // Try to convert input to an integer
            if (int.TryParse(input, out guess))
            // Checks if the input can be safely converted to an integer
            {
                attempts++;
                // Increases the attempt counter by 1
                if (attempts <= 5) // how many attempts the player has.
                {
                    if (guess < numberToGuess)
                    // If the guess is too low
                    {
                        Console.WriteLine("Too low! Try again.");
                        // Tells the player their guess is too low
                    }
                    else if (guess > numberToGuess)
                    // If the guess is too high
                    {
                        Console.WriteLine("Too high! Try again.");
                        // Tells the player their guess is too high
                    }
                    else
                    // If the guess is exactly equal to the number
                    {
                        Console.WriteLine($"Congratulations! You guessed it in {attempts} tries.");
                        // Congratulates the player and shows how many attempts it took
                    }
                }
                else
                {
                    Console.WriteLine("You lost the game!");
                    break; // get out of loop
                }
            }
            else
            {
                Console.WriteLine("That's not a valid number. Please enter a number between 1 and 100.");
                // If the input was not a valid number, display an error message
            }
        }
    }
    // int A = 5;
    // string B = "wolf";
    // bool C = true;
    // double D = 3.14127386123127361287361237123;
    // char E = 'E';
    // while (C == true)
    // {
    //     Console.WriteLine("Test");
    // }
    for (int i = 14; i <= 5;i++)
    {
        Console.WriteLine("test");
    }
}

