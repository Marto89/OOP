﻿namespace AcademyEcosystem
{
    using System;

    public class Wolf : Animal, ICarnivore
    {
        public Wolf(string name, Point location)
            : base(name, location, 4)
        {
        }
        public override void Update(int timeElapsed)
        {
            if (this.State == AnimalState.Sleeping)
            {
                if (timeElapsed >= sleepRemaining)
                {
                    this.Awake();
                }
                else
                {
                    this.sleepRemaining -= timeElapsed;
                }
            }

            base.Update(timeElapsed);
        }
        public int TryEatAnimal(Animal animal)
        {
            if (animal != null && (animal.Size<=this.Size || animal.State==AnimalState.Sleeping))
            {
                return animal.GetMeatFromKillQuantity();
            }

            return 0;
        }
    }
}
