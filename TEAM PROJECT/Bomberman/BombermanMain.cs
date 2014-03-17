using System;
using System.Threading;
using System.IO;

namespace Bomberman
{
    public class BombermanMain
    {
        const int WorldRows = 39;
        const int WorldCols = 39;

        static void Initialize(Engine engine)
        {
            //Stanimir - adding a name;
            //Printing The logo
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            StreamReader logoReader = new StreamReader(@"../../Logo.txt");
            using (logoReader)
            {
                string line = logoReader.ReadLine();

                while (line!=null)
                {
                    Thread.Sleep(100);
                    Console.WriteLine(line);
                    line = logoReader.ReadLine();
                }
            }
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(20, 12);
            Console.WriteLine("WELCOME TO BOMBERMAN!  " + "ENTER YOUR BOMBERNAME: ");
            Console.SetCursorPosition(35, 14);
            string name = Console.ReadLine();
            Console.ResetColor();
            name.ToUpper();
            Player currentPlayer = new Player(name);
            Console.Clear();

            //If we have a high score at the end of the game;
            //StreamReader reader = new StreamReader(@"../../HighScores.txt");
            //using(reader)
            //{
            //    string line = Console.ReadLine();

            //    while (line!=null)
            //    {

            //        line = Console.ReadLine();
            //    }
            //}
            int startRow = 1;
            int startCol = 1;
            int endRow = WorldRows - 2;
            int endCol = WorldCols - 2;
            //left and right side border
            for (int row = 0; row < WorldRows; row++)
            {
                IndestructibleBlock borderLeft = new IndestructibleBlock(new MatrixCoords(row, 0));
                IndestructibleBlock borderRight = new IndestructibleBlock(new MatrixCoords(row, WorldCols - 1));
                engine.AddObject(borderLeft);
                engine.AddObject(borderRight);
            }
            //bottom and top border
            for (int col = 0; col < WorldRows; col++)
            {
                IndestructibleBlock borderTop = new IndestructibleBlock(new MatrixCoords(0, col));
                IndestructibleBlock borderBottom = new IndestructibleBlock(new MatrixCoords(WorldRows - 1, col));
                engine.AddObject(borderTop);
                engine.AddObject(borderBottom);
            }

            for (int row = startRow; row < endRow; row++)
            {
                for (int col = startCol; col < endCol; col++)
                {
                    if (row % 2 == 0 && col % 2 == 0)
                    {
                        IndestructibleBlock block = new IndestructibleBlock(new MatrixCoords(row, col));
                        engine.AddObject(block);
                    }
                }
            }
            Man bomberMan = new Man(new MatrixCoords(10, 11));
            GameObject movingObject = new Monster(new MatrixCoords(1, 1), Direction.UpDown);
            GameObject movingObject2 = new Monster(new MatrixCoords(9, 10), Direction.LeftRight);
           // GameObject bomb = new Bomb(new MatrixCoords(bomberMan.TopLeft.Row,bomberMan.TopLeft.Col));
            engine.AddObject(movingObject);
            engine.AddObject(movingObject2);
            engine.AddObject(bomberMan);
           // engine.AddObject(bomb);


        }
        static void Main()
        {

            ConsoleRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();
            Engine engine = new Engine(renderer, keyboard);

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                engine.MoveBomberManRigth();
            };
            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                engine.MoveBomberManLeft();
            };
            keyboard.OnDownPressed += (sender, eventInfo) =>
            {
                engine.MoveBomberManDown();
            };
            keyboard.OnUpPressed += (sender, eventInfo) =>
            {
                engine.MoveBomberManUp();
            };
            keyboard.OnActionPressed += (sender, eventInfo) =>
            {
                engine.BombermanSetBomb();
            };

            Initialize(engine);
            engine.Run();

        }


    }
}
