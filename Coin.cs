using Godot;
using System;

public partial class Coin : Area2D
{
	float BobHeight = 5.0f;
	float BobSpeed = 5.0f;
	float StartY;
	Vector2 GPos = new Vector2();
	
	float T = 0.0f;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		StartY = GlobalPosition.Y;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		T += (float)delta;
		float d = (float)(Math.Sin( T * BobSpeed) + 1) / 2;
		GPos.Y = StartY + (d * BobHeight);
		GlobalPosition = GPos;
	}
	private void _on_body_entered(Node2D body)
	{
		if(body.IsInGroup("Player"))
		{
			((Player)body)._AddScore(1);
			QueueFree();
		}
	}
}
