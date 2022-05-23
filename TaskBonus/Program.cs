//Напишите функцию, которая принимает слово и возвращает true, если в этом слове есть две одинаковые, стоящие рядом буквы.
Console.WriteLine("Введите любое слово: ");
string word = Console.ReadLine();

bool FindTheSameLetters(string word1)
{
    int i = 0;
    bool result = false;
    while (i < word1.Length - 1)
    {
        if (word[i] == word[i + 1])
        {
            result = true;
            break;
        }
        i++;
    }
    return result;
}
bool res = FindTheSameLetters(word);
Console.WriteLine(res);

