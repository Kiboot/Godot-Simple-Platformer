using Godot;
using System;

public partial class Enemy : Area2D
{
	[Export] float moveSpeed = 30.0f;
	[Export] Vector2 moveDirection = new Vector2();
	Vector2 startPosition = new Vector2();
	Vector2 targetPosition = new Vector2();
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		startPosition = GlobalPosition;
		targetPosition = startPosition + moveDirection;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		GlobalPosition = GlobalPosition.MoveToward(targetPosition, moveSpeed * (float)delta);

		if (GlobalPosition == targetPosition){
			if(GlobalPosition == startPosition){
				targetPosition = startPosition + moveDirection;
			}else{
				targetPosition = startPosition;
			}
		}
	}
}
