using Godot;
using System;

[GlobalClass] public partial class HurtboxComponent : Area2D
{
	[Signal] public delegate void HurtboxHurtedEventHandler();
	[Export] public Node2D HurtboxOf;

	public override void _Ready()
	{
		this.AddToGroup("hurtbox");
	}

	public void Hurt()
	{
		EmitSignal(SignalName.HurtboxHurted);
	}
}

