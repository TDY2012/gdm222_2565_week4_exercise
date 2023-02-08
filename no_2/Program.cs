using System;
using System.Collections.Generic;

class Program
{
    public static List<List<string>> Permutation(List<string> words)
    {
        List<List<string>> permutations = new List<List<string>>();
        if(words.Count > 0)
        {
            foreach(string word in words)
            {
                List<string> subWords = new List<string>(words);
                subWords.Remove(word);
                List<List<string>> subPermutations = Permutation(subWords);
                foreach(List<string> subPermutation in subPermutations)
                {
                    subPermutation.Insert(0, word);
                }
                permutations.AddRange(subPermutations);
            }
        }
        else
        {
            permutations.Add(new List<string>());
        }
        return permutations;
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

        List<List<string>> permutations = Permutation(words);
        foreach(List<string> permutation in permutations)
        {
            foreach(string permWord in permutation)
            {
                Console.Write("{0}, ", permWord);
            }
            Console.WriteLine();
        }
    }
}