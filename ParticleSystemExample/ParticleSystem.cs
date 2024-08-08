using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticleSystemExample;

class ParticleSystem
{
	private List<Particle> _particles = new List<Particle>();

	public void Update()
	{
		for (int i = 0; i < _particles.Count; i++)
		{
			Particle particle = _particles[i];
			
			particle.MoveUp();
			if (particle.IsAlive() == false)
			{
				_particles.Remove(particle);
				i--;
			}
		}
	}

	public void Spawn(int value)
	{
		int x = Random.Shared.Next(0, 20);
		int y = Random.Shared.Next(0, 4);
		
		_particles.Add(new Particle(x, y, value));
	}

	public void Render()
	{
		for (int i = 0; i < _particles.Count; i++)
		{
			Particle particle = _particles[i];
			
			particle.Render();
		}
	}
}
