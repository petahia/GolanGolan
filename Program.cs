// חיים ברלה וזלוש בהצלחה!!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolanGolan
{
    internal class Program
    {

        static void Main(string[] args)

        {

        }



        static string Decrypt(string input)
        {


            StringBuilder result = new StringBuilder();
            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    int asciiVal = (int)c;
                    int decVal = 155 - asciiVal;
                    char decChar = (char)decVal;
                    result.Append(decChar.ToString());
                }
                else
                {
                    result.Append(c);
                }

            }
            return result.ToString();
        }
    }
}