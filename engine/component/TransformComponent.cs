using System.Numerics;

public class TransformComponent : Component
{
	public Vector2 Position = Vector2.Zero;

	public TransformComponent(Vector2 pos)
	{
		this.Position = pos;
	}
}
