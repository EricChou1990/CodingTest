using System;
using System.Collections.Generic;
using System.Text;
using CodingTest.Service;

namespace CodingTest
{
    public class Calculator
    {
        private readonly ILetterCountService _letterCountService;    

        public Calculator(ILetterCountService letterCountService)
        {
            this._letterCountService = letterCountService;
        }

        public void ShowResult()
        {
            Console.WriteLine(this._letterCountService.OneToOneThousand());
            Console.ReadLine();
        }
    }
}
