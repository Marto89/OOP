using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class DyingParticle : Particle
    {
        private int lifeTime;
        public DyingParticle(MatrixCoords position, MatrixCoords speed,int lifeTime):
            base(position,speed)
        {
            this.lifeTime = lifeTime;
        }
        public override bool Exists
        {
            get
            {
                return lifeTime>0;
            }
        }
        public override char[,] GetImage()
        {
            return new char [,]{{(char)2}};
        }
        public override IEnumerable<Particle> Update()
        {
            if(Exists)
            {
                lifeTime--;
            }

            return base.Update();
        }
    }
}
