using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bomberman
{
    public class ConsoleRenderer : IRenderer
    {
        private int gameConsoleRows;
        private int gameConsoleCols;
        public char[,] consoleMatrix;
        static ConsoleColor playerFieldBackgroundColor = ConsoleColor.Gray;
        static ConsoleColor playerFieldForegroundColor = ConsoleColor.Blue;

        public ConsoleRenderer(int visibleRows, int visibleCols)
        {
            consoleMatrix = new char[visibleRows, visibleCols];
            this.gameConsoleRows = visibleRows;
            this.gameConsoleCols = visibleCols;
            this.ClearFrame();
        }

        public void LoadForRendering(IRenderable obj)
        {
            char[,] objectImage = obj.GetImage();

            int imageRows = objectImage.GetLength(0);
            int imageCols = objectImage.GetLength(1);
            MatrixCoords objectTopLeft = obj.GetTopLeft();
            int lastRowsForLoading = Math.Min(objectTopLeft.Row + imageRows, this.gameConsoleRows);
            int lastColsForLoading = Math.Min(objectTopLeft.Col + imageCols, this.gameConsoleCols);
            for (int row = obj.GetTopLeft().Row; row < lastRowsForLoading; row++)
            {
                for (int col = obj.GetTopLeft().Col; col < lastColsForLoading; col++)
                {
                    if (row >= 0 && row < this.gameConsoleRows &&
                       col >= 0 && col < this.gameConsoleCols)
                    {
                        this.consoleMatrix[row, col] = objectImage[row - obj.GetTopLeft().Row, col - obj.GetTopLeft().Col];
                    }
                }
            }
        }

        public void RendererAll()
        {
            Console.SetCursorPosition(0, 0);

            StringBuilder allImage = new StringBuilder();
            for (int i = 0; i < this.gameConsoleRows; i++)
            {
                for (int j = 0; j < this.gameConsoleCols; j++)
                {
                    allImage.Append(this.consoleMatrix[i,j]);
                }
                allImage.Append(Environment.NewLine);
            }
            Console.BackgroundColor = playerFieldBackgroundColor;
            Console.ForegroundColor = playerFieldForegroundColor;
            Console.WriteLine(allImage.ToString());
        }

        public void ClearFrame()
        {
            for (int i = 0; i < this.gameConsoleRows; i++)
            {
                for (int j   = 0; j < this.gameConsoleCols; j++)
                {
                    this.consoleMatrix[i, j] = ' ';
                }
                
            }
        }
    }
}
