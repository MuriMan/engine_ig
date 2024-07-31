using Godot;
using System;

public partial class Player : CharacterBody2D
{
	HealthComponent HealthComponent;
	VelocityComponent VelocityComponent;
	HitboxComponent HitboxComponent;

	public override void _Ready()
	{
		this.HealthComponent = GetNode<HealthComponent>("HealthComponent");
		this.HealthComponent.HealthZeroed += this.HealthZeroed;

		this.VelocityComponent = GetNode<VelocityComponent>("VelocityComponent");
		this.HitboxComponent = GetNode<HitboxComponent>("HitboxComponent");
	}

	public override void _PhysicsProcess(double delta)
	{
		if (Input.IsActionPressed("ui_right"))
		{
			this.VelocityComponent.Velocity.X += 100000 * (float)delta;
		}
		if (Input.IsActionPressed("ui_left"))
		{
			this.VelocityComponent.Velocity.X -= 100000 * (float)delta;
		}
		if (Input.IsActionJustPressed("attack"))
		{
			GD.Print("attacked by player");
			this.HitboxComponent.Hurt();
		}

		this.Velocity = this.VelocityComponent.Velocity;
		this.MoveAndSlide();
	}

	public void HealthZeroed()
	{
		GD.Print("HI");
	}
}
