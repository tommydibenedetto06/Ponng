using Godot;
using System;

public partial class PlayerPong1 : StaticBody2D
{
	public override void _Ready()
	{
	}

	public override void _Process(double delta)
	{
		if (Input.IsKeyPressed(Key.W) && this.Position.Y > 128.0f)
		{
			this.Position += new Vector2(0, -10);

		}

		if (Input.IsKeyPressed(Key.S) && this.Position.Y < 952.0f)
		{
			this.Position += new Vector2(0, +10);
		}
	}


	public override void _PhysicsProcess(double delta)
	{
		base._PhysicsProcess(delta);

		var collisionInfo = MoveAndCollide(new Vector2(0, 0));
		if (collisionInfo != null)
			GD.Print(collisionInfo.GetPosition());

	}
}
