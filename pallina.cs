using Godot;
using System;
using System.Threading;

public partial class pallina : StaticBody2D
{
	// Called when the node enters the scene tree for the first time.

	private int speed = 700; 
	private Vector2 velocity = new Vector2(0, 0);
	private RandomNumberGenerator rng = new RandomNumberGenerator();

	  private int player1Score = 0;
    private int player2Score = 0;

	public override void _Ready()
	{

	}

	public override void _PhysicsProcess(double delta)
	{
		base._PhysicsProcess(delta);

		if(velocity.X == 0 && velocity.Y == 0 && Input.IsKeyPressed(Key.Enter))
		{
			velocity = new Vector2(700, 0);
		}


		var collisionInfo = MoveAndCollide((velocity * (float)delta));

		if (collisionInfo != null)
		{
			speed += 20;

			float angle = rng.RandfRange(0, 1f);

			velocity = (velocity.Bounce(collisionInfo.GetNormal()).Rotated(angle)).Normalized() * speed;


			Position += velocity * (float)delta;


			GD.Print(collisionInfo.GetPosition());
		}
		
		 if (Position.X < 26.0f)
        {
			 Position = new Vector2(968, 448);
			velocity = new Vector2(0, 0);
            player2Score++;
			GetNode<Label>("/root/Node2D/comtapunti/Label2").Text = player2Score.ToString();
			speed = 700;
           
        }
        if (Position.X > 1894.0f)
        {
           
           	Position = new Vector2(968, 448);
			velocity = new Vector2(0, 0);
			player1Score++;
			GetNode<Label>("/root/Node2D/comtapunti/Label1").Text = player1Score.ToString();
			speed = 700;

        }
	}
}