using Godot;
using System;

[GlobalClass] public partial class HitboxComponent : Area2D
{
	private bool hurtboxInRange = false;
	# nullable enable
	private HurtboxComponent? hurtbox;

	[Signal] public delegate void HurtHurtboxEventHandler();

	public override void _Ready()
	{
		this.AddToGroup("hitbox");

		this.AreaEntered += this._OnAreaEntered;
		this.AreaExited += this._OnAreaExited;
	}

	public override void _Process(double delta)
	{
	}

	public void Hurt()
	{
		GD.Print("this");
		if (hurtboxInRange && this.hurtbox != null)
		{
			this.HurtHurtbox += this.hurtbox.Hurt;
			this.EmitSignal(SignalName.HurtHurtbox);
		}
	}

	public void _OnAreaEntered(Area2D area)
	{
		if (area.IsInGroup("hurtbox"))
		{
			GD.Print("HI");
			this.hurtboxInRange = true;
			this.hurtbox = area as HurtboxComponent;
		}
	}

	public void _OnAreaExited(Area2D area)
	{
		if (area.IsInGroup("hurtbox"))
		{
			GD.Print("BYE");
			this.hurtboxInRange = false;
			this.hurtbox = null;
		}
	}
}

