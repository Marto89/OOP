namespace AcademyEcosystem
{
    using System;

    public class Boar : Animal, ICarnivore, IHerbivore
    {
        private int biteSize;
        public Boar(string name, Point location)
            : base(name, location, 4)
        {
            this.biteSize = 2;
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
            if (animal != null && animal.Size <= this.Size)
            {
                return animal.GetMeatFromKillQuantity();
            }

            return 0;
        }

        public int EatPlant(Plant p)
        {
            if (p != null)
            {
                this.Size += 1;
                return p.GetEatenQuantity(this.biteSize);
            }

            return 0;
        }
    }
}
