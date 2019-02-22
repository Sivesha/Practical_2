using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        string Prefix(string input)
        {
            int length=0; int numWords=0;
            if (input== null)
            {
                return ("0,0:");
            }

            string [] arrInput= input.Split();
            length=arrInput.Length;
            numWords= arrInput.Length;

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
