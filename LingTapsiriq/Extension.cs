using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LingTapsiriq
{
    static class Extension
    {
        public static int CountOfSeven(this string data)
        {
            int counter = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == '7')
                    counter++;
            }
            return counter;
        }

        public static bool NotContain(this string data, char s)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == s)
                    return false;

            }
            return true;
        }

        public static int SameLetter(this string data, string str1, string str2)
        {
            int counter = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        ++counter;
                        break;
                    }
                }
            }
            return counter;
        }


        public static int LetterSame(this string data,string[] str1,string[] str2)
        {
            int counter = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str2.Length; j++)
                {
                    if (str1[i] == str2[j])
                    {
                        ++counter;
                        break;
                    }
                }
            }
            return counter;
        }

        static public bool NotSameNumber(this string data)
        {
            string copy = data;
            for (int i = 0; i < data.Length; i++)
            {
                if (char.IsNumber(data[i]))
                {
                    int counter = 0;
                    for (int j = 0; j < copy.Length; j++)
                    {
                        if (data[i] == copy[j])
                        {
                            ++counter;
                            if (counter == 2)
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return true;
        }

        public static bool Pay(this int data, int birthday)
        {
            int difference = 0;

            if (birthday >= DateTime.Now.Month)
            {
                difference = (birthday - DateTime.Now.Month) * 500;
            }
            else if (birthday < DateTime.Now.Month)
            {
                difference = (12 - (DateTime.Now.Month - birthday));
            }


            if (difference >= data)
            {
                return true;
            }
            else
                return false;
        }
    }
}
