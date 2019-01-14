using System;

namespace DecReprSenior
{
    public class Rearrange
    {
        private int N { get; set; }

        private char[] Numbers
        {
            get
            {
                return N.ToString().ToCharArray();
            }
        }

        public Rearrange(int n)
        {
            N = n;
        }

        public int Solution()
        {
            if (N < 0)
                throw new Exception("The input should be a non-negative number");

            char[] numbers = N.ToString().ToCharArray();

            char[] ordenedNumbers = Sort(numbers);
            char[] reverseNumbers = Reverse(numbers);

            int maxRearrange = int.Parse(new string(reverseNumbers));

            if(maxRearrange > 100000000)
            {
                return -1;
            }

            return maxRearrange;
        }

        private char[] Sort(char[] numbers)
        {
            for (int i = 0; i <= Numbers.Length - 1; i++)
            {
                for (int j = 1; j <= Numbers.Length - 1; j++)
                {
                    if (numbers[j] < numbers[j - 1])
                    {
                        char t = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = t;
                    }
                }
            }

            return numbers;
        }

        private char[] Reverse(char[] numbers)
        {
            char[] reverseNumbers = new char[numbers.Length];

            int s = Numbers.Length - 1;
            for (int i = 0; i <= s; i++)
            {
                reverseNumbers[s - i] = numbers[i];
            }

            return reverseNumbers;
        }
    }
}
