using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
           // string phrase = "The quick brown fox jumps over the lazy dog.";
            char[] delimiterChars = { '+', '-', '*', '/' };
            //string[] words = phrase.Split(' ');

           
            Console.WriteLine("islemi giriniz");
            string text = Console.ReadLine();
            ArrayList aL = new ArrayList();

            //int result = 0;
            for (int i = 0; i <text.Length; i++)
            {
                aL.Add(text[i]);

            }

            foreach (object eleman in aL)
                Console.WriteLine(eleman);
            Console.WriteLine("---");

            string[] words = text.Split(delimiterChars);

            //foreach (var word in words)
            //{
            //    System.Console.WriteLine($"{word}");
            //}

            int num=0;

            ArrayList aList = new ArrayList();
            int count1 = aL.Count;
            Console.WriteLine("---");

            for (int i = 0; i <count1; i++)
            {
                if (text[i] == '+')
                {
                   
                        num = Convert.ToInt32(words[i - 1]) + Convert.ToInt32(words[i]);
                        words[i - 1] = Convert.ToString(num);
                        words[i] = null;

                    
                            
                }
                else if (text[i] == '-')
                {                 
                        num = Convert.ToInt32(words[i - 1]) - Convert.ToInt32(words[i]);
                        words[i - 1] = Convert.ToString(num);
                        words[i] = null;           
                }
               
                else if (text[i] == '*')
                {
                       num = Convert.ToInt32(words[i - 1]) * Convert.ToInt32(words[i]);
                        words[i - 1] = Convert.ToString(num);
                    words[i] = null; 
                    
                }
                else if (text[i] == '/')
                {
                    num = Convert.ToInt32(words[i - 1]) / Convert.ToInt32(words[i]);
                    words[i - 1] = Convert.ToString(num);
                    words[i] = null;

                }
                //else if (delimiterChars[i] == '/')
                //{
                //    num = Convert.ToInt32(words[i]) / Convert.ToInt32(words[i + 1]);
                //    System.Console.WriteLine(num);
                //}
                //else
                //{
                //    i++;
                //}



            }
            foreach (int eleman in aList)
                Console.WriteLine(eleman);
            Console.ReadLine();



            //string[] words = text.Split(delimiterChars);
            //System.Console.WriteLine($"{words.Length} words in text:");

            //foreach (var word in words)
            //{
            //    System.Console.WriteLine($"<{word}>");
            //}
        }
    }
}
