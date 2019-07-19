using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredictNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int prevNumber = 0;
            int count = 0;

            List<int> numberSequence = new List<int>();
            List<int> numberSequenceNext = new List<int>();

            numberSequence.Add(1);

            while (i < 6)
            {
                if (numberSequenceNext.Count > 0)
                {
                    numberSequence.Clear();

                    foreach (var number in numberSequenceNext)
                    {
                        numberSequence.Add(number);
                    }

                    numberSequenceNext.Clear();
                }

                prevNumber = 0;
                count = 0;

                foreach (var number in numberSequence)
                {
                    count++;

                    if (prevNumber == 0)
                        prevNumber = number;

                    if (number != prevNumber)
                    {
                        numberSequenceNext.Add(count);
                        numberSequenceNext.Add(number);

                        count = 0;
                    }

                    prevNumber = number;
                }    

                if (count !=0)
                {
                    numberSequenceNext.Add(count);
                    numberSequenceNext.Add(prevNumber);
                }

                i++;
                
                foreach (var number in numberSequenceNext)
                {
                    Console.Write(number.ToString() + ",");
                }

                Console.WriteLine();
            }    
        }
    }
}
