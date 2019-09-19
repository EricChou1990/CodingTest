using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingTest.Service
{
    class LetterCountService : ILetterCountService
    {
        private int _oneToNine
        {
            get
            {
                List<string> list = new List<string> { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
                return list.Sum(x => x.Count());
            }
        }
        private int _oneToNineteen
        {
            get
            {
                List<string> list = new List<string> { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelev", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                return list.Sum(x => x.Count());
            }
        }
        private int _oneToNinetyNine
        {
            get
            {
                List<string> list = new List<string> { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
                int totalLetters = list.Sum(x => x.Count());
                totalLetters = this._oneToNineteen + 10 * totalLetters + 8 * this._oneToNine;
                return totalLetters;
            }
        }
        private int _hundred
        {
            get
            {
                return "hundred".Length;
            }
        }

        private int _and
        {
            get
            {
                return "and".Length;
            }
        }
        private int _thousand
        {
            get
            {
                return "onethousand".Length;
            }
        }

        public int OneToOneThousand()
        {
            int result = this._oneToNine * 100 + this._hundred * 9 * 100 + this._and * 99 * 9 + this._oneToNinetyNine * 10 + this._thousand;
            return result;
        }
    }
}
