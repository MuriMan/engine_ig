using Godot;
using System;

public partial class Dummy : CharacterBody2D
{
	public override void _Ready()
	{
		this.GetNode<HurtboxComponent>("HurtboxComponent").HurtboxHurted += this.Hurted;
		this.GetNode<HealthComponent>("HealthComponent").HealthZeroed += this.Die;
	}

	public void Die()
	{
		GD.Print("YO SOY MUERTE");
		this.QueueFree();
	}

	public void Hurted()
	{
		this.GetNode<HealthComponent>("HealthComponent").HealthPoints -= 10;
	}
}
