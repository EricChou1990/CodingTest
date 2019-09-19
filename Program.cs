using System;
using CodingTest.Service;
using Microsoft.Extensions.DependencyInjection;

namespace CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ILetterCountService service = new LetterCountService();
            Calculator cal = new Calculator(service);
            cal.ShowResult();

        }
    }
}
