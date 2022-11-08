using System;
using System.Runtime.Intrinsics.X86;

namespace session_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word");
           var string1 =  Console.ReadLine();
            Console.WriteLine(string1);
            if (string1.Length < 5)
            {
                
                } else if(string1.Length >=5) {
                var num = string1.Length - 4;
                
                var hash = " ";
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

