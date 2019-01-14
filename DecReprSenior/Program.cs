using System;

namespace DecReprSenior
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello");
                Console.WriteLine("Type the number for solution");
                int n = int.Parse(Console.ReadLine());

                Rearrange rearrange = new Rearrange(n);
                var result = rearrange.Solution();

                Console.WriteLine($"The result is {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Press Enter to exit");
                Console.ReadLine();
            }
        }
    }
}
