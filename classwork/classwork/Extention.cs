using System;
using System.Collections.Generic;
using System.Text;

namespace classwork
{
    public static class Extention
    {
        public static bool IsOdd(this int num)
        {
            return num % 2 == 1;
        }
        public static bool IsEven(this int num)
        {
            return num % 2 == 0;
        }
        public static bool IsContainsDigit(this string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                    return true;
            }
            return false;
        }
        public static string ToCapitalize(this string text)

        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                text = char.ToUpper(text[0]) + text.Substring(1);
            }
            return text;
        }
        public static int[] GetValueIndexes(this string str, char ch)
        {
            int[] indexes = new int[0];

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    Array.Resize(ref indexes, indexes.Length + 1);
                    indexes[indexes.Length - 1] = i;
                }
            }
            return indexes;
        }
        //public static int[] GetValueIndexes(this string word, char c)
        //{
        //    int[] indexes = new int[0];

        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (word[i] == c)
        //        {
        //            Array.Resize(ref indexes, indexes.Length + 1);
        //            indexes[indexes.Length - 1] = i;

        //        }
        //    }
        //    return indexes;
        //}

        public static int[] GetValueIndexes2(this string word,char ch)
        {
            int[] indexes = new int[0];
            if (!string.IsNullOrWhiteSpace(word))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == ch)
                    {
                        Array.Resize(ref indexes, indexes.Length + 1);
                        indexes[indexes.Length - 1] = i;
                    }
                }
            }
            return indexes;
        }


















    }
}
