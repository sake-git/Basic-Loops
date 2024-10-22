Console.WriteLine("*********************************************************");
Console.WriteLine("Display 'Hello World' until user wants to continue.");
Console.WriteLine("*********************************************************\n");

do 
{
    Console.WriteLine("Hello World!");
    Console.WriteLine("Would you like to continue (y/n)?");
} while (Console.ReadLine().ToLower() == "y");

Console.WriteLine("\n*****************************************************************************************************");
Console.WriteLine("Input a number from user and display the number in ascending and descending order until 0.");
Console.WriteLine("*****************************************************************************************************\n");

do { 
    Console.WriteLine("Enter a number:");
    int inputNumber = Convert.ToInt32(Console.ReadLine());
    for( int counter = inputNumber; counter >= 0; counter--) // descending order
    {
        Console.Write(counter + " ");
    }
    Console.WriteLine("");
    for (int counter = 0; counter <= inputNumber; counter++) // ascending order
    {
        Console.Write(counter + " ");
    }
    
    Console.WriteLine("\nWould you like to continue (y/n)?"); // Check if user wants to continue
} while (Console.ReadLine().ToLower() == "y");
Console.WriteLine("Goodbye!");

Console.WriteLine("\n*********************************************************");
Console.WriteLine("Guess the Passcode for Paradise.");
Console.WriteLine("*********************************************************\n");
const int passcode = 13579;  // Const passcode
bool isdoorLocked = true;
int count = 0;

while(isdoorLocked) // Continue untill door is unlocked
{
    count++;
    Console.WriteLine("Enter a key code");
    int userPwd = Convert.ToInt32(Console.ReadLine());
    if(userPwd == passcode)
    {
        isdoorLocked = false;    // Correct passcode, unlock the door
        
    } else if(count >= 5) // All attempts exhausted, break from loop
    {
        break;
    }
    
}
if (isdoorLocked) // Door is still locked i.e. user exhausted the number of attempts. Display the error message
{
    Console.WriteLine("Too many incorrect attempts");
}
else // User guessed the correct passcode. Access granted to Paradise.
{
    Console.WriteLine("Welcome to the Paradise!");
}

Console.ReadKey();