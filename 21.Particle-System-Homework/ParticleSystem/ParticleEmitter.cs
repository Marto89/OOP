using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class ParticleEmitter : Particle
    {
        protected Random randomGenerator;
        const int MaxElementPerUpdateCount = 5;
        const int MaxSpeedPerCoordinate = 2;
        public ParticleEmitter(MatrixCoords position, MatrixCoords speed, Random randomGenerator) :
            base(position, speed)
        {
            this.randomGenerator = randomGenerator;
        }
        public override char[,] GetImage()
        {
            return new char[,]{{'$'}};
        }
        public override IEnumerable<Particle> Update()
        {
            IEnumerable<Particle> objectSoFar = base.Update();
            List<Particle>allGeneratesObjects=new List<Particle>();
            int objectsToCreateCount = this.randomGenerator.Next(MaxElementPerUpdateCount + 1);
            for (int i = 0; i < objectsToCreateCount; i++)
            {
                GetRandomParticle(allGeneratesObjects);
                

            }
            allGeneratesObjects.AddRange(objectSoFar);
            //allGeneratesObjects.RemoveAll((p) => p.Position.Equals(this.Position));
            return allGeneratesObjects;
        }

        protected virtual void GetRandomParticle(List<Particle> allGeneratesObjects)
        {
            var createdSpeed = GetRandomCoords();
            while (createdSpeed.Row == 0 && createdSpeed.Col == 0)
            {
                createdSpeed = GetRandomCoords();
            }

            allGeneratesObjects.Add(this.GetNewParticle(this.Position, createdSpeed));
        }
        protected virtual Particle GetNewParticle(MatrixCoords position,MatrixCoords speed)
        {
            return new Particle(position, speed);
        }
        protected MatrixCoords GetRandomCoords()
        {
            var createdSpeed =
                new MatrixCoords(this.randomGenerator.Next(-MaxSpeedPerCoordinate, MaxSpeedPerCoordinate + 1),
                                 this.randomGenerator.Next(-MaxSpeedPerCoordinate, MaxSpeedPerCoordinate + 1));
            return createdSpeed;
        }
    }
}
