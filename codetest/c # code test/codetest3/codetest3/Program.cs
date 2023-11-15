using System;
using static System.Console;

namespace codetest3
{
    public class Cricket
    {
       public void Pointscalculation(int numberOfMatches)
        {
            int[] scores = new int[numberOfMatches];
            int sum = 0;
            for (int i=0; i < numberOfMatches; i++)
            {
                Write($"enter score for match{i + 1}:");
                if (int.TryParse(ReadLine(), out int score))
                {
                    scores[i] = score;
                    sum += score;

                }
                else
                {
                    WriteLine("invalid input please correct");
                    i--;
                }
            }
            double avg = (double)sum / numberOfMatches;
            WriteLine($"total points:{sum}");
            WriteLine($"avg points:{avg:average}");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Write("enter number of matches:");
            if(int.TryParse(ReadLine(),out int numberOfMatches) && numberOfMatches > 0)
            {
                Cricket cricket = new Cricket();
                cricket.Pointscalculation(numberOfMatches);
            }
            else
            {
                WriteLine("invalid input please correct");
            }

        }
    }

}
