using StringFinder;

Console.WriteLine("Please enter the number of inputs that you want :");
int numberOfInputs = int.Parse(Console.ReadLine());

List<string> userInputs = new List<string>();
List<string> userWords = new List<string>();

for (int i = 0; i < numberOfInputs; i++)
{
    Console.WriteLine("Please enter input {0} :", i);
    string inputText = Console.ReadLine();

    if (inputText != null && inputText.Length <= 2)
    {
        userInputs.Add(inputText);
    }
}

Console.WriteLine("Now enter your words to check :");

for (int i = 0; i < numberOfInputs; i++)
{
    Console.WriteLine("Please enter word {0} :", i);
    string wordText = Console.ReadLine();

    if (wordText != null)
    {
        userWords.Add(wordText);
    }
}

Console.WriteLine(ChallengesClass.CanFind(userInputs.ToArray(), userWords.ToArray()));