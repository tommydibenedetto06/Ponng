using Godot;
using System;

public partial class Sprite2D : Godot.Sprite2D
{
	// Questo metodo è chiamato la prima volta che lo Sprite è caricato nella scena
	public override void _Ready()
	{
	}

	// Questo metodo è chiamato ad ogni frame (delta è il tempo in secondo dall'ultimo frame)
	public override void _Process(double delta)
	{
		if (Input.IsKeyPressed(Key.W))
			this.Position += new Vector2(0, -5);
	}

	// Questo metodo è chiamato ogni volta che accade un evento di input (anche mouse)
	// https://docs.godotengine.org/en/stable/tutorials/inputs/input_examples.html#keyboard-events
	public override void _Input(InputEvent @event)
	{
		// se l'eventoè di tipo tastiera ed è un evento di tipo "pressed" (potrebbe essere anche Released)
		if (@event is InputEventKey keyEvent && keyEvent.Pressed)
		{
			switch (keyEvent.Keycode)
			{
				case Key.T:
					// per scrivere nella console ci vuole GD.Print
					GD.Print(keyEvent.ShiftPressed ? "T" : "t");
					break;
			}
		}
	}
}
