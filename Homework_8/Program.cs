namespace Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = CountNumbersInPowerRange(2, 27, 4);
            Console.WriteLine(result);
        }

        public static int CountNumbersInPowerRange(int a, int b, int n) {
            var count = 0;

            for (var i = 0; i <= b; i++) {
                double powerValue = Math.Pow(i, n);
                if (powerValue >= a && powerValue <= b)
                {
                    count++;
                }

                if (powerValue > b) {
                    break;
                }
            }

            return count;
        }
    }
}
