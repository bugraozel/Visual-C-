using System;
using System.Collections.Generic;

class GenderNeutralTextProcessor
{
    static void Main(string[] args)
    {
        
        Console.Write("Metin paragrafını girin: ");
        string inputText = Console.ReadLine();

        
        Dictionary<string, string> genderReplacements = new Dictionary<string, string>
        {
            { "adam", "kişi" },
            { "eşi", "eş" },
            { "kızı", "çocuğu" }
           
        };

        
        string processedText = ProcessGenderNeutralText(inputText, genderReplacements);

        
        Console.WriteLine("İşlenmiş Metin: ");
        Console.WriteLine(processedText);
    }

    static string ProcessGenderNeutralText(string inputText, Dictionary<string, string> genderReplacements)
    {
        
        string[] words = inputText.Split(' ');

        
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i].ToLower(); 
            if (genderReplacements.ContainsKey(word))
            {
                words[i] = genderReplacements[word];
            }
        }

        
        string processedText = string.Join(" ", words);

       
        processedText = FixSentenceStructure(processedText);

        return processedText;
    }

    static string FixSentenceStructure(string text)
    {
        
        return text;
    }
}