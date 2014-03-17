//Create a ChaoticParticle class, which is a Particle, randomly changing its movement (Speed). You are not allowed to edit any existing class.

using System;

namespace ParticleSystem
{
    public class ChaoticParticle : Particle
    {
        public Random RandomGenerator { get; private set; }
        public int MaxSpeedPerCoordinate { get; private set; }
        public ChaoticParticle(MatrixCoords position,MatrixCoords speed,int maxSpeedPerCoordinate,Random randomGenerator)
            :base(position,speed)
        {
            this.RandomGenerator = randomGenerator;
            this.MaxSpeedPerCoordinate = maxSpeedPerCoordinate;
        }
        protected override void Move()
        {
            int randomSpeedPerRow=this.RandomGenerator.Next(-this.MaxSpeedPerCoordinate,this.MaxSpeedPerCoordinate+1);
            int randomSpeedPerCol=this.RandomGenerator.Next(-this.MaxSpeedPerCoordinate,this.MaxSpeedPerCoordinate+1);
            this.Speed=new MatrixCoords(randomSpeedPerRow, randomSpeedPerCol);
            this.Position += this.Speed;
        }
    }
}
