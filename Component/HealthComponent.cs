using Godot;
using System;

[GlobalClass] public partial class HealthComponent : Node
{
	[Signal] public delegate void HealthZeroedEventHandler();
	[Export] public int HealthPoints = 0;

	public override void _Ready()
	{
		if (this.HealthPoints == 0)
			GD.PrintErr("HEALTH IS ZERO " + this.Name + this.GetParent().Name);
	}

	public override void _PhysicsProcess(double delta)
	{
		if (this.HealthPoints <= 0)
			this.EmitSignal(SignalName.HealthZeroed);
	}
}
