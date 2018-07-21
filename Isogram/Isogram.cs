using System;

namespace Isogram
{
    public static class Isogram_Problem
    {
        public static bool Isogram_String(String check)
        {
            String str = "";
            for (int i = 0; i < check.Length; i++)
            {
                if (Char.IsLetter(check[i]))
                {
                    if (str.Contains("" + check[i]))
                        return false;
                }
                str += check[i];
            }
            return true;
        }
    }
}
