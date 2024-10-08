using Godot;
using System;

public class Card : Node2D
{
	[Signal]
	public delegate void OnClickEventHandler(int block);

	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		shapeSprite = GetNode<AnimatedSprite>("ShapeSprite");
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }

	public int GetBlock() {
		return shapeSprite.Frame;
	}

	private void OnCardInputEvent(object viewport, object @event, int shape_idx)
	{
		if(@event is InputEventMouseButton && ((InputEventMouseButton)@event).IsPressed()) {
			EmitSignal("OnClickEventHandler", shapeSprite.Frame);
			shapeSprite.Visible = false;	
		}
	}

	private AnimatedSprite shapeSprite;

}
