using System;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            char[] chars = original.ToCharArray();
            Array.Reverse(chars);
            string str1 = new string(chars);
            return str1;
        }
    }
}
