using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using System.Threading;

namespace ConsoleApp3
{
    class Program
    {
        

        static void Main(string[] args)
        {

            Dialogs dialogs = new Dialogs();
            Animations animations = new Animations();
            Audio audio = new Audio();


            //Console.SetWindowSize(80, 35);

            dialogs.TitleScreen(); 
            dialogs.Intro();
            dialogs.Captain1();
            dialogs.Empty1();
            dialogs.Minotaur1();

            // chess game
            ChessExamples chess1 = new ChessExamples();
            chess1.Chess1();
            Console.Clear();
            Console.WriteLine("Udało się!");
            Thread.Sleep(800);
            Console.Clear();
            Console.ReadKey();

            dialogs.Minotaur2();

            dialogs.DialogDeaths();
            
            // fight
            Fight fight1 = new Fight(200, 100, new int[] { 0, 40, 40, 50, 50, 70 }, new int[] { 20, 20, 30, 30, 30, 40 }, new int[] { 50, 50, 50, 50, 50, 70 }, new int[] { 20, 30, 30, 40, 50, 70 });

            dialogs.Faust();
            dialogs.Captain2();
            dialogs.Epilog();
        }
    }
}
