using System;
using System.Threading;
using McK.GameOfLife.Controller;

namespace GameOfLifeConsoleApp
{
    internal static class Program
    {
        private static void Main()
        {
            Console.BufferWidth = Console.LargestWindowWidth;
            Console.BufferHeight = Console.LargestWindowHeight;
            MainMenu();

            ConsoleKeyInfo info = Console.ReadKey();

            do {
                GameEngine game;
                
                switch(info.KeyChar)
                {
                    case 'l':
                        game = new GameEngine(12, 12);
                        //// 12x12 blinker
                        string blinker = "000000000000000000000000000000000000000000100000000000100000000000100000000000000000";
                        RunGame(game, blinker, 20);
                        break;
                    case 't':
                        game = new GameEngine(6,6);
                        string toad = "000000000100010010010010001000000000";
                        RunGame(game, toad, 20);
                        break;
                    case 'b':
                        game = new GameEngine(6,6);
                        string beacon = "000000011000010000000010000110000000";
                        RunGame(game,beacon,20);
                        break;
                    case 'p':
                        game = new GameEngine(17,17);
                        string pulsar = "0000000000000000000000000000000000000011100011100000000000000000000000100001010000100001000010100001000010000101000010000001110001110000000000000000000000000111000111000000100001010000100001000010100001000010000101000010000000000000000000000011100011100000000000000000000000000000000000000";
                        RunGame(game,pulsar,20);
                        break;
                    case 'i':
                        game = new GameEngine(8,10);
                        string indef = "00000000000000000100000001011000000101000000010000000100000001010000000000000000";
                        RunGame(game, indef, 20);
                        break;
                    case 'c':
                        ExtendedMenu();
                        break;
                    default:
                        Console.WriteLine("Please press the key from above list");
                        break;
                }

                
                ClearPlayArea(7,17,17);
                Console.SetCursorPosition(0, 7);
                info = Console.ReadKey();

            } while ( info.KeyChar  != 'z'  ) ;
        }



        private static void MainMenu()
        {
            Console.WriteLine("press l for blinker");
            Console.WriteLine("press t for toad");
            Console.Write("press b for becon");
            Console.WriteLine("press p for pulser");
            Console.WriteLine("press i for infinite simple life");
            Console.WriteLine("press c for expended menu");
            Console.Write("Press z for exit");

            Console.SetCursorPosition(0, 7);
        }

        private static void ExtendedMenu()
        {
            Console.Clear();
            Console.WriteLine("input to be provided in following format");
            Console.WriteLine("row column generations state");
            Console.WriteLine("row and column should be a number > 4");
            Console.WriteLine("state should be in this format 0101011010101");
            Console.WriteLine("enter back to go back to previous menu");
            Console.SetCursorPosition(0, 7);
            string rawInput = Console.ReadLine();
            

            do
            {   
                int row =0, column =0, generations;
                try
                {

                    string[] inputs = rawInput.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    if (inputs.Length != 4 || !(int.TryParse(inputs[0], out row)) || !(int.TryParse(inputs[1], out column)) || !(int.TryParse(inputs[2], out generations)))
                    {
                        Console.WriteLine("Please enter input in this format ## ## 010110011010011001");
                    }
                    else
                    {
                        ClearPlayArea(6, 5, 100);
                        Console.SetCursorPosition(0, 7);
                        GameEngine engine = new GameEngine(row, column);
                        RunGame(engine, inputs[3], generations);
                        ClearPlayArea(6, row , column);
                        Console.SetCursorPosition(0, 7);

                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }

                rawInput = Console.ReadLine();
                ClearPlayArea(6, 20, 100);
                Console.SetCursorPosition(0, 7);
            } while (rawInput != "back");
            Console.Clear();
            MainMenu();
        }


        private static void RunGame(GameEngine engine, string initialState, int generations)
        {
            engine.InitializeGame(initialState);
            Console.ForegroundColor = ConsoleColor.Red;
            for(int generation = 0; generation < generations ; generation++ )
            {
                Console.SetCursorPosition(0, 7);
                engine.Render();
                Thread.Sleep(500); // wait for half a second
                engine.Move(1);
            }
            Console.ResetColor();
        }

        private static void ClearPlayArea(int startRow, int rows,  int columns)
        {

            Console.SetCursorPosition(0, startRow); 
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(Environment.NewLine);
            }
        }


    }
}