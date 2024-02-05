using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work___2_symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "'(' и ')'";
            int currentLength = 0;
            int maxLength = 0;
            bool isValid = true;
            char leftParentheses = '(';
            char rightParentheses = ')';

            foreach (var symbol in text)
            {
                if (symbol == leftParentheses)
                {
                    currentLength++;
                    if (currentLength > maxLength)
                    {
                        maxLength = currentLength;
                    }
                }
                else if (symbol == rightParentheses)
                {
                    currentLength--;
                }
                if (currentLength < 0)
                {
                    isValid = false;
                    break;
                }    
            }
            
            if (currentLength != 0)
            {
                isValid = false;
            }
            
            if (isValid)
            {
                Console.WriteLine($"Строка корректная: {isValid}, максимальная глубина: {maxLength}");
            }
            else
            {
                Console.WriteLine("Некорректная строка " + text);
            }
            
            Console.ReadLine();
        }
    }
}
