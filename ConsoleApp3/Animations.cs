using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace ConsoleApp3
{
    class Animations
    {
        private static void DisplayHeader(string place)
        {
            if (place.Length > 0)
            {
                const int FRAME_LENGTH = 80;
                Console.WriteLine("+------------------------------------------------------------------------------+"); //80
                int placeLength = place.Length;
                for (int i = 0; i < FRAME_LENGTH / 2 - placeLength / 2 - 1; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(place);
                Console.WriteLine("+------------------------------------------------------------------------------+");
            }
        }

        public void Display(string place, string animation, int fps, bool loop, string text)
        {

            Regex reAnimation = new Regex(@"^" + animation);
            Match matchAnimation;
            Regex reAnimationNO = new Regex(@"(\d+)x(\d+)");
            Match matchAnimationNO;


            int lineNO = 0;
            int frameNO = 0;
            int currLine = 1;
            int currFrame = 1;
            foreach (string x in File.ReadAllLines("Animations.txt"))
            {
                matchAnimation = reAnimation.Match(x);
                if (matchAnimation.Success)
                {
                    //Console.WriteLine (x);
                    matchAnimationNO = reAnimationNO.Match(x);
                    if (matchAnimationNO.Success)
                    {
                        lineNO = Int32.Parse(matchAnimationNO.Groups[2].ToString()) + 1;
                        frameNO = Int32.Parse(matchAnimationNO.Groups[1].ToString());
                        //Console.WriteLine (lineNO + " " + frameNO);
                        break;
                    }
                }
                currLine++;
            }

            if (loop)
            {
                while (true)
                {
                    DisplayHeader(place);
                    Console.WriteLine();
                    if (text.Length > 0)
                    {
                        Console.WriteLine(text);
                    }
                    Console.WriteLine();
                    foreach (string x in File.ReadAllLines("Animations.txt"))
                    {
                        if (currFrame > currLine && currFrame < currLine + (lineNO * frameNO))
                        {
                            if ((currFrame - currLine) % lineNO == 0)
                            {
                                Thread.Sleep(fps);
                                Console.Clear();
                                DisplayHeader(place);
                                Console.WriteLine();
                                if (text.Length > 0)
                                {
                                    Console.WriteLine(text);
                                }
                            }
                            Console.WriteLine(x);
                        }
                        currFrame++;
                    }
                    currFrame = 1;
                    Thread.Sleep(fps);
                    Console.Clear();
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo c = Console.ReadKey(true);
                        if (c.Key == ConsoleKey.Enter)
                        {
                            break;
                        }
                    }
                }
            }
            else
            {
                DisplayHeader(place);
                Console.WriteLine();
                if (text.Length > 0)
                {
                    Console.WriteLine(text);
                }
                Console.WriteLine();
                foreach (string x in File.ReadAllLines("Animations.txt"))
                {
                    if (currFrame > currLine && currFrame < currLine + (lineNO * frameNO))
                    {
                        if ((currFrame - currLine) % lineNO == 0)
                        {
                            Thread.Sleep(fps);
                            Console.Clear();
                            DisplayHeader(place);
                            Console.WriteLine();
                            if (text.Length > 0)
                            {
                                Console.WriteLine(text);
                            }
                        }
                        Console.WriteLine(x);
                    }
                    currFrame++;
                }
            }



        }
    }
}
