using Raylib_cs;
using static Raylib_cs.Raylib;

// also contains animation logic.
public class SpriteComponent : Component
{
	public List<Texture2D> Textures = new List<Texture2D>(100); 
	// the first of the tuple is the first index of the texture
	// in the animations in Textures. inclusive. the string is
	// the name of the animation
	public Dictionary<string, (int startIndex, int endIndex)> Animations = 
		new Dictionary<string, (int, int)>(100);

	private (int startIndex, int endIndex) currentAnimation;
	private int currentFrame;

	public SpriteComponent(List<Texture2D> textures, Dictionary<string, (int startIndex, int
	endIndex)> animations, (int startIndex, int endIndex) defaultAnimation) // ugly, i know
	{
		this.Textures = textures;
		this.Animations = animations;

		this.currentAnimation = defaultAnimation;
		this.currentFrame = this.currentAnimation.startIndex;
	}

	public override void Tick()
	{
		
	}

	private void playCurrentAnimation()
	{
			
	}
}
