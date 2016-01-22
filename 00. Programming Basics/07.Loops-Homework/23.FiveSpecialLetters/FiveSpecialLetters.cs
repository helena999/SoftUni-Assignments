using System;
using System.Linq;

class FiveSpecialLetters
{
    static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        string[] letters = new[] { "a", "b", "c", "d", "e" };
        string word;
        int length = letters.Length;
        int count = 0;

        for (int i1 = 0; i1 < length; i1++)
        {
            string first = letters[i1];
            for (int i2 = 0; i2 < length; i2++)
            {
                string second = letters[i2];
                for (int i3 = 0; i3 < length; i3++)
                {
                    string third = letters[i3];
                    for (int i4 = 0; i4 < length; i4++)
                    {
                        string forth = letters[i4];
                        for (int i5 = 0; i5 < length; i5++)
                        {
                            string fifth = letters[i5];
                            word = first + second + third + forth + fifth;
                            int wordWeight = CaclulateWeightOfWord(word);
                            if (wordWeight >= start && wordWeight <= end)
                            {
                                Console.Write(word + " ");
                                count++;
                            }
                        }
                    }
                }
            }
        }

        if (count == 0)
        {
            Console.WriteLine("No");
        }
        Console.WriteLine();
    }

    static int CaclulateWeightOfWord(string word)
    {
        string noRepeatLetterWord = new string(word.Distinct().ToArray());
        int wordWeight = 0;
        int letterWeight = 0;
        int index = 1;

        for (int i = 0; i < noRepeatLetterWord.Length; i++)
        {
            switch (noRepeatLetterWord[i])
            {
                case 'a':
                    letterWeight = 5;
                    wordWeight += index * letterWeight;
                    break;
                case 'b':
                    letterWeight = -12;
                    wordWeight += index * letterWeight;
                    break;
                case 'c':
                    letterWeight = 47;
                    wordWeight += index * letterWeight;
                    break;
                case 'd':
                    letterWeight = 7;
                    wordWeight += index * letterWeight;
                    break;
                case 'e':
                    letterWeight = -32;
                    wordWeight += index * letterWeight;
                    break;
            }
            index++;

        }

        return wordWeight;
    }

}


