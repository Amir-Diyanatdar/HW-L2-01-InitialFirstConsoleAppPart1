string secretWord = "c sharp";
int counter = 1;
Console.Write("Please guess the secret word : ");
string guessedWord = Console.ReadLine();
while (secretWord != guessedWord)
{
    Console.Write("Wrong guess. Please try again: ");
    guessedWord = Console.ReadLine();
    counter++;

}
if (secretWord == guessedWord)
{
    Console.WriteLine("Congratulations! You guessed the secret word.");
    Console.WriteLine($"You attempt {counter} times to guess");
}



