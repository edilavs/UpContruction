using System;

namespace AllHomeWorks
{
    class Program
    {
       
        static void Main(string[] args)
        {
            GetIndex("alm", 'a');
           
        }
        static int GetIndex(string word, char ch)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ch)
                {
                    count++;
                    return count;
                }
            }
            return -1;
        }
    }
}
