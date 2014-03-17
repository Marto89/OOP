using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class ParticleAttractor : Particle
    {
        public int AttractionPower { get; protected set; }
        public ParticleAttractor(MatrixCoords position, MatrixCoords speed,int attroctionPower):
            base(position,speed)
        {
            this.AttractionPower = attroctionPower;
        }
    }
}
