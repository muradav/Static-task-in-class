using System;
using System.Collections.Generic;
using System.Text;

namespace Static.Example.Helper
{
    static class Extention
    {
       public static bool IsUpper(this string word)
        {
            bool result = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i]==char.ToUpper(word[i]))
                {
                    result = true;
                }
            }
            return result;
        }

    }
}
