using Godot;
using System;


public partial class Player : CharacterBody2D
{
	float moveSpeed = 100f;
	float jumpForce = 200f;
	float gravity = 500f;
	Vector2 velocity;
	public override void _PhysicsProcess(double delta)
	{
		velocity.X = 0;
		
		if (!IsOnFloor()) 
		{
			velocity.Y += gravity * (float)delta;
		}
		if(Input.IsActionPressed("Left") ){velocity.X -= moveSpeed;}
		if(Input.IsActionPressed("Right") ){velocity.X = moveSpeed;}
		//important as velocity was first invoked as an object
		
		if(Input.IsActionJustPressed("Jump") && IsOnFloor()){velocity.Y = -jumpForce;}
		
		Velocity = velocity;
		MoveAndSlide();
		
	}
}
