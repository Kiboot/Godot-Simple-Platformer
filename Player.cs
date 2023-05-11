using Godot;
using System;

public partial class Player : CharacterBody2D
{
	double moveSpeed = 100;
	double jumpForce = 200;
	double gravity = 500;
	
	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;
		if (!IsOnFloor())
		{
			velocity.Y += (float)(gravity * delta);
		}

		velocity.X = 0;

		if(Input.IsKeyPressed(Key.Left)){
			velocity.X -= (float)moveSpeed;
		}
		if(Input.IsKeyPressed(Key.Right)){
			velocity.X = (float)moveSpeed;
		}
		
	}
}
