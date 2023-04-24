using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace ConsoleApp3
{
    class Scene
    {
        private string character;
        private string nickname;
        private ConsoleColor colour;

        public Scene()
        {
            this.character = "";
            this.nickname = "";
            this.colour = ConsoleColor.White;
        }

        public Scene(string character, string nickname, ConsoleColor colour = ConsoleColor.White)
        {
            this.character = character;
            this.nickname = nickname;
            this.colour = colour;
        }



        private void DisplayHeader(string place)
        {
            if (place.Length > 0)
            {
                const int FRAME_LENGTH = 70;
                Console.WriteLine("+--------------------------------------------------------------------+"); //70
                int placeLength = place.Length;
                for (int i = 0; i < FRAME_LENGTH / 2 - placeLength / 2 - 1; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(place);
                Console.WriteLine("+--------------------------------------------------------------------+");
            }
        }
        public void DisplayScene(string place, string text, ConsoleColor charactercolour = ConsoleColor.White)
        {
            Regex reCharacter = new Regex(this.character);
            Match matchCharacter;
            Regex reCharacterNO = new Regex(@"(\d+)");
            Match matchCharacterNO;
            int lineNO = 0;
            int currLine = 1;
            int startLine = -1;
            if (place.Length > 0)
            {
                DisplayHeader(place);
            }
            if (character.Length > 0)
            {
                Console.Write("\n\n\n");
                foreach (string x in File.ReadAllLines("Characters.txt"))
                {
                    matchCharacter = reCharacter.Match(x);
                    if (matchCharacter.Success)
                    {
                        matchCharacterNO = reCharacterNO.Match(x);
                        if (matchCharacterNO.Success)
                        {
                            lineNO = Int32.Parse(matchCharacterNO.Groups[1].ToString());
                            startLine = currLine;
                        }
                    }
                    if (currLine > startLine && currLine <= (startLine + lineNO) && startLine > 0)
                    {
                        Console.ForegroundColor = charactercolour;
                        Console.WriteLine(x);
                    }
                    currLine++;
                }
                Console.ForegroundColor = colour;
                Console.WriteLine(nickname + ":");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
                if (text.Length > 0)
                {
                    Console.WriteLine(" " + text);
                }
                else
                {
                    Console.Write(" ");
                }
            }
            else
            {
                Console.WriteLine("\n" + text);
            }

        }
    }
}
