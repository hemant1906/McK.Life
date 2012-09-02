using System;
using System.Threading;
using McK.GameOfLife.Controller;

namespace GameOfLifeConsoleApp
{
    internal static class Program
    {
        private static void Main()
        {
            /*
            IPlayField playField = new PlayFieldGrid(5, 5);
            playField.InitializePlayField("01001101001");
            
            GameController controller = new GameController(playField, new ClassicRule(), null);
            
            playField = controller.GetGenration(2);
            */

            Console.WindowWidth = Console.LargestWindowWidth ;
            Console.WindowHeight = Console.LargestWindowHeight;
            Console.BufferWidth = Console.LargestWindowWidth;
            Console.BufferHeight = Console.LargestWindowHeight;


            //GameEngine game = new GameEngine(100, 100);
            //game.InitializeGame("001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100001000010000100");
            //for (int i = 0; i < 75; i++)
            //{
            //    Console.Clear();
            //    game.Render();
            //    Thread.Sleep(1000);
            //    game.Move(1);

            //}


            GameEngine game = new GameEngine(12,12);
            // 12x12 blinker
            string blinker = "000000000000000000000000000000000000000000100000000000100000000000100000000000000000";
            game.InitializeGame(blinker);
            for (int i = 0; i < 10; i++ )
            {
                Console.Clear();
                game.Render();
                Thread.Sleep(500);
                game.Move(1);
            }

            game = new GameEngine(6,6);
            string toad = "000000000100010010010010001000000000";
            game.InitializeGame(toad);
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                game.Render();
                Thread.Sleep(500);
                game.Move(1);
            }

            string beacon = "000000011000010000000010000110000000";
            game.InitializeGame(beacon);
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                game.Render();
                Thread.Sleep(500);
                game.Move(1);
            }


             game = new GameEngine(17,17);
            //17x17
            string pulsar = "0000000000000000000000000000000000000011100011100000000000000000000000100001010000100001000010100001000010000101000010000001110001110000000000000000000000000111000111000000100001010000100001000010100001000010000101000010000000000000000000000011100011100000000000000000000000000000000000000";
            game.InitializeGame(pulsar);
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                game.Render();
                Thread.Sleep(500);
                game.Move(1);
            }

            game = new GameEngine(10,10);
            string indef2 = "00000000000000000100000001011000000101000000010000000100000001010000000000000000";
            game.InitializeGame(indef2);
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                game.Render();
                Thread.Sleep(500);
                game.Move(1);
            }
                //var blinker = new Blinker();

                //for (int i = 0; i < 3; i++)
                //{
                //    blinker.Print(new Cell(-1, -2), new Cell(4, 4));
                //    blinker.Step();
                //}

                //var glider = new Glider();

                //for (int i = 0; i < 3; i++)
                //{
                //    var top = glider.Top;
                //    var left = glider.Left;
                //    var bottom = glider.Bottom;
                //    var right = glider.Right;

                //    glider.Print(new Cell(left - 1, top - 1), new Cell(right - left + 2, bottom - top + 2));
                //    glider.Step();
                //}

                Console.WriteLine("done");
            Console.ReadLine();
        }


        /*
        private static void Print(this CellCollection state, Cell topLeft, Cell size)
        {
            const char alive = '#';
            const char dead = ' ';

            Console.WriteLine("Generation {0} [({1}, {2}), ({3}, {4})] ({5} live cells)",
                              state.Generation,
                              topLeft.X, topLeft.Y,
                              topLeft.X + size.X, topLeft.Y + size.Y,
                              state.Count);

            for (int i = topLeft.Y; i <= topLeft.Y + size.Y; i++)
            {
                for (int o = topLeft.X; o <= topLeft.X + size.X; o++)
                {
                    Console.Write(state.Contains(o, i) ? alive : dead);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Generated in {0} ms.", state.MillisecondsToGenerate);
        }

        private class Blinker : CellCollection
        {
            public Blinker()
            {
                Add(0, 0);
                Add(1, 0);
                Add(2, 0);
            }
        }

        private class Glider : CellCollection
        {
            public Glider()
            {
                Add(1, 0);
                Add(2, 1);
                Add(0, 2);
                Add(1, 2);
                Add(2, 2);
            }
        }

        private class CellCollection : List<Cell>
        {
            public CellCollection(IEnumerable<Cell> cells)
                : this()
            {
                foreach (var cell in cells)
                    Add(cell);
            }

            public CellCollection()
            {
                Generation = 0;
                _stopwatch = new Stopwatch();
            }

            // Returns the amount of neighboring cells that are alive.
            private byte GetAliveNeighborsCount(int x, int y)
            {
                byte neighbors = 0;
                for (int i = -1; i <= 1; i++)
                {
                    for (int o = -1; o <= 1; o++)
                    {
                        if (i == 0 && o == 0)
                            continue;
                        if (Contains(x + i, y + o))
                            neighbors++;
                    }
                }
                return neighbors;
            }

            // Returns all neighboring cells.
            private IEnumerable<Cell> GetNeighbors(int x, int y)
            {
                for (int i = -1; i <= 1; i++)
                {
                    for (int o = -1; o <= 1; o++)
                    {
                        if (i == 0 && o == 0)
                            continue;

                        yield return new Cell(x + o, y + i);
                    }
                }
            }

            // Steps forward the specified amount of generations.
            public void Step(uint steps = 1)
            {
                _stopwatch.Restart();

                for (uint step = 0; step < steps; step++)
                {
                    Generation++;

                    // Variable to act as a snapshot of the current state while we make changes.
                    var oldState = new CellCollection(this);

                    // Variable to hold the cells that we will check.
                    var checkCells = new List<Cell>(oldState);

                    // Adds all dead cells neighboring alive cells to the cells that we will check.
                    checkCells.AddRange(
                        from cell in oldState
                        from neighbor in GetNeighbors(cell.X, cell.Y)
                        where !checkCells.Contains(neighbor)
                        select neighbor);

                    foreach (var cell in checkCells)
                    {
                        byte neighbors = oldState.GetAliveNeighborsCount(cell.X, cell.Y);

                        ///*
                        // * Checks if the current cell is alive or not.
                        // * 
                        // * If so, if the cell has less than 2, or more than 3 alive neighbors,
                        // * the cell will be killed.
                        // * 
                        // * If not, if the cell has 3 alive neighbors, the cell will be brought to life.
                        // *
                        if (oldState.Contains(cell.X, cell.Y))
                        {
                            if (neighbors < 2 || neighbors > 3)
                                Remove(cell);
                        }
                        else
                        {
                            if (neighbors == 3)
                                Add(cell);
                        }
                    }
                }

                _stopwatch.Stop();
            }

            public void Add(int x, int y)
            {
                Add(new Cell(x, y));
            }

            public bool Contains(int x, int y)
            {
                return Contains(new Cell(x, y));
            }

            public int Top
            {
                get { return (from cell in this orderby cell.Y ascending select cell.Y).First(); }
            }

            public int Bottom
            {
                get { return (from cell in this orderby cell.Y descending select cell.Y).First(); }
            }

            public int Left
            {
                get { return (from cell in this orderby cell.X ascending select cell.X).First(); }
            }

            public int Right
            {
                get { return (from cell in this orderby cell.X descending select cell.X).First(); }
            }

            public uint Generation { get; private set; }
            public long MillisecondsToGenerate { get { return _stopwatch.ElapsedMilliseconds; } }

            private readonly Stopwatch _stopwatch;
        }

        private struct Cell : IEquatable<Cell>
        {
            public Cell(int x, int y)
            {
                _x = x;
                _y = y;
            }

            private readonly int _x;

            public int X
            {
                get { return _x; }
            }

            private readonly int _y;

            public int Y
            {
                get { return _y; }
            }

            public bool Equals(Cell other)
            {
                return (X == other.X && Y == other.Y);
            }
        }

        */
    }
}