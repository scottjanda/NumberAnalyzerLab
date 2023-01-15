string userContinue = "y";

Console.WriteLine("What is your name? ");
string userName = Console.ReadLine();
Console.Clear();

do
{
    Console.Write(userName + ", Please enter an integer between 1 and 100 inclusive: ");
    bool validNumber = int.TryParse(Console.ReadLine(), out int userInput);
    Console.WriteLine();

    if (validNumber == false)
    {
        Console.WriteLine(userName + ", that is not a valid number!");
        Console.WriteLine();
        continue;
    }
    else if (userInput > 100 || userInput < 1)
    {
        Console.WriteLine(userName + ", that number is not between 1 and 100 inclusive!");
        Console.WriteLine();
        continue;
    }

    string message = "";

    if (userInput % 2 == 0) //even
    {
        if (userInput > 60) { message = "even and greater than 60."; }
        else if (userInput >= 26) { message = "even and between 26 and 60 inclusive."; }
        else { message = "even and less than 25."; }
    }
    else //odd
    {
        if (userInput > 60) { message = "odd and greater than 60."; }
        else { message = "odd and less than 60."; }
    }

    Console.WriteLine(userName + ", you have entered " + userInput + " which is " + message);
    Console.WriteLine();
    Console.WriteLine("Press y to enter another number or anything else to exit");
    userContinue = Console.ReadLine();
    Console.Clear();

} while (userContinue.ToLower() == "y");

Console.WriteLine("Goodbye " + userName + "!");