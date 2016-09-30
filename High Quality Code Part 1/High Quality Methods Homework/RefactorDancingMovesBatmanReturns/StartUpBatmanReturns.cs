using System;
using System.Linq;

namespace RefactorDancingMovesBatmanReturns
{
    public class StartUpBatmanReturns
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var integerArray = ConvertInputStringToIntegerArray(input);

            var averageDancingMovesPoints = GetAverageDancingMovesPoints(integerArray);

            Console.WriteLine("{0:F1}", averageDancingMovesPoints);
        }

        private static int[] ConvertInputStringToIntegerArray(string inputStringArray)
        {
            var integerArray = inputStringArray.Split(' ').Select(int.Parse).ToArray();

            if (integerArray == null || integerArray.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty");
            }

            return integerArray;
        }

        private static double GetAverageDancingMovesPoints(int[] array)
        {
            double averageDancingMovesPoints = 0;
            int roundsCount = 0;            
            long sumOfPoints = 0;

            do
            {
                string line = Console.ReadLine();
                if (line == "stop")
                {
                    break;
                }
                else if (line == string.Empty)
                {
                    throw new ArgumentException("Dancing moves cannot be null or empty");
                }
                else
                {
                    var round = GetRoundFromLineInput(line);
                    sumOfPoints = GetSumOfPoints(array, round);
                    
                    roundsCount++;
                }
            }
            while (true);

                averageDancingMovesPoints = sumOfPoints / (double)roundsCount;           

                return averageDancingMovesPoints;
            }
            

        private static string[] GetRoundFromLineInput(string inputLine)
        {
            var round = inputLine.Split(' ').ToArray();

            if (round.Length != 3)
            {
                throw new ArgumentException("The round should have exactly 3 elements. Invalid input of line");
            }

            return round;
        }

        private static long GetSumOfPoints(int[] array, string[] round)
        {
            int position = 0;
            long sumOfPoints = 0;
            int startPosition = 0;

            int times = int.Parse(round[0]);
            string direction = round[1];
            int step = int.Parse(round[2]);

            position = startPosition;

            for (int i = 0; i < times * step; i += step)
            {
                if (direction == "right")
                {
                    position = (startPosition + step) % array.Length;
                }
                else if (direction == "left")
                {
                    position = (startPosition - step) % array.Length;
                    if (position < 0)
                    {
                        position += array.Length;
                    }
                }
                else
                {
                    throw new ArgumentException("Invalid input: direction should be right or left.");
                }

                sumOfPoints += array[position];
                startPosition = position;
            }

            return sumOfPoints;
        }
    }
}
