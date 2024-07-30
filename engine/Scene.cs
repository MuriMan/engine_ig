public class Scene
{
	List<GameObject> GameObjects = new List<GameObject>(100);

	public virtual void Start()
	{
		for (int i = 0; i < GameObjects.Count; i++)
			GameObjects[i].Start();
	}
	public virtual void Update(float dt)
	{
		for (int i = 0; i < GameObjects.Count; i++)
			GameObjects[i].Update(dt);
	}
	public virtual void Tick()
	{
		for (int i = 0; i < GameObjects.Count; i++)
			GameObjects[i].Tick();
	}
	public virtual void Draw()
	{
		for (int i = 0; i < GameObjects.Count; i++)
			GameObjects[i].Draw();
	}
}
