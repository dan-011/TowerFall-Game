using Godot;
using System;

public class BlockZ : Node2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		sprite = GetNode<AnimatedSprite>("AnimatedSprite");
		body = GetNode<RigidBody2D>("RigidBody2D");
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }

	public void SetMaterial(Material mat) {
		material = MaterialFactory.Instance.GetMaterial(mat);
		
		body.Mass = material.GetMass();
		body.Weight = material.GetWeight();
		body.GravityScale = material.GetGravityScale();
		body.Friction = material.GetFriction();
		
		sprite.Frame = material.GetFrameIndex();
	}
	AnimatedSprite sprite;
	RigidBody2D body;
	AbstractMaterial material;
}
