// חיים ברלה וזלוש בהצלחה!!

using System;

namespace GolanGolan
{
    static class AtBash
    {
        static void Main()
        {
            Console.WriteLine("Good lock Golan!");
        }


        static Tuple<int, string> insertToDict(string strDecrypt)
        {
            string[] words = { "bomb", "nukhba", "fighter", "rocket", " secret" };
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (strDecrypt.Contains(words[i]))
                {
                    count++;
                }
            }

            return Tuple.Create(count, strDecrypt);
        }
    }
}