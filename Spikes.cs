using Godot;
using System;

public partial class Spikes : Area2D
{
	private void _on_body_entered(Node2D body)
	{
		
		if (body.IsInGroup("Player"))
		{
			//body.game_over()
			((Player)body)._GameOver();
		}
	}
}
