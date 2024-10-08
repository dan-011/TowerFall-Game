using Godot;
using System;
using System.Collections.Generic;

public class CardWidget : Node2D
{
	[Signal]
	public delegate void GetBlockEventHandler(int block);
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		cards = new List<Card>();
		for(int i = 0; i < NUM_CARDS; i++) cards.Add(GetNode<Card>("Card" + i.ToString()));
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }

	private void onClickCard0(int block)
	{
		
		EmitSignal("GetBlockEventHandler", block);
	}


	private void OnClickCard1(int block)
	{
		
		EmitSignal("GetBlockEventHandler", block);
	}


	private void OnClickCard2(int block)
	{
		
		EmitSignal("GetBlockEventHandler", block);
	}


	private void OnClickCard3(int block)
	{
		
		EmitSignal("GetBlockEventHandler", block);
	}


	private void OnClickCard4(int block)
	{
		
		EmitSignal("GetBlockEventHandler", block);
	}


	private void OnClickCard5(int block)
	{
		
		EmitSignal("GetBlockEventHandler", block);
	}

	List<Card> cards;
	const int NUM_CARDS = 6;
}
