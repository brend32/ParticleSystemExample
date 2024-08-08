namespace ParticleSystemExample;

public class Particle
{
	public int X;
	public int Y;
	public int Lifetime = 5;
	public int Value;

	public Particle(int x, int y, int value)
	{
		X = x;
		Y = y;
		Value = value;
	}

	public bool IsAlive()
	{
		return Lifetime > 0;
	}

	public void MoveUp()
	{
		Y++;
		Lifetime--;
	}

	public void Render()
	{
		Console.SetCursorPosition(X, 10 - Y - 1);
		Console.Write($"+{Value}");
	}
}