using System;

namespace ArrayOfUniqueIntegers
{
    public static class Program
    {
        private static readonly Random _random = new Random();

        private static void Main(string[] args)
        {
            // Debugging
            var array = PrimitiveAlgorithm(100000);
        }

        public static int[] PrimitiveAlgorithm(int numberOfIntegers = 100000)
        {
            var array = new int[numberOfIntegers];
            for (var i = 0; i < numberOfIntegers; i++)
            {
                array[i] = i + 1;
            }

            var swapValue = 0;
            var swapIndex = 0;
            for (var i = 0; i < numberOfIntegers; i++)
            {
                swapIndex = _random.Next(1, numberOfIntegers);

                swapValue = array[i];
                array[i] = array[swapIndex];
                array[swapIndex] = swapValue;
            }

            return array;
        }
    }
}