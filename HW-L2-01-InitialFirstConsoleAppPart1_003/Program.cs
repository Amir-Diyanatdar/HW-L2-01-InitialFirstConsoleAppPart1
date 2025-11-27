Console.Write("Please guess a number between 1 to 10 : ");
int numberToGuess = Convert.ToInt32(Console.ReadLine());
int correctNumber = 7; // Assign a value between 1 and 10

while (numberToGuess >= 1 && numberToGuess <= 10)
{
    for (int i = 1; i < 5; i++)
    {
        if (correctNumber == numberToGuess)
        {
            Console.WriteLine("Congratulations! You guessed the correct number.");
            break;
        }
        else
        {
            Console.Write("Wrong guess. Please try again: ");
            numberToGuess = Convert.ToInt32(Console.ReadLine());

        }
    }
    break;

}
if (numberToGuess <= 1 || numberToGuess >= 10)
{
    Console.WriteLine("The guessed number is not between 1 and 10."); 
}
