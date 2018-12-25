using System;
namespace Atolye15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("islemi giriniz");
            string text = Console.ReadLine();
            text=text.Replace(" ", string.Empty);  
            int total = 0;
            string var1 = "";
            string var2 = "";
            string[] numArr = new string[text.Length];
            string[] chArr = new string[text.Length];
            int chArrCount = 0;
            int numArrCount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '(')
                {
                    chArr[chArrCount] += text[i];
                    chArrCount++;
                    continue;
                }
                if (text[i] != '+' && text[i] != '-' && text[i] != '*' && text[i] != '/')
                {
                    for (int j = i; j < text.Length; j++)
                    {
                        if (text[j] == '+' || text[j] == '-' || text[j] == '*' || text[j] == '/')
                        {
                            numArrCount++;
                            i++;
                            
                            break;
                        }
                        if (text[j] != ')')
                        {
                            numArr[numArrCount] += text[j];
                            
                            continue;
                        }
                        if (chArrCount != 0 )
                        {
                            if ((text[j] == ')' || chArr[chArrCount-1] == "*" || chArr[chArrCount-1] == "/"))
                            {
                                while (chArrCount!=0 && chArr[chArrCount-1] != "(")
                                {
                                    numArrCount++;
                                    numArr[numArrCount] = chArr[chArrCount-1];
                                    chArr[chArrCount-1] = null;
                                    //numArrCount++;
                                    chArrCount--;
                                }
                                if (chArrCount!=0 && chArr[chArrCount - 1] == "(")
                                {
                                    chArr[chArrCount-1] = null;
                                    chArrCount--;
                                }
                            }

                            numArrCount++;
                            i=j;
                            break;
                        }
                    }
                }
                if (text[i] == '+' || text[i] == '-' || text[i] == '*' || text[i] == '/')
                {
                    chArr[chArrCount] += text[i];
                    chArrCount++;
                } 
                
            }

            while (chArrCount!=0)
            {
                numArrCount++;
                numArr[numArrCount] = chArr[chArrCount-1];
                chArr[chArrCount-1] = null;
                //numArrCount++;
                chArrCount--;
            }
            for (int i = 0; i < numArr.Length; i++)
            {
                var1 = numArr[i];
                var2 = numArr[i + 1];
                if (var2 == null)
                {
                    break;
                }
                if (numArr[i+2]!=null)
                {
                    if (numArr[i + 2] == "+")
                    {
                        numArr[i] = numArr[i+1] = numArr[i+2] = null;
                        numArr[i] += Convert.ToInt32(var1) + Convert.ToInt32(var2);
                        for (int j = i+1; j < numArr.Length; j++)
                        {
                            if (j == numArr.Length-2)
                            {
                                break;
                                
                            }
                            numArr[j] = numArr[j + 2];
                            
                        }
                        i =-1;
                    }else if (numArr[i + 2] == "-")
                    {
                        numArr[i] = numArr[i+1]= numArr[i+2] = null;
                        numArr[i] += Convert.ToInt32(var1) - Convert.ToInt32(var2);
                        for (int j = i+1; j < numArr.Length; j++)
                        {
                            if (j == numArr.Length-2)
                            {
                                break;
                                
                            }
                            numArr[j] = numArr[j + 2];
                        }
                        i =-1;
                    }
                    else if (numArr[i + 2] == "*")
                    {
                        numArr[i] = numArr[i+1]= numArr[i+2] = null;
                        numArr[i] += Convert.ToInt32(var1) * Convert.ToInt32(var2);
                        for (int j = i+1; j < numArr.Length; j++)
                        {
                            if (j == numArr.Length-2)
                            {
                                break;
                                
                            }
                            numArr[j] = numArr[j + 2];
                        }
                        i =-1;
                    }else if (numArr[i + 2] == "/")
                    {
                        numArr[i] = numArr[i+1]= numArr[i+2] = null;
                        numArr[i] += Convert.ToInt32(var1) / Convert.ToInt32(var2);
                        for (int j = i+1; j < numArr.Length; j++)
                        {
                            if (j == numArr.Length-2)
                            {
                                break;
                                
                            }
                            numArr[j] = numArr[j + 2];
                        }
                        i =-1;
                    }
                    
                }
            }
            Console.WriteLine("Sonuc = "+ numArr[0]);
        }
    }
}