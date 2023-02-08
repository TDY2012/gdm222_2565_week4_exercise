using System;
using System.Collections.Generic;

class Program
{
    public static List<List<string>> Combination(List<string> words, int select)
    {
        List<List<string>> combinations = new List<List<string>>();
        if(words.Count > 0 && select > 0)
        {
            for(int i=0; i<words.Count - select + 1; i++)
            {
                List<string> subWords = words.GetRange(i+1, words.Count-i-1);
                List<List<string>> subCombinations = Combination(subWords, select-1);
                foreach(List<string> subCombination in subCombinations)
                {
                    subCombination.Insert(0, words[i]);
                }
                combinations.AddRange(subCombinations);
            }
        }
        else
        {
            combinations.Add(new List<string>());
        }
        return combinations;
    }

    public static void Main(string[] args)
    {
        List<string> words = new List<string>();
        string word;
        while(true)
        {
            word = Console.ReadLine();
            if(word != "Stop")
            {
                words.Add(word);
            }
            else
            {
                break;
            }
        }
        int select = int.Parse(Console.ReadLine());

        List<List<string>> combinations = Combination(words, select);
        foreach(List<string> combination in combinations)
        {
            foreach(string comWord in combination)
            {
                Console.Write("{0}, ", comWord);
            }
            Console.WriteLine();
        }
    }
}