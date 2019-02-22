using System;
using Problems;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
       public string Prefix(string input)
        {
            int length=0; int numWords=0;
            if (input=="")
            {
                return ("0,0:");
            }

            string [] arrInput= input.Split();
            length=input.Length;
            numWords= arrInput.Length ;

            foreach (string word in arrInput)
            {
                if (word==" ")
                {
                    numWords--;
                }
            }
            return length+","+numWords+":"+input;


        }
    }
}
