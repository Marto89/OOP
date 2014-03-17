using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParticleSystem
{
    public class AdvancedParticleUpdater : ParticleUpdater
    {
        private List<Particle> currentTickParticles = new List<Particle>();
        private List<ParticleAttractor> currentTickAttractor = new List<ParticleAttractor>();
        public override IEnumerable<Particle> OperateOn(Particle p)
        {
            var potentialAttractor = p as ParticleAttractor;
            if(potentialAttractor !=null)
            {
                currentTickAttractor.Add(potentialAttractor);
            }
            else
            {
                this.currentTickParticles.Add(p);
            }
            return base.OperateOn(p);
        }
        public override void TickEnded()
        {
            foreach (var attractor in this.currentTickAttractor)
            {
                foreach (var particle in this.currentTickParticles)
                {
                    var currentParticleToAttractorVector=attractor.Position-particle.Position;
                    int pToAttrRow = currentParticleToAttractorVector.Row;
                    pToAttrRow = DecreaseVectorCoordToPower(attractor, pToAttrRow);

                    int pToAttrCol = currentParticleToAttractorVector.Col;
                    pToAttrCol = DecreaseVectorCoordToPower(attractor, pToAttrCol);

                    var currentAcceleration = new MatrixCoords(pToAttrRow, pToAttrCol);

                    particle.Accelerate(currentAcceleration);
                }
            }

            this.currentTickParticles.Clear();
            this.currentTickAttractor.Clear();
            base.TickEnded();
        }

        private static int DecreaseVectorCoordToPower(ParticleAttractor attractor, int pToAttrCoords)
        {
            if (Math.Abs(pToAttrCoords) > attractor.AttractionPower)
            {
                pToAttrCoords =
                    (pToAttrCoords / (int)Math.Abs(pToAttrCoords)) * attractor.AttractionPower;
            }
            return pToAttrCoords;
        }
    }
}
