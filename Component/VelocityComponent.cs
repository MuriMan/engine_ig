using Godot;
using System;

[GlobalClass] public partial class VelocityComponent : Node
{
	[Export] Node2D VelocityOf;
	public Vector2 Velocity = Vector2.Zero;
	Vector2 Acceleration = Vector2.Zero;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	public override void _PhysicsProcess(double delta)
	{
		Vector2 prevVel = this.Velocity;
		this.Velocity += this.Acceleration * (float)delta;

		this.Velocity = (prevVel + this.Velocity) * (float)1/2 * (float)delta;
		
		this.VelocityOf.Position += this.Velocity * (float)delta;
	}
}
