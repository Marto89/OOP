//Test the ChaoticParticle through the ParticleSystemMain class

//Test the ChickenParticle class through the ParcticleSystemMain class.

//Test the ParticleRepeller class through the ParticleSystemMain class

using System;
using System.Collections.Generic;

namespace ParticleSystem
{
    class ParticleSystemMain
    {
        private const int visibleRows = 40;
        private const int visibleCols = 40;
        static Random myRandomGenerator = new Random();
        static void Main()
        {
            
            IRenderer renderer=new ConsoleRenderer(visibleRows,visibleCols);
            IParticleOperator particleOperator=new ParticleUpdater();
            IParticleOperator advancedOperator = new AdvancedParticleUpdater();
            IParticleOperator masterOperator = new MasterParticleUpdater();
            var particles=new List<Particle>()
            {
                new Particle(new MatrixCoords(5, 5),new MatrixCoords(0, 0)),
                new ParticleEmitter(new MatrixCoords(30,30),new MatrixCoords(-1,-1),myRandomGenerator),
                //new ParticleEmitter(new MatrixCoords(10,30),new MatrixCoords(0,0),myRandomGenerator),
                //new DyingParticle(new MatrixCoords(0,0),new MatrixCoords(1,1),20),
                //new VariousLifeTimeParticleEmitter(new MatrixCoords(15,15),new MatrixCoords(0,0),myRandomGenerator),
               // new ParticleAttractor(new MatrixCoords(25,15),new MatrixCoords(0,0),1)
                //new ChaoticParticle(new MatrixCoords(20,20),new MatrixCoords(1,1),2,myRandomGenerator),
                //new ChickenParticle(new MatrixCoords(15,15),new MatrixCoords(1,1),2,myRandomGenerator,15),
                new ParticleRepeller(new MatrixCoords(15,15),new MatrixCoords(0,0),1,15)
            };
            Engine engine = new Engine(renderer, masterOperator, particles, 200);
            engine.Run();
        }
    }
}
