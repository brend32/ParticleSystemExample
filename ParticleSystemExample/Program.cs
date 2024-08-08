using System.Diagnostics;
using ParticleSystemExample;

bool isRunning = true;
long lastRefreshTime = 0;
double refreshRate = 1.0 / 5.0;

ParticleSystem particleSystem = new ParticleSystem();

Console.CursorVisible = false;
while (isRunning)
{
	TimeSpan elapsedTime = Stopwatch.GetElapsedTime(lastRefreshTime);
	if (elapsedTime.TotalSeconds > refreshRate)
	{
		lastRefreshTime = Stopwatch.GetTimestamp();
 
		Console.Clear();
		particleSystem.Update();
		particleSystem.Render();
	}
	
	while (Console.KeyAvailable)
	{
                
		ConsoleKeyInfo key = Console.ReadKey(true);
		switch (key.Key)
		{
			case ConsoleKey.Spacebar:
				particleSystem.Spawn(3);
				break;
		}
	}
}