namespace Homework_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var result = CountNumbersInPowerRange(2, 27, 4);
            //Console.WriteLine(result);

            //var result = CountSockPairs("AAABB");
            //Console.WriteLine(result);

            var result = GetLongestSuffix("Some Random Text", "It is Some Random Text");
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

        public static int CountSockPairs(string socks)
        {
            char[] charArray = socks.ToCharArray();
            Array.Sort(charArray);
            var sortedSocks = new string(charArray);

            var pairs = 0;

            for (var i = 0; i < sortedSocks.Length - 1; i++) {
                if (sortedSocks[i] == sortedSocks[i + 1]) {
                    pairs++;
                    i++;
                }
            }

            return pairs;


        }

        public static string GetLongestSuffix(string first, string second) {
            var suffix = "";

            var minLength = Math.Min(first.Length, second.Length);

            for (var i = 1; i <= minLength; i++) { 
                var charOne = first[first.Length - i];
                var charTwo = second[second.Length - i];

                if(charOne == charTwo)
                {
                    suffix = charOne + suffix;
                }
                else
                {
                    break;
                }
            }

            return suffix;
        }
    }
}
