using System;

namespace _3.Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            lettercount ("alma",'m');  
        }
        #region Task-1
        //static int GetIndex(string word, char ch)
        //{
        //    int count = 0; 
        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        if (word[i] == ch)
        //        {
        //            count++;
        //            return count;
        //        }
        //    }
        //    return -1;
        //}
        static int lettercount(string word, char letter)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {

                if (word[i] == letter)
                {
                    count++;
                }
            }
            return count;
        }
        #endregion

    }
}
