using System;
using System.Collections.Generic;

namespace ParticleSystem
{
    public class MasterParticleUpdater : AdvancedParticleUpdater
    {
        private List<Particle> particles = new List<Particle>();
        private List<ParticleRepeller> repellers = new List<ParticleRepeller>();

        public override IEnumerable<Particle> OperateOn(Particle p)
        {
            var repellerCandidate = p as ParticleRepeller;
            if (repellerCandidate != null)
            {
                this.repellers.Add(repellerCandidate);
            }
            else
            {
                this.particles.Add(p);
            }
            return base.OperateOn(p);
        }
        public override void TickEnded()
        {
            foreach (var repeller in this.repellers)
            {
                foreach (var particle in this.particles)
                {
                    var currentParticleToAttractorVector = repeller.Position - particle.Position;
                    int pToAttrRow = currentParticleToAttractorVector.Row;
                    pToAttrRow = DecreaseVectorCoordToPower(repeller, pToAttrRow);

                    int pToAttrCol = currentParticleToAttractorVector.Col;
                    pToAttrCol = DecreaseVectorCoordToPower(repeller, pToAttrCol);

                    var currentAcceleration = new MatrixCoords(-pToAttrRow, -pToAttrCol);
                    int radius = (int)Math.Sqrt((Math.Pow((repeller.Position.Row - particle.Position.Row), 2) + Math.Pow((repeller.Position.Col - particle.Position.Col), 2)));
                    if (radius < repeller.RepellerPowerRadius)
                    {
                        particle.Accelerate(currentAcceleration);
                    }

                }
            }

            this.particles.Clear();
            this.repellers.Clear();
            base.TickEnded();
        }
        private static int DecreaseVectorCoordToPower(ParticleRepeller repeller, int pToAttrCoords)
        {
            if (Math.Abs(pToAttrCoords) > repeller.RepellerPower)
            {
                pToAttrCoords =
                    (pToAttrCoords / (int)Math.Abs(pToAttrCoords)) * repeller.RepellerPower;
            }
            return pToAttrCoords;
        }
    }
}
