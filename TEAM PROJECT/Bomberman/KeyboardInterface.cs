using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomberman
{
    public class KeyboardInterface : IUserInterface
    {
        public void ProcessInput()
        {
            if (Console.KeyAvailable)
            {
                var keyInfo = Console.ReadKey(true);
                while (Console.KeyAvailable)
                {
                    keyInfo = Console.ReadKey(true);

                }
                if (keyInfo.Key.Equals(ConsoleKey.LeftArrow) || keyInfo.Key.Equals(ConsoleKey.A))
                {
                    this.OnLeftPressed(this, new EventArgs());// add some mothod                   
                }
                if (keyInfo.Key.Equals(ConsoleKey.UpArrow) || keyInfo.Key.Equals(ConsoleKey.W))
                {
                    this.OnUpPressed(this, new EventArgs());// add some mothod
                }
                if (keyInfo.Key.Equals(ConsoleKey.RightArrow) || keyInfo.Key.Equals(ConsoleKey.D))
                {
                    this.OnRightPressed(this, new EventArgs());// add some mothod
                }
                if (keyInfo.Key.Equals(ConsoleKey.DownArrow) || keyInfo.Key.Equals(ConsoleKey.S))
                {
                    this.OnDownPressed(this, new EventArgs());// add some mothod
                }
                if (keyInfo.Key.Equals(ConsoleKey.Spacebar))
                {
                    this.OnActionPressed(this, new EventArgs());// add some mothod
                }

            }
        }
        public event EventHandler OnLeftPressed;

        public event EventHandler OnRightPressed;

        public event EventHandler OnUpPressed;

        public event EventHandler OnDownPressed;

        public event EventHandler OnActionPressed;
    }
}
