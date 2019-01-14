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

            char[] maxRearrangeNumbers = SortDescending(numbers);

            int maxRearrange = int.Parse(new string(maxRearrangeNumbers));

            if (maxRearrange > 100000000)
            {
                return -1;
            }

            return maxRearrange;
        }

        private char[] SortDescending(char[] numbers)
        {
            for (int i = 0; i < Numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < Numbers.Length; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        char t = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = t;
                    }
                }
            }

            return numbers;
        }
    }
}
