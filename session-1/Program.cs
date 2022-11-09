using System;
using System.Runtime.Intrinsics.X86;

namespace session_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter words: ");
            var string1 = Console.ReadLine();
            int requiedWord = 4;
            

            if (string1.Length <= requiedWord)
            {
                Console.WriteLine(string1);
            }
            else if (string1.Length > requiedWord)
            {
                var num = string1.Length - requiedWord;

                var hash = "";
                
                for (int i = 0; i < num; i++)
                {
                    hash += "#";
                };
                var lfour = string1.Remove(0, num);

                var result = hash + lfour;
                Console.WriteLine(result);
            }

        }
    }
}

