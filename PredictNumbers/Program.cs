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

            List<int> numberSequence = new List<int>();
            List<int> numberSequenceNext = new List<int>();

            numberSequence.Add(1);

            foreach (var number in numberSequence)
            {
                Console.WriteLine(number);
            }

            while (i <= 11)
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

                int prevNumber = 0;
                int count = 0;

                foreach (var number in numberSequence)
                {
                    if (prevNumber == 0)
                        prevNumber = number;

                    if (number != prevNumber)
                    {
                        numberSequenceNext.Add(count);
                        numberSequenceNext.Add(prevNumber);

                        count = 1;
                    }
                    else count++;

                    prevNumber = number;
                }    

                numberSequenceNext.Add(count);
                numberSequenceNext.Add(prevNumber);

                var numbers = new StringBuilder();

                foreach (var number in numberSequenceNext)
                {
                    numbers.Append(number.ToString());
                    numbers.Append(",");
                }

                numbers = numbers.Remove(numbers.Length - 1, 1);

                Console.WriteLine(numbers);

                i++;
            }    
        }
    }
}
