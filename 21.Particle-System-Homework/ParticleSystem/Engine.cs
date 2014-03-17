using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ParticleSystem
{
    public class Engine
    {
        private IParticleOperator particleOperator;

        private List<Particle> particles;

        private IRenderer renderer;
        private int waitMS;

        public Engine(IRenderer renderer, IParticleOperator particleOperator, List<Particle> particles = null,int waitMS=1000)
        {
            this.renderer = renderer;
            this.particleOperator = particleOperator;

            if (particles != null)
            {
                this.particles = particles;
            }
            else
            {
                this.particles = new List<Particle>();
            }
            this.waitMS = waitMS;
        }

        public void AddParticle(Particle p)
        {
            this.particles.Add(p);
        }

        public void Run()
        {
            while (true)
            {
                renderer.RenderAll();

                renderer.ClearQueue();

                var producedParticles = new List<Particle>();
                foreach (var particle in this.particles)
                {    
                    producedParticles.AddRange(particleOperator.OperateOn(particle));
                }

                this.particles.RemoveAll((p) => !p.Exists);
                foreach (var particle in this.particles)
                {
                    renderer.EnqueueForRendering(particle);
                }
                particles.AddRange(producedParticles);
                particleOperator.TickEnded();


                Thread.Sleep(this.waitMS);
            }
        }
    }
}
