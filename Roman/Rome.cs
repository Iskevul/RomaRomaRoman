using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman
{
    internal class Rome
    {
        private string NumString { get; set; }
        private char[] NumChar { get; set; }


        public Dictionary<char, int> romeDict = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
            };

        public Rome(string text)
        {
            NumString = text;
            NumChar = text.ToCharArray();
        }

        public int ConvertToArabic()
        {
            var sum = 0;
            for (int i = 0; i < NumChar.Length; i++)
            {
                sum += romeDict[NumChar[i]];
            }
            return sum;
        }
    }
}
