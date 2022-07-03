void Main (string[] args)
{
    System.Console.WriteLine("Введите предложение");
    string idea = Console.ReadLine();
    string[] word = idea.Split(' ', '.', '!', '?');
    for (int i = 0; i < word.Count(); i++)
    {
        if (word[i].Length <= 3)
        {
            Console.Write($"{word[i]} ");
        }
    }
    Console.WriteLine();
}
Main(args);