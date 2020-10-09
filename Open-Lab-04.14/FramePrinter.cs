using System;
using System.Linq;
namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
            //1.)
            int wordMaxLength = 0;
            foreach (var item in strings)
            {
                if(item.Length > wordMaxLength)
                {
                    wordMaxLength = item.Length;
                }
            }
            //2.)
            int itterationCount = strings.Length + 2;
            for (int y = 0; y < itterationCount; y++)
            {
                if(y ==0 || y == itterationCount-1)
                {
                    string temp = "";
                    for (int x = 0; x < wordMaxLength+4; x++)
                    {
                        temp += '*';
                    }
                    
                    Console.WriteLine(temp);
                }
                else
                {
                    string text = strings[y-1];
                    if (text.Length != wordMaxLength)
                    {
                        text += string.Join("", Enumerable.Repeat(' ', Math.Abs(text.Length - wordMaxLength)));
                    }
                    
                    Console.WriteLine($"* {text} *");
                }
            }
            
        }
    }
}