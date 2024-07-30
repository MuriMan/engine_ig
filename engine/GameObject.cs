public class GameObject
{
	List<Component> Components = new List<Component>(100);

	public virtual void Start()
	{
		for (int i = 0; i < Components.Count; i++)
			Components[i].Start();
	}
	public virtual void Update(float dt)
	{
		for (int i = 0; i < Components.Count; i++)
			Components[i].Update(dt);
	}
	public virtual void Tick()
	{
		for (int i = 0; i < Components.Count; i++)
			Components[i].Tick();
	}
	public virtual void Draw()
	{
		for (int i = 0; i < Components.Count; i++)
			Components[i].Draw();
	}
}
