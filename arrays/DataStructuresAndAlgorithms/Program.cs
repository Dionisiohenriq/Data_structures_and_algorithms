// See https://aka.ms/new-console-template for more information
using DataStructuresAndAlgorithms.Algorithms;

namespace DataStructuresAndAlgorithms;

public class DataStructuresAndAlgorithms
{
    public static void Main(string[] args)
    {
        // string input = "Hello, World!";
        // string inverted = StringInverter.InvertSring(input);
        // Console.WriteLine("Original: " + input);
        // Console.WriteLine("Inverted: " + inverted);
        // string phrase = "Hello, World!";
        // string invertedPhrase = StringInverter.ReverseWordsManual1(phrase);
        // Console.WriteLine("Original Phrase: " + phrase);
        // Console.WriteLine("Inverted Phrase: " + invertedPhrase);
        // string invertedPhrase2 = StringInverter.ReverseWordsManual2(phrase);
        // Console.WriteLine("Original Phrase: " + phrase);
        // Console.WriteLine("Inverted Phrase: " + invertedPhrase);

        string input = "Hello, World!";
        string inverted = StringInverter.TwoPointerReverse(input);
        Console.WriteLine("Original: " + input);
        Console.WriteLine("Inverted: " + inverted);
    }
}
