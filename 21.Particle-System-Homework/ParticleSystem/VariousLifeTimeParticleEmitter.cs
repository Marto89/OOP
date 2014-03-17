using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class VariousLifeTimeParticleEmitter : ParticleEmitter
    {
        const int MaxParticleLifeTime = 7;
        public VariousLifeTimeParticleEmitter(MatrixCoords position, MatrixCoords speed, Random randomGenerator):
            base(position,speed,randomGenerator)
        {
        }
        protected override Particle GetNewParticle(MatrixCoords position, MatrixCoords speed)
        {
            bool createDying = this.randomGenerator.Next() % 2 == 0;
            if(createDying)
            {
                return new DyingParticle(position, speed,this.randomGenerator.Next(MaxParticleLifeTime));
            }
            return base.GetNewParticle(position,speed);
        }
    }
}
