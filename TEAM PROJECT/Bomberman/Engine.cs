using System;
using System.Threading;
using System.Collections.Generic;

namespace Bomberman
{
    public class Engine
    {
        private ConsoleRenderer renderer;
        private IUserInterface userInterface;
        private List<GameObject> allObjects;
        private List<GameObject> staticObjects;
        private List<MovingObject> movingObjects;
        private Man bomberMan;
        private Bomb bomb;
        private bool isBomb = false;
        private int countForBomb = 0;

        public Engine(ConsoleRenderer renderer, IUserInterface userInterface)
        {
            this.renderer = renderer;
            this.userInterface = userInterface;
            this.allObjects = new List<GameObject>();
            this.staticObjects = new List<GameObject>();
            this.movingObjects = new List<MovingObject>();

        }
        private void AddMovingObject(MovingObject obj)
        {
            this.movingObjects.Add(obj);
            this.allObjects.Add(obj);
        }
        private void AddStaticObject(GameObject obj)
        {
            this.staticObjects.Add(obj);
            this.allObjects.Add(obj);
        }
        private void AddMan(GameObject obj)
        {
            this.bomberMan = obj as Man;
            this.AddStaticObject(obj);
        }
        public void AddObject(GameObject obj)
        {
            if (obj is MovingObject)
            {
                AddMovingObject(obj as MovingObject);
            }
            else
            {
                if (obj is Man)
                {
                    AddMan(obj as Man);
                }
                else
                {
                    AddStaticObject(obj as StaticObject);
                }
            }
        }
        public void MoveBomberManLeft()
        {
            if (renderer.consoleMatrix[bomberMan.TopLeft.Row, bomberMan.TopLeft.Col - 1] == ' ')
            {
                this.bomberMan.MoveLeft();
            }
        }
        public void MoveBomberManRigth()
        {
            if (renderer.consoleMatrix[bomberMan.TopLeft.Row, bomberMan.TopLeft.Col + 1] == ' ')
            {
                this.bomberMan.MoveRight();
            }
        }
        public void MoveBomberManUp()
        {
            if (renderer.consoleMatrix[bomberMan.TopLeft.Row - 1, bomberMan.TopLeft.Col] == ' ')
            {
                this.bomberMan.MoveUp();
            }
        }
        public void MoveBomberManDown()
        {
            if (renderer.consoleMatrix[bomberMan.TopLeft.Row + 1, bomberMan.TopLeft.Col] == ' ')
            {
                this.bomberMan.MoveDown();
            }
        }
        public void BombermanSetBomb()
        {
            
            this.bomb = new Bomb(new MatrixCoords(this.bomberMan.TopLeft.Row,this.bomberMan.TopLeft.Col));
            allObjects.Add(bomb);
            
            //this.bomberMan = new Man(new MatrixCoords(this.bomberMan.TopLeft.Row, this.bomberMan.TopLeft.Col));
           // allObjects.Add(bomberMan);
            isBomb = true;
            //ExplodeBomb();
            
        }

        public void ExplodeBomb()
        {
             allObjects.Remove(bomb);
        }

        public void Run()
        {

            while (true)
            {
                Thread.Sleep(200);
                countForBomb++;
                this.renderer.RendererAll();
                this.userInterface.ProcessInput();
                this.renderer.ClearFrame(); 
                foreach (var obj in allObjects)
                {
                    obj.Update(this.renderer.consoleMatrix);
                    this.renderer.LoadForRendering(obj);
                }
                if (isBomb == true && countForBomb == 30)
                {
                    ExplodeBomb();
                    countForBomb = 0;
                }
                List<GameObject> producedObjects = new List<GameObject>();
                
            }
        }
    }
}
