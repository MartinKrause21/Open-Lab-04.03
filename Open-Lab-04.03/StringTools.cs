using System;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {

            string res = "";
            int length = original.Length;

            if (length == 0)

                return original;

            else if (length == 1)

                return original;
            else
            {
                for (int i = 1; i < (length - 1); i++)
                {
                    res += original[i];
                }
                return res;


            }



        }

    }
}

