using System;
namespace Atolye15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("islemi giriniz");
            string text = Console.ReadLine();
            int total = 0;   
            string var1="";
            string var2="";
            string[] chArr;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != '+' && text[i] != '-' && text[i] != '*' && text[i] != '/')
                {
                    var1 += text[i];
                }
                else
                {
                    for (int j = i+1; j < text.Length; j++)
                    {
                        if (text[j] != '+' && text[j] != '-' && text[j] != '*' && text[j] != '/')
                        {
                            var2 += text[j];
                            i++;
                        }
                        if (text[j] == '+' || text[j] == '-' || text[j] == '*' || text[j] == '/')
                        {
                            break;
                        }
                    }
                }
                if (text[i] != '+')
                {
                    if (total != 0)
                        total += Convert.ToInt32(var2);
                    else
                        total = Convert.ToInt32(var1) + Convert.ToInt32(var2);
                }
                if (text[i] == '-')
                {
                    if (total != 0)
                        total -= Convert.ToInt32(var2);
                    else
                        total = Convert.ToInt32(var1) - Convert.ToInt32(var2);
                }
                if (text[i] == '*')
                {
                    if (total != 0)
                        total *= Convert.ToInt32(var2);
                    else
                        total = Convert.ToInt32(var1) * Convert.ToInt32(var2);
                }
                if (text[i] == '/')
                {
                    if (total != 0)
                        total /= Convert.ToInt32(var2);
                    else
                        total = Convert.ToInt32(var1) / Convert.ToInt32(var2);
                }
                var1 = "";
                var2 = "";
            }
            Console.WriteLine("Total = "+total);
        }
    }
}