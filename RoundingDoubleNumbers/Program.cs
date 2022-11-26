using RoundingDoubleNumbers;

while (true)
{
    #region Initial (incl conditional) variables

    string? userEnteredString = string.Empty;

    double enteredDoubleNumber = 0;

    bool isDouble = false;

    bool isDoubleContainsFractionalNumbers = false;

    #endregion

    #region Getting user's data

    while (string.IsNullOrWhiteSpace(userEnteredString) || !isDouble || !isDoubleContainsFractionalNumbers)
    {
        Console.Write("Please, enter any double number with fractional numbers (for example (via comma): 2,4 or 2,51 etc):");

        userEnteredString = Console.ReadLine();

        isDouble = double.TryParse(userEnteredString, out enteredDoubleNumber);

        if (isDouble)
        {
            isDoubleContainsFractionalNumbers = (enteredDoubleNumber % 1) != 0;

            if (!isDoubleContainsFractionalNumbers)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"You've entered: {enteredDoubleNumber} number, without fractional numbers, please try again (!)");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"You've entered: {userEnteredString} , which is not a double number, please try again (!)");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    #endregion

    #region Print results

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Your entered {enteredDoubleNumber} double number is rounded to integer number = {enteredDoubleNumber.Round()}");
    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Good Job! Let's do another rounding!");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();

    #endregion
}
