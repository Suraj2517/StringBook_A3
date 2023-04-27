//111111111111111111111111111111111
Console.WriteLine("1. For finding the shortest word in the list.");
Console.Write("Enter the number of words: ");
int n = Convert.ToInt16(Console.ReadLine());

string[] words = new string[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Enter word {i + 1}: ");
    words[i] = Console.ReadLine();
}
string shortest = words[0];
foreach (string word in words)
{
    if (word.Length < shortest.Length)
    {
        shortest = word;
    }
}
Console.WriteLine($"The shortest word is {shortest}");

//222222222222222222222222222222222222222222


Console.WriteLine("2. For checking word is present already or not in the list.");
Console.Write("Enter the number of words: ");
int n1 = Convert.ToInt16(Console.ReadLine());

string[] Words = new string[n1];

for (int i = 0; i < n1; i++)
{
    Console.Write($"Enter word {i + 1}: ");
    Words[i] = Console.ReadLine();
}
Console.Write("Enter a word to search for: ");
string searchWord = Console.ReadLine();
bool found = false;
foreach (string word in Words)
{
    if (word == searchWord)
    {
        found = true;
        break;
    }
}
if (found)
{
    Console.WriteLine($"{searchWord} is present in the list of words");
}
else
{
    Console.WriteLine($"{searchWord} is not present in the list of words");
}

//333333333333333333333333333333


Console.WriteLine("3. For sorting all words in alphabetical order.");
Console.Write("Enter the number of words: ");
int n3 = Convert.ToInt16(Console.ReadLine());

string[] words1 = new string[n3];

for (int i = 0; i < n3; i++)
{
    Console.Write($"Enter word {i + 1}: ");
    words1[i] = Console.ReadLine();
}

Array.Sort(words1);
Console.WriteLine("The sorted list of words is");
foreach(string word in words1)
{
    Console.WriteLine(word);
}

// 44444444444444444444444444444444444444


Console.WriteLine("4. For checking number of palindromes in the list.");
Console.Write("Enter the number of words: ");
int n4 = int.Parse(Console.ReadLine());
string[] words4 = new string[n4];
for (int i = 0; i < n4; i++)
{
    Console.Write("Enter word {0}: ", i + 1);
    words4[i] = Console.ReadLine();
}
int count = 0;
string ch = "";
foreach (string word in words4)
{
    string rev = "";
    int length = word.Length;
    for (int i = length - 1; i >= 0; i--)
    {
        rev += word[i];
    }
    if (rev == word)
    {
        count++;
        ch = ch + word + " ";
    }
}
Console.WriteLine();
Console.WriteLine("The number of palindromes in the list :" + count);
Console.WriteLine(ch);
