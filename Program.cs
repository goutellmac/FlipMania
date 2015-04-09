using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipMania
{
    class Program
    {
        static void Main(string[] args)
        {
            FlipCoin(10000);
            FlipForHeads(10000);
            Console.ReadKey();
            
        }
        public static void FlipCoin(int numberOfFlips)
        {
            Random rng = new Random();
            int headsCounter = 0;
            int tailsCounter = 0;
            int i = 0;
            while (i < numberOfFlips)
            {
                if (rng.Next(2) == 0)
                {
                    //heads
                    headsCounter++;
                    i++;
                    
                }
                else
                {
                    //tails
                    tailsCounter++;
                    i++;
                    
                }
                
            }
            Console.WriteLine("Number of heads = " + headsCounter);
            Console.WriteLine("Number of tails = " + tailsCounter);
            Console.WriteLine("We flipped a coin " + numberOfFlips + " times.");
        
        }

        public static void FlipForHeads(int numberOfHeads)
        {
            Random rng = new Random();
            int headsFlipped = 0;
            int totalFlips = 0;

            while (numberOfHeads != headsFlipped)
            {
                if (rng.Next(2) != 0)
                {
                    totalFlips++;
                }
                else
                {
                    headsFlipped++;
                    totalFlips++;
                }
            }
            Console.WriteLine("Wow!  It took " + totalFlips + " total flips to get " + numberOfHeads + " heads!");

        }
    }

    
        
 }

