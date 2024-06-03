using Godot;
using System;

public partial class PlayerPong2 : StaticBody2D
{
	public override void _Input(InputEvent @event)
	{

	}

	public override void _Process(double delta)
	{
		if (Input.IsKeyPressed(Key.Up) && this.Position.Y > 128.0f)
		{
			this.Position += new Vector2(0, -10);
		}

		if (Input.IsKeyPressed(Key.Down) && this.Position.Y < 952.0f)
		{
			this.Position += new Vector2(0, +10);
		}
	}
}
