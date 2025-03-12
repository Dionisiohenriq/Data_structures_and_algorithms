using System.Text;

namespace DataStructuresAndAlgorithms.Algorithms;
public class StringInverter
{
    // Implementation with c# mehtos
    public static string InvertSring(string input)
    {
        string[] array = input.Split(" ");

        StringBuilder texto = new StringBuilder();

        for (int i = 0; i < array.Length; i++)
        {
            texto.Append(InvertWords(array[i]));
            texto.Append(' ');
        }
        return texto.ToString();
    }

    private static string InvertWords(string word)
    {
        char[] newWord = word.ToCharArray();
        Array.Reverse(newWord);
        return new string(newWord);
    }

    // Manual implementation, but changing its positions
    public static string ReverseWordsManual1(string word)
    {
        char[] charWord = word.ToCharArray();

        int left = 0;
        int right = charWord.Length - 1;

        while (left < right)
        {
            char temp = charWord[left];
            charWord[left] = charWord[right];
            charWord[right] = temp;
            left++;
            right--;
        }
        return new string(charWord);
    }

    public static string ReverseWordsManual2(string word)
    {
        char[] chars = word.ToCharArray();
        int size = chars.Length - 1;
        char[] inverted = new char[size];
        int index = 0;

        for (int i = 0; i < size; i++)
        {
            if (char.IsWhiteSpace(chars[i]))
            {
                inverted[i] = chars[i];
            }
            else
            {
                for (int j = i; j < 0; j--)
                {
                    inverted[index] = chars[j];
                    index++;
                }
            }
        }
        return new string(inverted);
    }


    public static string TwoPointerReverse(string s)
    {
        var res = string.Empty;

        var charArray = s.ToCharArray();

        var left = 0;
        var right = 0;
        
        while(right < s.Length -1)
        {
            if(s[right] != ' ')
            {
                right++;
            }
            else
            {
                res += Array.Reverse(s.Substring(left, right + 1));
                right++;
                left = right;  
            }
        }
        res += ' ';
        res += s.Substring(left, right + 2).Reverse().ToString();
        return res.TrimStart();
    }

}